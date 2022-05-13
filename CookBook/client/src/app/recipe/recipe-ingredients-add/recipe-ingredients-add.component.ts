import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Ingredient } from 'src/app/_models/Ingredient';
import { IngredientService } from 'src/app/_services/ingredient.service';

@Component({
  selector: 'app-recipe-ingredients-add',
  templateUrl: './recipe-ingredients-add.component.html',
  styleUrls: ['./recipe-ingredients-add.component.css']
})
export class RecipeIngredientsAddComponent implements OnInit {
ingredients: Ingredient[];
units: string[];

  constructor(private ingredientService: IngredientService, private route:ActivatedRoute) { }

  ngOnInit(): void {
    this.getIngredients();
    this.getUnits();
  }

  getIngredients() {
    this.ingredientService.getIngredients().subscribe(ingredient => {
      this.ingredients=ingredient;
    })
  }

  getUnits() {
    this.ingredientService.loadUnits().subscribe(unit => {
      this.units=unit;
    })
  }
}
