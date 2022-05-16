import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { PaginatedResult } from '../_models/Pagination';
import { Recipe } from '../_models/Recipe';
import { RecipeDetail } from '../_models/RecipeDetail';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class RecipeService {
  baseUrl = environment.apiUrl;
  paginatedResult:PaginatedResult<Recipe[]>=new PaginatedResult<Recipe[]>();

  
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
  getRecipesPaging(categoryId, page?:number, itemsPerPage?:number)
  {
    let params=new HttpParams();
    if(page!==null && itemsPerPage!==null)
    {
      params=params.append('pageNumber',page.toString());
      params=params.append('pageSize',itemsPerPage.toString());

    }
    return this.http.get<Recipe[]>
          (this.baseUrl+'recipe/getRecipesPaging/'+categoryId+'/', {observe:'response',params}).pipe(
            map(response=>{
              this.paginatedResult.result=response.body;
              if(response.headers.get('Pagination')!==null){
                this.paginatedResult.pagination=JSON.parse(response.headers.get('Pagination'));
              }
              return this.paginatedResult;
            })
          )      
  }
}
