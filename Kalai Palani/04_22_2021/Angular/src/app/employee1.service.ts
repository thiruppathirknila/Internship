import { Injectable } from '@angular/core';
import{HttpClient} from '@angular/common/http';
import { FormControl} from '@angular/forms';
import { Employee } from 'src/app/employee';
import { Observable } from 'rxjs';



@Injectable({
  providedIn: 'root'
})
export class Employee1Service {
 
  
 

  constructor(private http:HttpClient) { }
 listEmployee(){
   debugger;
   return this.http.get('http://localhost:47863/api/EmployeeProfile')
 }
   
  postEmployee(employees:any){
    
    debugger;
    return this.http.post('http://localhost:47863/api/EmployeeProfile',employees);
  }
  
  getEmployeeById(id: number) {  
    debugger;
    return this.http.get<any>('http://localhost:47863/api/EmployeeProfile/GetEmployee/'+id);  
  }
  deleteEmployee(employeeId : number) {
    debugger;
   return this.http.delete("http://localhost:47863/api/EmployeeProfile/"+employeeId);
     
  }
}
