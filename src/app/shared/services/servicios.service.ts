import { Injectable } from '@angular/core';
import { of } from "rxjs";
import { Services } from "../models/service";

@Injectable({
  providedIn: 'root'
})
export class ServiciosService {
  constructor() {}
  get() {
    return of(Services);
  }
  
}

