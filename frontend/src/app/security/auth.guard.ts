import { Injectable } from "@angular/core";
import { Router, CanActivate, ActivatedRouteSnapshot } from "@angular/router";

@Injectable({ providedIn: 'root'})
export class AuthGuard implements CanActivate{
    //simular que no hay sesion
    constructor(private router: Router){

    }
    canActivate(route: ActivatedRouteSnapshot){
        this.router.navigate(['/home']);
        return false;
    }
}