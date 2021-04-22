// import { Component, OnInit } from '@angular/core';
// import { Router } from '@angular/router';
// import { Product } from '../product';
// import { AuthServiceService } from '../shared/auth-service.service';
// @Component({
//   selector: 'app-navbar',
//   templateUrl: './navbar.component.html',
//   styleUrls: ['./navbar.component.css']
// })
// export class NavbarComponent{
// products:any;
// productList:any;
// ProductDetail:any=[];
//   constructor(private router: Router,private service : AuthServiceService) { }

//   navbarOpen = false;

//   toggleNavbar() {
//     this.navbarOpen = !this.navbarOpen;
//   }
    
//   list(){
//     debugger;
//     this.service.ListData().subscribe(response => {
//       debugger;
//       this.products = response;
//     }, err => {
//       console.log(err)
//     });
//    }
//   //  invoice () {
//   //   debugger;
//   //    console.log(this.productList);  
//   //   }

//   //    SelectProduct(productName: string) {  
//   //      debugger;
//   //     let obj = this.productList.filter((m: { productName: string; })=>m.productName ==productName);    
//   //        this.ProductDetail.push({productName:obj[0].productName,price:obj[0].price,quantity:obj[0].quantity,total:obj[0].total}); 
        
//   //          } 
//   logOut () {
//     localStorage.removeItem("jwt");
//     localStorage.clear();
//     this.router.navigate(['/login']);
//   }
// }
