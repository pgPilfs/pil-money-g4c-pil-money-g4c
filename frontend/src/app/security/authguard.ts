import { Injectable } from "@angular/core";
import { ActivatedRouteSnapshot, CanActivate, Router } from "@angular/router";

@Injectable({providedIn: 'root'})

export class Authguard implements CanActivate {
    
    constructor(private router : Router ){

    }
    
    canActivate(route: ActivatedRouteSnapshot ){
        this.router.navigate(['/login']);
        return false;
        
    }
}
