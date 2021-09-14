import { ThrowStmt } from '@angular/compiler';
import { Injectable } from '@angular/core';
import { tick } from '@angular/core/testing';
import { BehaviorSubject, Observable, of, Subject } from "rxjs";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Response } from '../models/response';
import { User } from '../models/user';
import { map } from 'rxjs/operators';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { Login } from '../models/login';

const httpOption = {
  headers: new HttpHeaders({
    'Contend-Type': 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})

export class AuthService {
  url: string = 'https://localhost:44331/api/Usuario/login';

  private userSubject: BehaviorSubject<User>;  
  public get usuarioData(): User{
    return this.userSubject.value;
  }

  constructor(private http:HttpClient) {
    this.userSubject = new BehaviorSubject<User>(JSON.parse(localStorage.getItem('usuario')));
    
   }

   login(login: Login): Observable<Response>{
     return this.http.post<Response>(this.url, login, httpOption).pipe(
       map(res => {
         if(res.exito === 1){
           const usuario: User = res.data;
           localStorage.setItem('usuario',JSON.stringify(usuario));
           this.userSubject.next(usuario);
         }
         return res;
       })
     )
   }

   logOut(){
     localStorage.removeItem('usuario');
     this.userSubject.next(null);
   }
}
