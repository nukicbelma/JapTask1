import { Component, OnInit } from '@angular/core';
import { CategoryService } from 'src/app/_services/category.service';
import { Category } from 'src/app/_models/Category';

@Component({
  selector: 'app-category-list',
  templateUrl: './category-list.component.html',
  styleUrls: ['./category-list.component.css']
})
export class CategoryListComponent implements OnInit {
  categories:Category[];

  constructor(private categoryService:CategoryService) { 
    //this.userParams=this.memberService.getUserParams();
   }

  ngOnInit(): void {
    this.loadCategories();
  }

  loadCategories() {
    this.categoryService.getCategories().subscribe(category=> {
      this.categories=category;
    })
  }

}
