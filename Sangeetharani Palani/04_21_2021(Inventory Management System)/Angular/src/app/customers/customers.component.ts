import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Customer } from '../customer';
//import { Invoice } from '../invoice';
import { AuthServiceService } from '../shared/auth-service.service';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.css']
})
export class CustomersComponent  {
  customers:any; 
  constructor(private service : AuthServiceService,private router : Router) { }
 
  listcustomers(){
    debugger;
    this.service.CustomerList().subscribe(res => {
      debugger;
      this.customers = res;
    }, err => {
      console.log(err)
    });
   }
   
   logOut () {
    localStorage.removeItem("jwt");
    localStorage.clear();
    this.router.navigate(['/login']);
  }
  }
