import { Category } from './category';

export interface Recipe {
    recipeId: number;
    recipeName: string;
    description: string;
    categoryId: number;
    totalPrice: number;
}