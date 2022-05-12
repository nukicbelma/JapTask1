import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Category } from 'src/app/_models/Category';
import { Recipe } from 'src/app/_models/Recipe';
import { CategoryService } from 'src/app/_services/category.service';
import { RecipeService } from 'src/app/_services/recipe.service';

@Component({
  selector: 'app-recipe-card',
  templateUrl: './recipe-card.component.html',
  styleUrls: ['./recipe-card.component.css']
})
export class RecipeCardComponent implements OnInit {
@Input() recipe: Recipe;


  constructor() {
   
   }

   ngOnInit():void {

   }
}
