import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {MatCardModule} from '@angular/material/card';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatFormFieldModule} from '@angular/material/form-field';
// import { ToastrModule } from 'ngx-toastr';
import {MatInputModule} from '@angular/material/input';
import {MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import {MatDatepickerModule} from '@angular/material/datepicker';
import { MatNativeDateModule} from '@angular/material/core';
import { RouterModule } from '@angular/router';
import { JwtModule } from "@auth0/angular-jwt";
import { ReactiveFormsModule } from "@angular/forms";
import {MatTableModule} from '@angular/material/table';
import { EmployeeComponent } from './employee/employee.component';
import { EmployeeService } from './employee.auth';
import { AddEmployeeComponent } from './add-employee/add-employee.component';


export function tokenGetter() {
  return localStorage.getItem("jwt");
}

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
   EmployeeComponent,
   AddEmployeeComponent,
  
   
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    MatIconModule,
    MatCardModule,
    MatTableModule,
    FormsModule,
    MatNativeDateModule,
    MatDatepickerModule,
    HttpClientModule,
    JwtModule.forRoot({
      config: {
        tokenGetter: tokenGetter,
        allowedDomains: ['localhost:47863'],
        disallowedRoutes: []
      }
    }),
   
    ReactiveFormsModule
  ],
  providers: [EmployeeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
