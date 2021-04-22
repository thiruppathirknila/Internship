import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Invoice } from '../invoice';
//import { Invoice } from '../invoice';
import { Product } from '../product';
import { AuthServiceService } from '../shared/auth-service.service';

@Component({
  selector: 'app-invoice',
  templateUrl: './invoice.component.html',
  styleUrls: ['./invoice.component.css']
})
export class InvoiceComponent  {
  //products:Product[];
  productList:any;
  ProductDetail:any=[];
  ProductDetails:Product[];
  selectedProduct: number; 
  productName: any;
  sum:number=0;
  value:  any=[];
  invoiceslist:Invoice;

  //total:number;
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
         this.ProductDetail.push({productName:obj[0].productName,price:obj[0].price,quantity:obj[0].quantity,total:obj[0].total}); 
        
           } 
        //    invoicelist()
        // {
        //   this.findsum(this.ProductDetail);  
        // }
        //    findsum(data:any){    
        //     debugger  
        //     this.value=data    
        //     console.log(this.value);  
        //        for(let j=0;j<=data.length;j++){   
        //          this.sum+=this.value[j].total
        //             console.log(this.sum)  
        //     }
        //   }
        logout () {
        localStorage.removeItem("jwt");
        localStorage.clear();
        this.router.navigate(['/login']);
      }
     
}


