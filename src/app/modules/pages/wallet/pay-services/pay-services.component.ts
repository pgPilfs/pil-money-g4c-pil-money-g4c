import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Service } from '@app/shared/models/service';
import { ServiciosService } from '@app/shared/services/servicios.service';


@Component({
  selector: 'app-pay-services',
  templateUrl: './pay-services.component.html',
  styleUrls: ['./pay-services.component.css']
})
export class PayServicesComponent implements OnInit {
  Titulo = "Servicios";
  RegistrosTotal: number;
  Items: Service[] = [];

  FormBusqueda: FormGroup;

  constructor(
    public formBuilder: FormBuilder,
    private serviciosAPagarService: ServiciosService
  ) //private articulosFamiliasService:  MockArticulosFamiliasService
  {}

  ngOnInit() {
    this.FormBusqueda = this.formBuilder.group({
      nombreServicio: ['']
    })

    this.GetServicios();
  }

  GetServicios() {
    this.serviciosAPagarService.get().subscribe((res: Service[]) => {
      this.Items = res;
    });
  }

  Buscar() {
    this.serviciosAPagarService
      .get(
      )
      .subscribe((res: any) => {
        this.Items = res.Items;
        this.RegistrosTotal = res.RegistrosTotal;
      });
    }
 

}


