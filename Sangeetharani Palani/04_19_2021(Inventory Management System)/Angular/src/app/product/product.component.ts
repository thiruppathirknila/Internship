import { Component, OnInit } from '@angular/core';

import { Router} from '@angular/router';
import { AuthServiceService } from '../shared/auth-service.service';
@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
 
  products: any;
  constructor( private router: Router,private service : AuthServiceService) { }
    ngOnInit(){

    }
 list(){
  debugger;
  this.service.ListData().subscribe(response => {
    debugger;
    this.products = response;
  }, err => {
    console.log(err)
  });
 }

delete(productId:number) {
  if (confirm('Are you sure to Delete this Product?')) {
    this.service.deleteData(productId).subscribe(res => {    
     this.list();
     alert('Deleted Successfully');
      
    });
  }
}

edit(productId:number){
    debugger;
    const ans = confirm('Do You Want to Edit the Product '+ productId)
    if(ans){
      this.router.navigate(['/edit-product',{ id: productId }])
    }
      }
    
    
      logout () {
     localStorage.removeItem("jwt");
     localStorage.clear();
     this.router.navigate(['/login']);
   }
}

