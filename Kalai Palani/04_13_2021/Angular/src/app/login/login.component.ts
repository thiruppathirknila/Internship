import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Router } from "@angular/router";
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  invalidLogin: boolean ;
  hide = true;
  constructor(private router: Router, private http: HttpClient) { }
 
  public login = (form: NgForm) => {
    const credentials = JSON.stringify(form.value);
    this.http.post("http://localhost:47863/api/Employees/Login", credentials, {
      headers: new HttpHeaders({
        "Content-Type": "application/json"
      })
    }).subscribe(response => {
      const token = (<any>response).token;
      localStorage.setItem("jwt", token);
      this.invalidLogin = false;
      this.router.navigate(["/employee"]);
    }, err => {
      this.invalidLogin = true;
    });
  }
}
