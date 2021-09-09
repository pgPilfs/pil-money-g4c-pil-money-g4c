import { Injectable } from '@angular/core';
import { Transferencia } from '../models/transferencia';
import {
  HttpClient,
  HttpHeaders,
  HttpErrorResponse,
  HttpParams
} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TransferenciasService {
  resourceUrl: string;

  constructor(private httpClient: HttpClient) { 
    this.resourceUrl = 'https://localhost:44366/api/Transferencia/';
  }

  post(obj: any): Observable<any> {
    return this.httpClient.post(this.resourceUrl, obj);
  }
}
