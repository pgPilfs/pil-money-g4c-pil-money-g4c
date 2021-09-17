import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Cotizacion } from '@app/shared/models/cotizacion';
import { Cuenta } from '@app/shared/models/cuenta';
import { CotizacionService } from '@app/shared/services/cotizacion.service';
import { CuentaService } from '@app/shared/services/cuenta.service';

@Component({
  selector: 'app-wallet',
  templateUrl: './wallet.component.html',
  styleUrls: ['./wallet.component.css']
})
export class WalletComponent implements OnInit {
  Datos: Cuenta[] = [];
  Info: Cotizacion[] = [];

  constructor(public formBuilder: FormBuilder,
    private cuentaService: CuentaService,
    private cotizacionService: CotizacionService) { }

  ngOnInit(): void {
    this.GetDatos();
    this.GetCotizacion();
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
    this.cotizacionService.get().subscribe((res:any) => {
      this.Info = res;
      console.log(this.Info);
    },
     error => {
      console.log(error); 
     });
  }
}
