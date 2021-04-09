import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-student-data',
  templateUrl: './student-data.component.html',
  styleUrls: ['./student-data.component.css']
})
export class StudentDataComponent 
{ student:any[]=[
  {Id:1,Name:'Stu1',Gender:'Female',DOB:'12/03/1996',Fees:10000},
  
  {Id:2,Name:'Stu2',Gender:'Male',DOB:'03/06/1987',Fees:12000},
  
  {Id:3,Name:'Stu3',Gender:'Female',DOB:'06/02/1999',Fees:12500}
];

}
