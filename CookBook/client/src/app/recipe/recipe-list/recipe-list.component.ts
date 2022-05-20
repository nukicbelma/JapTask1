import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Category } from 'src/app/_models/Category';
import { Pagination } from 'src/app/_models/Pagination';
import { Recipe } from 'src/app/_models/Recipe';
import { CategoryService } from 'src/app/_services/category.service';
import { RecipeService } from 'src/app/_services/recipe.service';

@Component({
  selector: 'app-recipe-list',
  templateUrl: './recipe-list.component.html',
  styleUrls: ['./recipe-list.component.css']
})
export class RecipeListComponent implements OnInit {
category: Category;
recipes: Recipe [];
categoryName:string;
categoryId;
pagination:Pagination;
pageNumber=1;
pageSize=10;


  constructor(private categoryService: CategoryService, private route: ActivatedRoute, private recipeService: RecipeService) {
    this.categoryId=this.route.snapshot.paramMap.get('id');
   }

  ngOnInit(): void {
    this.loadCategoryName();
    this.getRecipes();
  }

  loadCategoryName() {
    this.categoryService.loadCategoryById(this.categoryId).subscribe(category => {
      this.category=category;
      this.categoryName=this.category.name;
    })
  }
  /*getRecipes() {
    this.recipeService.getRecipesByCategory(this.categoryId).subscribe(recipes => {
      this.recipes=recipes;
      
    })
  }*/

  getRecipes(){
    this.recipeService.getRecipesPaging(this.categoryId,this.pageNumber,this.pageSize).subscribe(r=>{
      this.recipes=r.result;
      this.pagination=r.pagination;
      
    })
  }

  pageChanged(event:any)
  {
    this.pageNumber=event.page;
    this.getRecipes();
  }
}
