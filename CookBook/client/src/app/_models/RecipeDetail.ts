import { Ingredient } from "./ingredient";
import { Recipe } from "./recipe";
import { EnumUnits } from "./enumUnits";

export interface RecipeDetail {
    id: number;
    amount: number;
    measure:EnumUnits;
    price:number;
    ingredient:Ingredient;
    recipe:Recipe;
    cost:number;
    
 }