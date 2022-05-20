import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { recipeDetailInsertDto } from '../_models/recipeDetailInsertDto';

@Injectable({
  providedIn: 'root'
})
export class RecipeDetailService {
  baseUrl = environment.apiUrl;
  
  constructor(private http: HttpClient) { }

  addIngredients(recipeId:number, request: recipeDetailInsertDto)
  {
    return this.http.post(this.baseUrl+'recipeDetails/add/'+recipeId+'/', request);
  }  
}
