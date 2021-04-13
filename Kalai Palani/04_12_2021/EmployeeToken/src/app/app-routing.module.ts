import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddEmployeeComponent } from './add-employee/add-employee.component';
import { EmployeeService } from './employee.auth';
import { EmployeeComponent } from './employee/employee.component';
import { LoginComponent } from './login/login.component';

const routes: Routes = [
 
      { path: '', component: LoginComponent },
      { path: 'login', component: LoginComponent },
      { path: 'employee', component: EmployeeComponent, canActivate: [EmployeeService] },
      {path:'add-employee',component:AddEmployeeComponent},
     { path: 'edit',component:AddEmployeeComponent},

     { path: '', redirectTo: 'employee', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
