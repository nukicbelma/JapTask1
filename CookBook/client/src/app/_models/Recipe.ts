import { Category } from './category';
import { Ingredient } from './ingredient';

export interface Recipe {
    id: number;
    ingredients:Ingredient[];
    name: string;
    description: string;
    categoryId: number;
    totalPrice: number;
    category: Category;
}