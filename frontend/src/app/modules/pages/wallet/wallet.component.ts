import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Cotizacion } from '@app/shared/models/cotizacion';
import { Cuenta } from '@app/shared/models/cuenta';
import { User } from '@app/shared/models/user';
import { CotizacionService } from '@app/shared/services/cotizacion.service';
import { CuentaService } from '@app/shared/services/cuenta.service';
import { UserService } from '@app/shared/services/user.service';

@Component({
  selector: 'app-wallet',
  templateUrl: './wallet.component.html',
  styleUrls: ['./wallet.component.css']
})
export class WalletComponent implements OnInit {
  Datos: Cuenta[] = [];
  Info: any = [];
  DatoUserLog: User[] = [];

  constructor(public formBuilder: FormBuilder,
    private cuentaService: CuentaService,
    private cotizacionService: CotizacionService,
    private userService: UserService) { }

  ngOnInit(): void {
    this.GetDatos();
    this.GetCotizacion();
    this.GetUser();
  }

  

  GetDatos() {
    this.cuentaService.get().subscribe((res: Cuenta[]) => {
      this.Datos = res;
      console.log(this.Datos);
    },
     error => {
      console.log(error); 
     });
  }

  GetCotizacion() {
    this.cotizacionService.get().subscribe((res ) => {
      this.Info = res;
      console.log(this.Info);
    },
     error => {
      console.log(error); 
     });
  }

  GetUser() {
    this.userService.obtenerUser().subscribe((res: User[]) => {
      this.DatoUserLog = res;
      console.log(this.Datos);
    },
     error => {
      console.log(error); 
     });
  }
}
