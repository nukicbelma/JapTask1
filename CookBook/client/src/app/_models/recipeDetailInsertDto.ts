import { Ingredient } from './Ingredient';

export interface recipeDetailInsertDto {
    recipeId: number;
    ingredientId: number;
    amount: number;
    unitMeasure: string;
}