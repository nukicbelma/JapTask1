import { Ingredient } from "./ingredient";
import { Recipe } from "./recipe";

export interface RecipeDetail {
    id: number;
    amount: number;
    measure:string;
    price:number;
    ingredient:Ingredient;
    recipe:Recipe;
    cost:number;
 }