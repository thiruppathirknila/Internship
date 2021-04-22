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
  id:number;

 constructor(private route : Router,public service:Employee1Service,private _avRoute: ActivatedRoute) {
  if (this._avRoute.snapshot.params["id"]) {  
   this.id = this._avRoute.snapshot.params["id"];
     }
   }
   ngOnInit() {
   this. employees={
     id:0,
     employeeId:"",
     employeeName:"",
     department:"",
     designation:"",
     email:"",
     dob:Date.now(),
     salary:0,
     role:""

   }
   if(this.id >0)
     {
       debugger;
        this.service.getEmployeeById(this.id).subscribe(result => 
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
