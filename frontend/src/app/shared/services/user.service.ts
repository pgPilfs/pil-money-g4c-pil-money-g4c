import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { NewUser } from '../models/new-user';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  resourceUrl: string;

  constructor(private httpClient: HttpClient) { 
    this.resourceUrl = 'https://localhost:44357/api/Usuario/';
  }

  obtenerUser() {
    return this.httpClient.get<any>(this.resourceUrl);
  }

  edit(obj: NewUser) {
    return this.httpClient.put(this.resourceUrl, obj);
  }
}