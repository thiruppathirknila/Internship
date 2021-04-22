import { Injectable } from '@angular/core';
import{HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  getEmployee(leaves: any) {
    throw new Error('Method not implemented.');
  }

  constructor(private http:HttpClient) { }

  listLeave(){
    debugger;
    return this.http.get('http://localhost:47863/api/ApplyLeave')
  }
  postLeave(leaves:any){
    
    debugger;
    return this.http.post('http://localhost:47863/api/ApplyLeave',leaves);
  }
}
