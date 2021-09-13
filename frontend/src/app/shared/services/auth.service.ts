import { ThrowStmt } from '@angular/compiler';
import { Injectable } from '@angular/core';
import { tick } from '@angular/core/testing';
import { Observable, of, Subject } from "rxjs";
import { User } from "../models/user";
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})

export class AuthService {
  url: string = 'https://localhost:44331/api/Usuario/login';

  

  constructor(private http:HttpClient) {
    
   }

   //login(email:string, password: string): Observable<>{
   //  
   //}
}
