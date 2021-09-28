import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AuthService } from './auth.service';

@Injectable({
  providedIn: 'root'
})
export class AuthInterceptorsService implements HttpInterceptor{

  constructor(private authService : AuthService) { }

  intercept(request : HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    const usuario = this.authService.usuarioData;

    if(usuario) {
      request = request.clone({
        setHeaders : {
          Authorization : `Bearer ${usuario.token}`
        }
      });
    }
    return next.handle(request);
  }
}
