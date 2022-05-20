import { Component, OnInit } from '@angular/core';
import { CategoryService } from 'src/app/_services/category.service';
import { Category } from 'src/app/_models/Category';
import { Pagination } from 'src/app/_models/Pagination';

@Component({
  selector: 'app-category-list',
  templateUrl: './category-list.component.html',
  styleUrls: ['./category-list.component.css']
})
export class CategoryListComponent implements OnInit {
  categories:Category[];
  pagination:Pagination;
  pageNumber=1;
  pageSize=10;
  

  constructor(private categoryService:CategoryService) { 
    //this.userParams=this.memberService.getUserParams();
   }

  ngOnInit(): void {
    this.loadCategories();
  }
  loadCategories(){
    this.categoryService.getCategoriesPaging(this.pageNumber,this.pageSize).subscribe(category=>{
      this.categories=category.result;
      this.pagination=category.pagination;
    })
  }
  
  pageChanged(event:any)
  {
    this.pageNumber=event.page;
    this.loadCategories();
  }
}
