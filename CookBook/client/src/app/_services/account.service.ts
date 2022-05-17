import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ReplaySubject } from 'rxjs';
import { environment } from 'src/environments/environment';
import { AppUser } from 'src/app/_models/AppUser';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
baseUrl=environment.apiUrl;
private currentUserSource=new ReplaySubject <AppUser> (1);
currentUser$=this.currentUserSource.asObservable();

constructor(private http:HttpClient) { }

login(model:any)
{
  return this.http.post(this.baseUrl+ 'AppUser/Login/',model);
  /*.pipe(
    map((response:AppUser)=>{
      const user=response;
      if(user)
      {
        this.setCurrentUser(user);


      }
    })
  )*/
}

  setCurrentUser(appUser:AppUser)
  {
    
  }
}
