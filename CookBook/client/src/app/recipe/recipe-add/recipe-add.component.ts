import { Component, OnInit, ViewChildren } from '@angular/core';
import { FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Category } from 'src/app/_models/Category';
import { CategoryService } from 'src/app/_services/category.service';
import { RecipeService } from 'src/app/_services/recipe.service';

@Component({
  selector: 'app-recipe-add',
  templateUrl: './recipe-add.component.html',
  styleUrls: ['./recipe-add.component.css']
})
export class RecipeAddComponent implements OnInit {
  @ViewChildren('addForm') addForm:NgForm;
  selectedCategory: any;
  recipeAddForm: FormGroup;
  categories: Category[];
  
  


  constructor(private categoryService: CategoryService,
     private route:ActivatedRoute, private recipesService:RecipeService, private formBuilder:FormBuilder, private router:Router) {}


  ngOnInit(): void {
    this.getCategories();
    this.initializeForm();
  }

  getCategories() {
    this.categoryService.getCategories().subscribe(category => {
      this.categories=category;
    })
  }
  ChangeCategory(e)
  {
    this.selectedCategory=e.target.value;
  }
  initializeForm(){
    this.recipeAddForm=this.formBuilder.group({
      recipeName: ['',Validators.required],
      description:['',Validators.required],
      categoryId:['',Validators.required ]
    })
  }
  testSubmit()
  {
    console.log(this.recipeAddForm.value);
    this.recipesService.addRecipe(this.recipeAddForm.value).subscribe(()=>{
      this.router.navigateByUrl('/category');
    })
  }
}
