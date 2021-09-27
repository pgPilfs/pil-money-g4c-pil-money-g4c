import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Inversion } from '../models/inversion';

/*const httpOption = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
    'Authorization': 'my-auth-token'
  })
}*/

@Injectable({
  providedIn: 'root'
})
export class InversionService {

 resourceUrl: string;

  constructor(private httpClient: HttpClient) { 
    this.resourceUrl = 'https://localhost:44357/api/Inversion/';
  }

  save(obj: Inversion)  {
    return this.httpClient.post(this.resourceUrl, obj);
  }

  get() {
    return this.httpClient.get(this.resourceUrl);
  }
}
