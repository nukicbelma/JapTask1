import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Recipe } from '../_models/Recipe';

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
}
