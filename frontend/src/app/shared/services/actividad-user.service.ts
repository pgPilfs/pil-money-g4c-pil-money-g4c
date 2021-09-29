import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ActividadUserService {

  resourceUrl: string;

  constructor(private httpClient: HttpClient) {
    this.resourceUrl = 'https://localhost:44357/api/Actividad/';
    }

    getAct(): Observable<any> {
      return this.httpClient.get<any>(this.resourceUrl);
    }
}
