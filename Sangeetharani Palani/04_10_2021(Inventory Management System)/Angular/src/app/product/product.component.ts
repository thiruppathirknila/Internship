

import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { JwtHelperService } from '@auth0/angular-jwt';
import { Router, RouterModule } from '@angular/router';
import { FormBuilder, Validators } from '@angular/forms';
import { AuthServiceService } from '../shared/auth-service.service';
@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
  products: any;
  constructor(private http: HttpClient,private jwtHelper: JwtHelperService,private router: Router,private fb: FormBuilder,private service : AuthServiceService) { }
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
  if (confirm('Are you sure to delete this record?')) {
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
      this.router.navigate(['/add-product',{ id: productId }])
    }
      }
    
    
  logOut () {
     localStorage.removeItem("jwt");
     localStorage.clear();
     this.router.navigate(['/login']);
   }
  }

