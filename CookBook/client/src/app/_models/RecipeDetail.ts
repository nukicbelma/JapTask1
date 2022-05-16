import { Ingredient } from "./ingredient";
import { Recipe } from "./recipe";

export interface RecipeDetail {
    reciepeDetailId: number;
    amount: number;
    unitMeasure:string;
    price:number;
    ingredient:Ingredient;
    recipe:Recipe;
    cost:number;
 }