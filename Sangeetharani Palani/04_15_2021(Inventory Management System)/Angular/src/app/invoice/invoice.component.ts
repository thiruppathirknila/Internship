import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Product } from '../product';
import { AuthServiceService } from '../shared/auth-service.service';

@Component({
  selector: 'app-invoice',
  templateUrl: './invoice.component.html',
  styleUrls: ['./invoice.component.css']
})
export class InvoiceComponent  {
  products:Product[];
  productList:any;
  ProductDetail:any=[];
  ProductDetails:Product[];
  selectedProduct: number; 
  productName: any;
  sum:number = 0;
  value:  any;
  constructor(private service : AuthServiceService,private router : Router) { 
    debugger;

    this.service.ListData().subscribe(response => {
      debugger;
     this.productList = response;    

          }, err => {
      console.log(err)
    });
  }
  invoice () {
    debugger;
     console.log(this.productList);  
    }

     SelectProduct(productName: string) {  
       debugger;
      let obj = this.productList.filter((m: { productName: string; })=>m.productName ==productName);    
      this.ProductDetail=obj;
      return this.ProductDetail;
     }
        
           
          
       logout () {
        localStorage.removeItem("jwt");
        localStorage.clear();
        this.router.navigate(['/login']);
      }
     
}


