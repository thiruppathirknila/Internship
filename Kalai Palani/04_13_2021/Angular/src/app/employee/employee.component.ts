import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { JwtHelperService } from '@auth0/angular-jwt';
import { Router, RouterModule } from '@angular/router';
import { FormBuilder, NgForm } from '@angular/forms';
import { Observable } from 'rxjs';
import { Employee } from '../employee';
import {Employee1Service} from 'src/app/employee1.service';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {
  employees: any;
 


  constructor(private http: HttpClient,private jwtHelper: JwtHelperService,private router: Router,private fb: FormBuilder,private service : Employee1Service) { }

  ngOnInit() {

  }
  list(){
    debugger;
    this.service.listEmployee().subscribe(response => {
      debugger;
      this.employees = response;
    }, err => {
      console.log(err)
    });
   }
  
   delete(employeeId:number) {

      this.service.deleteEmployee(employeeId).subscribe(res => {    
       this.list();
       alert('Deleted Successfully');
        
      });
    }
  
  edit(employeeId:number){
    debugger;
          this.router.navigate(['/edit',{ id: employeeId }])
         
          this.list();
          alert('do you want edit?');
          // this.router.navigate(['/employee'])
    
      }
  logOut () {
    localStorage.removeItem("jwt");
    localStorage.clear();
    this.router.navigate(['/login']);
  }

}
