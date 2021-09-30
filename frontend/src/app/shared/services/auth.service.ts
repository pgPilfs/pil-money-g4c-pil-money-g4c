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
import { Cuenta } from '../models/cuenta';

/*const httpOption = {
  headers: new HttpHeaders({
    'Contend-Type': 'application/json'
  })
}*/

@Injectable({
  providedIn: 'root'
})

export class AuthService {
  resourceUrl: string;

  resourceUrl2: string;

  private userSubject: BehaviorSubject<User>;  
  public usuario: Observable<User>;

  private cuentaSubject: BehaviorSubject<Cuenta>;  
  public cuenta: Observable<Cuenta>; 
  

  public get usuarioData(): User{
    return this.userSubject.value;
  }

  public get cuentaData(): Cuenta{
    return this.cuentaSubject.value;
  }

  constructor(private httpClient:HttpClient) {
    this.userSubject = new BehaviorSubject<User>(JSON.parse(localStorage.getItem('usuario')));
    this.usuario  = this.userSubject.asObservable();

    this.cuentaSubject = new BehaviorSubject<Cuenta>(JSON.parse(localStorage.getItem('cuenta')));
    this.cuenta  = this.cuentaSubject.asObservable();

    this.resourceUrl = 'https://localhost:44357/api/Usuario/';

    this.resourceUrl2 = 'https://localhost:44357/api/Cuenta/';
    
   }

   login(obj : Login): Observable<Response>{
     return this.httpClient.post<Response>(this.resourceUrl, obj)
     .pipe(
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


   obtenerDatoCuenta(obj : Cuenta): Observable<Response>{
    return this.httpClient.post<Response>(this.resourceUrl2, obj)
    .pipe(
     map(res => {
       if(res.exito === 1){
         const cuenta: Cuenta = res.data;
         localStorage.setItem('cuenta',JSON.stringify(cuenta));
         this.cuentaSubject.next(cuenta);
       }
       return res;
     })
   )
  }

   logOut(){
     localStorage.removeItem('usuario');
     this.userSubject.next(null);

     localStorage.removeItem('cuenta');
     this.cuentaSubject.next(null);
   }


  
}
