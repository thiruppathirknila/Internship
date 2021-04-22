import { Component, OnInit } from '@angular/core';
import { Leave } from '../leave';
import {UserService} from 'src/app/user.service'

@Component({
  selector: 'app-leave',
  templateUrl: './leave.component.html',
  styleUrls: ['./leave.component.css']
})
export class LeaveComponent implements OnInit {
  
  leaves:any;
  service: any;

  constructor() { }

  ngOnInit(): void {
  }

  list(){
    debugger;
    this.service.listEmployee().subscribe((response: any) => {
      debugger;
      this.leaves = response;
    }, (err: any) => {
      console.log(err)
    });
   }
}
