import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Category } from 'src/app/_models/Category';
import { Recipe } from 'src/app/_models/Recipe';
import { RecipeService } from 'src/app/_services/recipe.service';

@Component({
  selector: 'app-recipe-detail',
  templateUrl: './recipe-detail.component.html',
  styleUrls: ['./recipe-detail.component.css']
})
export class RecipeDetailComponent implements OnInit {
recipes: Recipe[];
recipeId;


  constructor(private recipeService: RecipeService, private route: ActivatedRoute) { 
    this.recipeId=this.route.snapshot.paramMap.get('recipeId');
  }

  ngOnInit(): void {
    this.getRecipe();
  }
  getRecipe() {
    this.recipeService.getRecipesById(this.recipeId).subscribe(recipes => {
      this.recipes=recipes;
    })
  }

}
