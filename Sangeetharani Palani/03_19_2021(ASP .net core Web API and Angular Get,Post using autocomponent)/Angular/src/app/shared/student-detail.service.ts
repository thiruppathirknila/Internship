import { Injectable } from '@angular/core';
import { StudentDetail } from './student-detail.model';
import{HttpClient} from '@angular/common/http';
import { FormControl } from '@angular/forms';
import { NgSelectModule } from '@ng-select/ng-select';
@Injectable({
  providedIn: 'root'
})
export class StudentDetailService {
  model : any[];
  student : StudentDetail[];
  
  constructor(private http:HttpClient) { }
  formData:StudentDetail={
    stuId:0,
    stuName:'',
    gender:'',
    dateOfBirth:'',
    mobileno:'',
    address:'',
    district:''
      };
    
      list:StudentDetail [];
      control=new FormControl();
 
      postStudentDetail(formData :StudentDetail){
        debugger;
      return this.http.post('http://localhost:53098/api/Student',formData);
      
    }
      getData1(value :any) {       
        debugger;
      return this.http.get('http://localhost:53098/api/Student',value);
      
    }
    
    refreshList() {
      debugger;
      this.http.get('http://localhost:53098/api/Student')
        .toPromise()
        .then(res =>this.list = res as StudentDetail[]);
    }
    }
