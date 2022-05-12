import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CategoryListComponent } from './category/category-list/category-list.component';

import { HomeComponent } from './home/home.component';
import { RecipeListComponent } from './recipe/recipe-list/recipe-list.component';
//import { ListsComponent } from './lists/lists.component';


//import { MessagesComponent } from './messages/messages.component';


//import { PreventUnsavedChangesGuard } from './_guards/prevent-unsaved-changes.guard';

const routes: Routes = [
  {path:'', component: HomeComponent},
  {path:'recipe/:categoryName', component: RecipeListComponent},
  {path:'category', component: CategoryListComponent},
  //{path:'messages', component: MessagesComponent}, 
  {path:'**', component: HomeComponent, pathMatch:'full'}
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }