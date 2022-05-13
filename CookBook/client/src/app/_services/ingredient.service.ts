import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Ingredient } from '../_models/Ingredient';

@Injectable({
  providedIn: 'root'
})
export class IngredientService {
baseUrl=environment.apiUrl;

  constructor(private http: HttpClient) { }

  getIngredients() {
    return this.http.get<Ingredient[]>(this.baseUrl+'ingredient');
  }
  loadIngredientById(id) {
    return this.http.get<Ingredient>(this.baseUrl +'ingredient/getIngredientById/'+ id);
  }
  loadUnits() {
    return this.http.get<string[]>(this.baseUrl +'ingredient/getUnits');
  }
}
