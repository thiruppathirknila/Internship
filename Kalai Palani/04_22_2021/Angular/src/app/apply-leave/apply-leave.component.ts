import { Component, OnInit } from '@angular/core';
import { Employee } from '../employee';
import { Leave } from '../leave';
import { ActivatedRoute, Router } from "@angular/router";
import { UserService } from '../user.service';


@Component({
  selector: 'app-apply-leave',
  templateUrl: './apply-leave.component.html',
  styleUrls: ['./apply-leave.component.css']
})
export class ApplyLeaveComponent implements OnInit {
  leaves:Leave;
  id:number;

  value: any;
  

  constructor(private route : Router,public service:UserService) { }

  ngOnInit(){
    this. leaves={
      id:0,
      employeeName:'',
      fromDate:0,
      endDate:0,
      leaveType:'',
      comments:'',
      status:''
    }
  }
  get(leaves:any){
    console.log(leaves)
    debugger;  
    this.service.postLeave(leaves).subscribe((res: any) => {               
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
 

