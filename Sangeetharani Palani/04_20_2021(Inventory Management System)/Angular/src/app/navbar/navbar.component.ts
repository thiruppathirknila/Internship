import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Product } from '../product';
import { AuthServiceService } from '../shared/auth-service.service';
@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent{
products:any;
  constructor(private router: Router,private service : AuthServiceService) { }

  navbarOpen = false;

  toggleNavbar() {
    this.navbarOpen = !this.navbarOpen;
  }
    

  logOut () {
    localStorage.removeItem("jwt");
    localStorage.clear();
    this.router.navigate(['/login']);
  }
}
