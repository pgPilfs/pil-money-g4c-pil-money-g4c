import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { PagoServicioDetail } from '@app/shared/models/pago-servicio-detail';
import { Service } from '@app/shared/models/service';
import { PagoServiciosDetailService } from '@app/shared/services/pago-servicios-detail.service';
import { ServiciosService } from '@app/shared/services/servicios.service';


@Component({
  selector: 'app-pay-services',
  templateUrl: './pay-services.component.html',
  styleUrls: ['./pay-services.component.css']
})
export class PayServicesComponent implements OnInit {

  Items: Service[] = null;
  Historial: PagoServicioDetail[] = null;

  FormBusqueda: FormGroup;

  mostrarTodo: boolean = false;

  constructor(
    public formBuilder: FormBuilder,
    private serviciosAPagarService: ServiciosService,
    private historialServiciosPagos: PagoServiciosDetailService
  ) 
  {}

  ngOnInit() {
    this.FormBusqueda = this.formBuilder.group({
      Nombre: ['']
    })

    this.GetServicios();
    this.GetHistorialPagos();
  }

  touchButtonVerTodo(){
    this.mostrarTodo =! this.mostrarTodo;
  }

  GetServicios() {
    this.serviciosAPagarService.get().subscribe((res: Service[]) => {
      this.Items = res;
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

  Buscar() {
    this.serviciosAPagarService
      .get(
      )
      .subscribe((res: any) => {
        this.Items = res.Items;
      });
    }
 

}


