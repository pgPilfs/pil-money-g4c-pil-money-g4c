import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Cotizacion } from '../models/cotizacion';

@Injectable({
  providedIn: 'root'
})
export class CotizacionService {
  resourceUrl: string;
  constructor(private httpClient: HttpClient) { 
    this.resourceUrl = '/api/dolaroficial';
  }

  get():Observable<any>{
    return this.httpClient.get<any>(this.resourceUrl);
  }
}

