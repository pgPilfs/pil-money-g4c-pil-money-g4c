import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IngresoMoney } from '../models/ingreso-money';

@Injectable({
  providedIn: 'root'
})
export class IngresoMoneyService {
  resourceUrl: string;

  constructor(private httpClient: HttpClient) { 
    this.resourceUrl = 'https://localhost:44357/api/IngresoDinero/';
  }

  ingresar(obj: IngresoMoney) {
    return this.httpClient.post(this.resourceUrl, obj);
  }
}

