import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Category } from 'src/app/_models/Category';
import { PaginatedResult } from '../_models/Pagination';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
baseUrl= environment.apiUrl;
paginatedResult:PaginatedResult<Category[]>=new PaginatedResult<Category[]>();

  constructor(private http: HttpClient) { }

  getCategories() {
    return this.http.get<Category[]>(this.baseUrl+'category');
  }
  loadCategoryById(categoryId) {
    return this.http.get<Category>(this.baseUrl +'category/getCategoryById/'+ categoryId);
  }
  getCategoriesPaging(page?:number, itemsPerPage?:number)
  {
    let params=new HttpParams();
    if(page!==null && itemsPerPage!==null)
    {
      params=params.append('pageNumber',page.toString());
      params=params.append('pageSize',itemsPerPage.toString());

    }
    return this.http.get<Category[]>
          (this.baseUrl+'category/getCategoriesPaging', {observe:'response',params}).pipe(
            map(response=>{
              this.paginatedResult.result=response.body;
              if(response.headers.get('Pagination')!==null){
                this.paginatedResult.pagination=JSON.parse(response.headers.get('Pagination'));
              }
              return this.paginatedResult;
            })
          )      
  }
}


