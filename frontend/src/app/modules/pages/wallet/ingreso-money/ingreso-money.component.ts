import { Component, OnInit } from '@angular/core';
import { Cuenta } from '@app/shared/models/cuenta';
import { CuentaService } from '@app/shared/services/cuenta.service';
import { IngresosService } from '@app/shared/services/ingresos.service';

@Component({
  selector: 'app-ingreso-money',
  templateUrl: './ingreso-money.component.html',
  styleUrls: ['./ingreso-money.component.css']
})
export class IngresoMoneyComponent implements OnInit {

  Datos: Cuenta[] = [];

  mostrarDatosCuenta: boolean = false;
  mostrarDatosTarjeta: boolean = false;
  //lo que quiero que se muestre
  ingreso = {
    id_deposito: 5,
    nombre_deposito: 'deposito',
    CVU_deposito: '2262954820126236189574',
    nro_tarjeta: ' ',
    fecha_venc: ' ',
    cod_seguridad: ' ',
    nombre_titular: ' '
  };
  mensaje_enlace: string = 'mostrar';

  

  constructor(
    private ingresosService: IngresosService,
    private cuentaService: CuentaService
  ) {
    this.GetDatos(); 
    
  }

  ngOnInit(): void {
  }

  touchButtonTransferencia(){
    this.mostrarDatosCuenta =! this.mostrarDatosCuenta;
  }

  touchButtonTarjeta(){
    this.mostrarDatosTarjeta =! this.mostrarDatosTarjeta;
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

  saveIngreso(): void {
    const data: any = {
      id_deposito: this.ingreso.id_deposito,
      nombre_deposito: this.ingreso.nombre_deposito,
      CVU_deposito: this.ingreso.CVU_deposito,
      nro_tarjeta: this.ingreso.nro_tarjeta,
      fecha_venc: this.ingreso.fecha_venc,
      cod_seguridad: this.ingreso.cod_seguridad,
      nombre_titular: this.ingreso.nombre_titular,

    };

    this.ingresosService.post(data)
      .subscribe(
        response => {
          console.log(response);
        },
        error => console.log(error)
      );
      }

   
}