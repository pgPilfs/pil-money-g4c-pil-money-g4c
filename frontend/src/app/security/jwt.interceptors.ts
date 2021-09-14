import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { AuthService } from "@app/shared/services/auth.service";
import { Observable } from "rxjs";

@Injectable()

export class JwtInterceptor implements HttpInterceptor{
    constructor(private userService: AuthService){

    }

    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>>{
        const usuario = this.userService.usuarioData;

        if (usuario){
            request = request.clone({
                setHeaders: {
                    Authorization: `Bearer ${usuario.token} `
                }
            });

        }
        return next.handle(request);
    }
}