import { Component, OnInit } from '@angular/core';
import { FormControl, NgForm } from '@angular/forms';
import { Observable } from 'rxjs';
//import { ToastrService } from 'ngx-toastr';
import { StudentDetail } from 'src/app/shared/student-detail.model';
import { StudentDetailService } from 'src/app/shared/student-detail.service';
import{map,startWith} from 'rxjs/operators';
@Component({
  selector: 'app-student-detail-form',
  templateUrl: './student-detail-form.component.html',
  styles: [
  ]
})
export class StudentDetailFormComponent implements OnInit {
  control=new FormControl();
  districts:string[]=['Ariyalur','Chengalpet','Chennai','Coimbatore','Cuddalore','Dharmapuri',
  'Dindigul','Erode','Kallakurichi','Kancheepuram','Karur','Krishnagiri','Madurai','Nagapattinam',
  'Kanyakumari','Namakkal','Perambalur','Pudukottai','Ramanathapuram','Ranipet','Salem','Sivagangai',
  'Tenkasi','Thanjavur','Theni','Thiruvallur','Thiruvarur','Tuticorin','Trichirappalli','Thirunelveli',
  'Tirupathur','Tiruppur','Tiruvannamalai','Nilgiris','Vellore','Viluppuram','Virudhunagar'];

suggestions: Observable<string[]>;
  constructor(public service:StudentDetailService) { }
  formData:StudentDetail={
    stuId:0,
stuName:'',
gender:'',
dateOfBirth:'',
mobileno:'',
address:'',
district:''

  };
  student:StudentDetail[];
  ngOnInit(): void {
    this.resetForm();
this.suggestions=this.control.valueChanges
.pipe(
  startWith(''),
  map(value=>this._filter(value))
  );
  }
  private _filter(value:string):string[]{
    const filtervalue=value.toLowerCase();
    return this.districts.filter(data=>data.toLowerCase().includes(filtervalue));
  }
  resetForm(form?: NgForm) {
    if (form != null)
      form.form.reset();
    this.service.formData = {
      stuId: 0,
      stuName: '',
      gender: '',
      dateOfBirth: '',
      mobileno: '',
      address:'',      
      district:''    
      }
  }
  onSubmit(form:NgForm)
  {
    console.log(this.control.value);
    console.log(form.value.district );
    form.value.district=this.control.value
    this.insert(form);
   
   }
  insert(form:NgForm)
  {
    this.service.postStudentDetail(form.value).subscribe(res=>{
      //this.toastr.success('Successfully','Student Details is Register');
     // this.resetForm (form);
     this.service.refreshList();
      alert("Registration Successfully");
      this.resetForm(form);
    });
  }
}


