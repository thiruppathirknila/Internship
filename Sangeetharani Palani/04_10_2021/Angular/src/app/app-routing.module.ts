import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddProductComponent } from './add-product/add-product.component';
import { AuthGuard } from './auth.guard';
import { LoginComponent } from './login/login.component';
import { ProductComponent } from './product/product.component';
//import { AuthServiceService } from './shared/auth-service.service';

const routes: Routes = [
  {path:'',redirectTo:'/login',pathMatch:'full'},
  {
    path: 'login', component: LoginComponent,
    children: [
       { path: 'product', component: ProductComponent }
      // {path:'add-product',component:AddProductComponent}
    ]
  },
  {path:'product',component:ProductComponent,canActivate:[AuthGuard]},
  {path:'add-product',component:AddProductComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
