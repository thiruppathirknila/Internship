import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { FormBuilder, Validators } from '@angular/forms';
@Injectable({
  providedIn: 'root'
})
export class AuthServiceService  {

  constructor(private http: HttpClient) { }
  ListData() {
    debugger;
        return this.http.get("https://localhost:44384/api/UserProfile")
  }
  storeData(products : any) {
    debugger;
        return this.http.post('https://localhost:44384/api/UserProfile/PostProduct', products)
     
  }

    getProductById(id: number) {  
    debugger;
    return this.http.get<any>('https://localhost:44384/api/UserProfile/GetProduct/'+id);  
  }
  deleteData(productId : number) {
    debugger;
   return this.http.delete("https://localhost:44384/api/UserProfile/"+productId);
     
  }
}
