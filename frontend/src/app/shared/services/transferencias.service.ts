import { Injectable } from '@angular/core';
import { Transferencia } from '../models/transferencia';
import {
  HttpClient,
  HttpHeaders,
  HttpErrorResponse,
  HttpParams
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Response } from '../models/response';

const httpOption = {
  headers: new HttpHeaders({
    'Contend-Type': 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class TransferenciasService {
  resourceUrl: string;

  constructor(private httpClient: HttpClient) { 
    this.resourceUrl = 'https://localhost:44331/api/Transferencia/';
  }

  post(obj: any): Observable<Transferencia> {
    return this.httpClient.post<Transferencia>(this.resourceUrl, obj, httpOption);
  }
}
