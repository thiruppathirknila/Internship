import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { StudentDetailsComponent } from './student-details/student-details.component';
import { StudentDetailFormComponent } from './student-details/student-detail-form/student-detail-form.component';
import {FormsModule,ReactiveFormsModule} from '@angular/forms';
import {HttpClientModule} from '@angular/common/http';
import {AutocompleteLibModule} from 'angular-ng-autocomplete';
import { NgxSelectModule } from 'ngx-select-ex';

@NgModule({
  declarations: [
    AppComponent,
    StudentDetailsComponent,
    StudentDetailFormComponent
  ],
  imports: [
    BrowserModule,FormsModule,ReactiveFormsModule,HttpClientModule,BrowserAnimationsModule,
    AppRoutingModule,AutocompleteLibModule,NgxSelectModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
