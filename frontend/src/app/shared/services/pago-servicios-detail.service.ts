import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { PagoServicioDetail } from '../models/pago-servicio-detail';

/*const httpOption = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
    'Authorization': 'my-auth-token'
  })
}*/

@Injectable({
  providedIn: 'root'
})
export class PagoServiciosDetailService {

  resourceUrl: string;

  constructor(private httpClient: HttpClient) { 
    this.resourceUrl = 'https://localhost:44357/api/PagoServicio/';
  }

  save(obj: PagoServicioDetail) {
    return this.httpClient.post(this.resourceUrl, obj);
  }

  get() {
    return this.httpClient.get(this.resourceUrl);
  }
}