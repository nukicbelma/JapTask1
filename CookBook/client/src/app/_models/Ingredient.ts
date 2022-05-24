import { EnumUnits } from "./enumUnits";
export interface Ingredient {
    ingredientId: number;
    name: string;
    purchasePrice: number;
    purchaseAmount: number;
    purchaseMeasure: EnumUnits;
 } 