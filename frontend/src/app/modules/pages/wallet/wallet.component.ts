import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { Cotizacion } from '@app/shared/models/cotizacion';
import { Cuenta } from '@app/shared/models/cuenta';
import { IngresoMoney } from '@app/shared/models/ingreso-money';
import { Inversion } from '@app/shared/models/inversion';
import { PagoServicioDetail } from '@app/shared/models/pago-servicio-detail';
import { Transferencia } from '@app/shared/models/transferencia';
import { User } from '@app/shared/models/user';
import { AuthService } from '@app/shared/services/auth.service';
import { CotizacionService } from '@app/shared/services/cotizacion.service';
import { CuentaService } from '@app/shared/services/cuenta.service';
import { IngresoMoneyService } from '@app/shared/services/ingreso-money.service';
import { InversionService } from '@app/shared/services/inversion.service';
import { PagoServiciosDetailService } from '@app/shared/services/pago-servicios-detail.service';
import { TransferenciasService } from '@app/shared/services/transferencias.service';
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
  HistorialInversion: Inversion[] = null;
  HistorialTransfer: Transferencia[] = null;
  Historial: PagoServicioDetail[] = null;
  IngresosDinero: IngresoMoney[] = null;

  usuario: User;


  constructor(public formBuilder: FormBuilder,
    private cuentaService: CuentaService,
    private cotizacionService: CotizacionService,
    private userService: UserService,
    private transferenciaService: TransferenciasService,
    private inversionService: InversionService,
    private historialServiciosPagos: PagoServiciosDetailService,
    private ingresoMoneyService: IngresoMoneyService,
    public authService: AuthService,
    public router: Router) {
      this.authService.usuario.subscribe(res => {
        this.usuario = res;
        console.log('Cambio el objeto: ' + res);
      });
     }

  ngOnInit(): void {

    this.GetDatos();
    this.GetCotizacion();
    this.GetUser();

    this.GetHistorialInv();
    this.GetHistorialPagos();
    this.GetHistorialTransfer();
    this.GetHistorialIngresos();
    
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
      console.log(this.DatoUserLog);
    },
     error => {
      console.log(error); 
     });
  }

  GetHistorialTransfer() {
    this.transferenciaService.get().subscribe((res: Transferencia[]) => {
      this.HistorialTransfer = res;
      console.log(this.HistorialTransfer);
    },
     error => {
      console.log(error); 
     });
  }

  GetHistorialInv() {
    this.inversionService.get().subscribe((res: Inversion[]) => {
      this.HistorialInversion = res;
      console.log(this.HistorialInversion);
    },
     error => {
      console.log(error); 
     });
  }


  GetHistorialIngresos() {
    this.ingresoMoneyService.get().subscribe((res: IngresoMoney[]) => {
      this.IngresosDinero = res;
      console.log(this.IngresosDinero);
    },
     error => {
      console.log(error); 
     });
  }

  GetHistorialPagos() {
    this.historialServiciosPagos.get().subscribe((res: PagoServicioDetail[]) => {
      this.Historial = res;
      console.log(this.Historial);
    },
     error => {
      console.log(error); 
     });
  }


  logout() {
    this.authService.logOut();
    this.router.navigate(['/home']);
  }




  
}
