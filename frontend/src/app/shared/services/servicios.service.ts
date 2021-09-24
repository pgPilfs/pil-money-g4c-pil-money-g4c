import { Injectable } from '@angular/core';
import { of } from "rxjs";
import { Service } from "../models/service";
import { Observable } from 'rxjs';
import {
  HttpClient,
  HttpHeaders,
  HttpErrorResponse,
  HttpParams
} from '@angular/common/http';



@Injectable({
  providedIn: 'root'
})

export class ServiciosService {
  //constructor() {}
  //get() {
  //  return of(Services);
  //}
  resourceUrl: string;
  constructor(private httpClient: HttpClient) {
    this.resourceUrl = 'https://localhost:44357/api/Servicios/';
    }

    get() {
      return this.httpClient.get(this.resourceUrl);
    }
    //getListServicios(): Observable<any>{
    //  return this.httpClient.get(this.resourceUrl);
    //this.resourceUrl =  "https://localhost:44352/api/Servicios" + "/";
    //this.resourceUrl =  "https://localhost:44328/api/articulosfamilias" + "/";
  }


  //get(id_servicio: number): Observable<any> {
  //  return this.http.get(`${baseUrl}/${id_servicio}`);
  //}
//
  //create(data: any): Observable<any> {
  //  return this.http.post(baseUrl, data);
  //}
//
  //update(id_servicio: number, nombreServicio: any): Observable<any> {
  //  return this.http.put(`${baseUrl}/${id_servicio}`, nombreServicio);
  //}
//
  //delete(id_servicio: number): Observable<any> {
  //  return this.http.delete(`${baseUrl}/${id_servicio}`);
  //}
//
  //deleteAll(): Observable<any> {
  //  return this.http.delete(baseUrl);
  //}
//
  //findByTitle(title: string): Observable<any> {
  //  return this.http.get(`${baseUrl}?title=${title}`);
  //}




