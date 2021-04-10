import { Injectable } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { HttpClient , HttpHeaders} from "@angular/common/http";
@Injectable({
  providedIn: 'root'
})
export class UserService {
  constructor(private fb: FormBuilder, private http: HttpClient) { }
  formModel = this.fb.group({
  UserName: ['', Validators.required],
  Email: ['', Validators.email],
  FullName: [''],  
    Password: ['', [Validators.required, Validators.minLength(4)]]   
});

register() {
  var body = {
    UserName: this.formModel.value.UserName,
    Email: this.formModel.value.Email,
    FullName: this.formModel.value.FullName,
    Password: this.formModel.value.Password
  };
  return this.http.post('https://localhost:44336/api/ApplicationUser/Register', body);
}

login(formData: any) {
  return this.http.post('https://localhost:44336/api/ApplicationUser/Login', formData);
}

getUserProfile() {
  debugger;
  return this.http.get('https://localhost:44336/api/UserProfile');
}
}
