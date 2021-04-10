import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private jwtHelper: JwtHelperService, private router: Router) { }
     canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): boolean  {
      const token = localStorage.getItem("jwt");
  
      if (token && !this.jwtHelper.isTokenExpired(token)){
        console.log(this.jwtHelper.decodeToken(token));
        return true;
      }
      this.router.navigate(["/product"]);
      return false;
  }
  
    }

