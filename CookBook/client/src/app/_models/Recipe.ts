import { Category } from './category';
import { Ingredient } from './ingredient';

export interface Recipe {
    recipeId: number;
    ingredients:Ingredient[];
    recipeName: string;
    description: string;
    categoryId: number;
    totalPrice: number;
    category: Category;
}