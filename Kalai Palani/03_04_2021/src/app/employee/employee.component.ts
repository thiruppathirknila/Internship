import { Component } from '@angular/core';



@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent  {
  employeess:any[]=[
    {Id:1,Name:'emp1',Gender:'Male',City:'cbe',Salary:12000,DOB:'12/6/1992'},
    
    {Id:2,Name:'emp2',Gender:'FeMale',City:'chennai',Salary:15000,DOB:'1/6/1995'},
    
    {Id:3,Name:'emp3',Gender:'Female',City:'tvl',Salary:16000,DOB:'8/22/1996'}
  ];

}
