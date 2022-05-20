import { Component, OnInit, ViewChild, ViewChildren } from '@angular/core';
import { FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Ingredient } from 'src/app/_models/Ingredient';
import { IngredientService } from 'src/app/_services/ingredient.service';
import { RecipeDetailService } from 'src/app/_services/recipe-detail.service';

@Component({
  selector: 'app-recipe-ingredients-add',
  templateUrl: './recipe-ingredients-add.component.html',
  styleUrls: ['./recipe-ingredients-add.component.css']
})
export class RecipeIngredientsAddComponent implements OnInit {
  @ViewChild('addForm') addForm:NgForm; 
  ingredients: Ingredient[];
units: string[];
ingredientAddForm:FormGroup;
recipeId;
selectedIngredient:any;
selectedUnit:any;

  constructor(private ingredientService: IngredientService, 
              private route:ActivatedRoute,
              private recipeDetailService:RecipeDetailService,
              private fb:FormBuilder,
              private router:Router) { 

                this.recipeId = this.route.snapshot.paramMap.get('id');
              }


  ngOnInit(): void {
    this.getIngredients();
    this.getUnits();
    this.initializeForm();
  }

  initializeForm(){
    this.ingredientAddForm=this.fb.group({
      ingredientId: ['',Validators.required],
      amount:['',Validators.required],
      measure:['',Validators.required ]

    })
  }
  ChangeIgredient(e)
  {
console.log(e.target.value);
this.selectedIngredient=e.target.value;
  }

  ChangeUnits(e)
  {
console.log(e.target.value);
this.selectedUnit=e.target.value;
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
  testSubmit()
  {
    console.log(this.ingredientAddForm.value);
    this.recipeDetailService.addIngredients(this.recipeId,this.ingredientAddForm.value).subscribe(()=>{
      this.router.navigateByUrl('/recipes/'+this.recipeId);
    })

  }

  
}
