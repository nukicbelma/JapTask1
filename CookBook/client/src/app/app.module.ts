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
import { FormsModule } from '@angular/forms';
import { RecipeDetailComponent } from './recipe/recipe-detail/recipe-detail.component';
import { RecipeListComponent } from './recipe/recipe-list/recipe-list.component';
import { RecipeCardComponent } from './recipe/recipe-card/recipe-card.component';

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
  ],
  imports: [
    BrowserModule,
    AppRoutingModule, 
    HttpClientModule, BrowserAnimationsModule, 
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
