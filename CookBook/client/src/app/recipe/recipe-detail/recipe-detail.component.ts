import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Category } from 'src/app/_models/Category';
import { Recipe } from 'src/app/_models/Recipe';
import { RecipeDetail } from 'src/app/_models/RecipeDetail';
import { RecipeService } from 'src/app/_services/recipe.service';
import { EnumUnits } from 'src/app/_models/EnumUnits';

@Component({
  selector: 'app-recipe-detail',
  templateUrl: './recipe-detail.component.html',
  styleUrls: ['./recipe-detail.component.css']
})
export class RecipeDetailComponent implements OnInit {
recipes: Recipe[];
recipeId;
ingredients:RecipeDetail[];



  constructor(private recipeService: RecipeService, private route: ActivatedRoute) { 
    this.recipeId=this.route.snapshot.paramMap.get('id');
    
  }

  ngOnInit(): void {
    this.getIngredients();
    this.getRecipe();
  }
  getIngredients(){
    this.recipeService.getIngredientsByRecipe(this.recipeId).subscribe(i=>{
      this.ingredients=i;
    })
  }

  getRecipe() {
    this.recipeService.getRecipesById(this.recipeId).subscribe(recipes => {
      this.recipes=recipes;
    })
  }


}
