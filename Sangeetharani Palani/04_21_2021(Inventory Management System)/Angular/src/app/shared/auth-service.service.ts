import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AuthServiceService  {
  
constructor(private http: HttpClient) { }

ListData() {
    debugger;
        return this.http.get("https://localhost:44384/api/UserProfile");
  }
    
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
CustomerList(){
  debugger;
        return this.http.get("https://localhost:44384/api/Customer/GetCustomer");
}
CustomerstoreData(customer : any) {
  debugger;
      return this.http.post('https://localhost:44384/api/Customer/PostCustomer', customer);
   
}
}
