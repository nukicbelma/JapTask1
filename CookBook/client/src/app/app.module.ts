import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CategoryListComponent } from './category/category-list/category-list.component';
import { CategoryCardComponent } from './category/category-card/category-card.component';
import { HomeComponent } from './home/home.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RecipeDetailComponent } from './recipe/recipe-detail/recipe-detail.component';
import { RecipeListComponent } from './recipe/recipe-list/recipe-list.component';
import { RecipeCardComponent } from './recipe/recipe-card/recipe-card.component';
import { CommonModule } from '@angular/common';
import { PaginationModule } from 'ngx-bootstrap/pagination';
import { RecipeAddComponent } from './recipe/recipe-add/recipe-add.component';
import { RecipeIngredientsAddComponent } from './recipe/recipe-ingredients-add/recipe-ingredients-add.component';
import { TextInputComponent } from './_forms/text-input/text-input.component';



@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    CategoryListComponent,
    CategoryCardComponent,
    HomeComponent,
    RecipeDetailComponent,
    RecipeListComponent,
    RecipeCardComponent,
    RecipeAddComponent,
    RecipeIngredientsAddComponent,
    TextInputComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule, 
    HttpClientModule, BrowserAnimationsModule, 
    FormsModule, 
    CommonModule,
    ReactiveFormsModule, 
    PaginationModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
