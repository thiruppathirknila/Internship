import { Component, OnInit } from '@angular/core';
import { StudentDetail } from '../shared/student-detail.model';
import {StudentDetailService} from 'src/app/shared/student-detail.service'
import { FormControl } from '@angular/forms';
import { Observable } from 'rxjs';
import { map, startWith } from 'rxjs/operators';


@Component({
  selector: 'app-student-details',
  templateUrl: './student-details.component.html',
  styles: [
  ]
})
export class StudentDetailsComponent implements OnInit {
  model : any[];
  student : StudentDetail[];
 

  constructor(public service:StudentDetailService) { }

  ngOnInit(): void {
    debugger;
    this.loadData(this.model);
    this.service.refreshList();
  }
  loadData(model : any)
  {
    debugger;
    this.service.getData1(model).subscribe((data: any) => {            
this.student = data;
          console.log(this.student);      
  },
      (err) => {

          console.log(err);
      });
  }

}
