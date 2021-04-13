import { Component, OnInit } from '@angular/core';
import {Employee1Service} from 'src/app/employee1.service';
import { Employee } from 'src/app/employee';
import { ActivatedRoute, Router } from "@angular/router";

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent implements OnInit {
  employees:Employee;
  value : any;
  employeeId:number;

 constructor(private route : Router,public service:Employee1Service,private _avRoute: ActivatedRoute) {
  if (this._avRoute.snapshot.params["id"]) {  
   this.employeeId = this._avRoute.snapshot.params["id"];
     }
   }
   ngOnInit() {
   this. employees={
     employeeId:0,
     employeeName:"",
     department:"",
     designation:"",
     dob:0,
     salary:0

   }
   if(this.employeeId >0)
     {
       debugger;
        this.service.getEmployeeById(this.employeeId).subscribe(result => 
        this.employees = result)
        console.log(this.employees)
       
      }
  
  }

  get(employees:any) {  
    console.log(employees);
    debugger;  
     this.service.postEmployee(employees).subscribe((res: any) => {               
         this.value=res;   
         alert("Saved Successfully")  ;  
         console.log(this.value); 
         this.route.navigate(['employee'])  
        })
   }
   cancel() {  
    debugger;
    this.route.navigate(['employee']); 
}
}
