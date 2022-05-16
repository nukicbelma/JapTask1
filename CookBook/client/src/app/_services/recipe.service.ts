import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Recipe } from '../_models/Recipe';
import { RecipeDetail } from '../_models/RecipeDetail';

@Injectable({
  providedIn: 'root'
})
export class RecipeService {
  baseUrl = environment.apiUrl;
  
  constructor(private http: HttpClient) { }

  getRecipesByCategory(categoryId) {
    return this.http.get<Recipe[]>(this.baseUrl + 'recipe/getRecipesByCategory/' + categoryId);
  }
  getRecipesById(recipeId) {
    return this.http.get<Recipe[]>(this.baseUrl + 'recipe/getRecipesById/' + recipeId);
  }
  addRecipe(recipe:Recipe)
  {
    return this.http.post(this.baseUrl+'recipe/add', recipe);
  }
  getIngredientsByRecipe(recipeId)
  {
    return this.http.get<RecipeDetail[]>(this.baseUrl+'recipeDetail/getIngredientsByRecipe/'+recipeId);
  }
}
