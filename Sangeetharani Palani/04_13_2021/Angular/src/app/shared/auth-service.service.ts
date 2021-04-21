import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { HttpClient, HttpHeaders } from '@angular/common/http';
//import { Response } from '@angular/common/http';
import { FormBuilder, Validators } from '@angular/forms';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { Product } from '../product';
//import {Response} from '@angular/http';
@Injectable({
  providedIn: 'root'
})
export class AuthServiceService  {
  
constructor(private http: HttpClient) { }

ListData() {
    debugger;
        return this.http.get("https://localhost:44384/api/UserProfile");
  }


  // public GetAllProduct(): Observable<Product[]>   
  //   {  
  //     debugger;
  //       var test =  this.http.get("https://localhost:44384/api/UserProfile") .pipe(map((res:any) => res.json()));
  //       return this.http.get("https://localhost:44384/api/UserProfile") .pipe(map((res:any) => res.json()));
           
  //   }  
 

    
storeData(products : any) {
    debugger;
        return this.http.post('https://localhost:44384/api/UserProfile/PostProduct', products);
     
  }

getProductById(id: number) {  
    debugger;
    return this.http.get<any>('https://localhost:44384/api/UserProfile/GetProduct/'+id);  
  }

deleteData(productId : number) {
    debugger;
   return this.http.delete("https://localhost:44384/api/UserProfile/"+productId);
     
  }

  
 
//   errorHandler(error: Response) {  
//     console.log(error);  
//     return Observable.throw(error);  
// }  
}
