import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CategoryListComponent } from './category/category-list/category-list.component';

import { HomeComponent } from './home/home.component';
import { RecipeCardComponent } from './recipe/recipe-card/recipe-card.component';
import { RecipeDetailComponent } from './recipe/recipe-detail/recipe-detail.component';
import { RecipeListComponent } from './recipe/recipe-list/recipe-list.component';
//import { ListsComponent } from './lists/lists.component';


//import { MessagesComponent } from './messages/messages.component';


//import { PreventUnsavedChangesGuard } from './_guards/prevent-unsaved-changes.guard';

const routes: Routes = [
  {path:'', component: HomeComponent},
  {path:'recipe/:categoryId', component: RecipeListComponent},
  {path:'recipes/:recipeId', component: RecipeDetailComponent},
  {path:'category', component: CategoryListComponent},
  //{path:'messages', component: MessagesComponent}, 
  {path:'**', component: HomeComponent, pathMatch:'full'}
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }