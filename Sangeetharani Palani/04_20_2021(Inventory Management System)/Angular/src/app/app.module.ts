import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { JwtModule } from "@auth0/angular-jwt";
import { ReactiveFormsModule } from "@angular/forms";
import { ProductComponent } from './product/product.component';
import { from } from 'rxjs';
import { AddProductComponent } from './add-product/add-product.component';
import{AuthServiceService} from 'src/app/shared/auth-service.service';
import { InvoiceComponent } from './invoice/invoice.component';
import { NavbarComponent } from './navbar/navbar.component';
import { InvoiceListComponent } from './invoice-list/invoice-list.component';


export function tokenGetter() {
  return localStorage.getItem("jwt");
}
@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,  
    ProductComponent,  
    AddProductComponent,
     InvoiceComponent,
     NavbarComponent,
     InvoiceListComponent,
    
    ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule, 
    JwtModule.forRoot({
      config: {
        tokenGetter: tokenGetter,
        allowedDomains: ['localhost:44384'],
        disallowedRoutes: []
      }
    }),ReactiveFormsModule
  ],
  providers: [AuthServiceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
