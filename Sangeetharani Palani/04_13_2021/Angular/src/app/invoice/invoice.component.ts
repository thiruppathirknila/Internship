import { Component, OnInit } from '@angular/core';
import { jsonpFactory } from '@angular/http/src/http_module';
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
  ProductDetail:any;
  ProductDetails:Product[];
  selectedProduct: number; 
  productName: any;
  constructor(private service : AuthServiceService,private router : Router) { 
    debugger;
     this.invoice();

  }
  invoice () {
    debugger;
    // console.log(this.productList);
    // console.log(this.selectedProduct);
    // alert(this.selectedProduct);
    this.service.ListData().subscribe(response => {
      debugger;
     this.productList = response;    
//     return response;
          }, err => {
      console.log(err)
    });

     }

     logOut () {
      localStorage.removeItem("jwt");
      localStorage.clear();
      this.router.navigate(['/.login']);
    }
     
}
