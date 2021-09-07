import { Component, OnInit } from '@angular/core';
import { IngresosService } from '@app/shared/services/ingresos.service';

@Component({
  selector: 'app-ingreso-money',
  templateUrl: './ingreso-money.component.html',
  styleUrls: ['./ingreso-money.component.css']
})
export class IngresoMoneyComponent implements OnInit {

  ingreso = {
    id_deposito: 5,
    nombre_deposito: 'deposito',
    CVU_deposito: '2262954820126236189574',
    nro_tarjeta: ' ',
    fecha_venc: ' ',
    cod_seguridad: ' ',
    nombre_titular: ' '
  };

  

  constructor(
    private ingresosService: IngresosService
  ) { 
    
  }

  ngOnInit(): void {
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

      //GetServicios() {
      //  this.serviciosAPagarService.get().subscribe((res: Service[]) => {
      //    this.Items = res;
      //  });

  //PostTransferencia() {
  //  //const itemCopy = { ...this.formTransfer.value };
  //  this.transferenciaService.post(this.formTransfer.value).subscribe((res: any) => {
  //  alert('Ingreso de dinero realizado. En unos minutos lo verás reflejado en tu cuenta'); 
}