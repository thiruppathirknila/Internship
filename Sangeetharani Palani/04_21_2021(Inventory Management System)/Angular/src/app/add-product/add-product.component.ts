import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import{AuthServiceService} from 'src/app/shared/auth-service.service';

import { Product } from '../product';
@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent {
 products:Product;
  value : any;
  productId:number;
  constructor(private router : Router,private service : AuthServiceService,private _avRoute: ActivatedRoute) { 
    if (this._avRoute.snapshot.params["id"]) {  
      this.productId = this._avRoute.snapshot.params["id"];
    }
  }

  ngOnInit() {
    this.products={
    productId:0,
    productName:"",
    description:"",
    price:0,
   quantity:0,
   total:0
    }
    
    if(this.productId >0)
    {
      debugger;
      this.service.getProductById(this.productId).subscribe(result => 
        this.products = result)
        console.log(this.products)
      }
  }

  add(products:any) {  
    console.log(products);
    debugger;  
     this.service.storeData(products).subscribe((res: any) => {               
         this.value=res;   
         alert("Saved Successfully")  ;  
          console.log(this.value);           
          this.router.navigate(['product'])  
     })  
    }

    cancel() {  
    debugger;
    this.router.navigate(['product']);  
} 
logOut () {
  localStorage.removeItem("jwt");
  localStorage.clear();
  this.router.navigate(['/login']);
}
 
}
