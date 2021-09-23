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

/*const httpOption = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
    'Authorization': 'my-auth-token'
  })
}*/

@Injectable({
  providedIn: 'root'
})
export class TransferenciasService {
  resourceUrl: string;

  constructor(private httpClient: HttpClient) { 
    this.resourceUrl = 'https://localhost:44357/api/Transferencia';
  }

  save(obj: Transferencia){
    return this.httpClient.post(this.resourceUrl, obj);
  }
}
