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
  private users:User[];
  private users$: Subject<User[]>;

  constructor() {
    this.users = [];
    this.users$ = new Subject();
   }

   addUser(user: User){
     this.users.push(user);
     this.users$.next(this.users);

   }

   getUsers$():Observable<User[]>{
     return this.users$.asObservable();
   }
  
}
