import { Injectable } from "@angular/core";
import { Router, CanActivate, ActivatedRouteSnapshot } from "@angular/router";
import { AuthService } from "@app/shared/services/auth.service";

@Injectable({ providedIn: 'root'})
export class AuthGuard implements CanActivate{
    //simular que no hay sesion
    constructor(private router: Router, private userService: AuthService){

    }
    canActivate(route: ActivatedRouteSnapshot){
        const usuario = this.userService.usuarioData;

        if (usuario){
            return true;
        }
        
        this.router.navigate(['/home']);
        return false;
    }
}