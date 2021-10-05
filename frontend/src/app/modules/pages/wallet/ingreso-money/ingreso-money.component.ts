import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Cuenta } from '@app/shared/models/cuenta';
import { IngresoMoney } from '@app/shared/models/ingreso-money';
import { CuentaService } from '@app/shared/services/cuenta.service';
import { IngresoMoneyService } from '@app/shared/services/ingreso-money.service';

@Component({
  selector: 'app-ingreso-money',
  templateUrl: './ingreso-money.component.html',
  styleUrls: ['./ingreso-money.component.css']
})
export class IngresoMoneyComponent implements OnInit {
  formIngresoMoney: FormGroup;

  Datos: Cuenta[] = [];
  IngresosDinero: IngresoMoney[] = null;

  mostrarDatosCuenta: boolean = false;
  mostrarDatosTarjeta: boolean = false;

  constructor(
    private formBuilder: FormBuilder,
    private ingresoMoneyService: IngresoMoneyService,
    private cuentaService: CuentaService
  ) {
    this.formIngresoMoney = this.formBuilder.group({
      cvu_deposito: "236598752013654875",
      nro_tarjeta: ['',[Validators.required, Validators.minLength(16), Validators.maxLength(16)]],
      fecha_venc: ['',[Validators.required, Validators.minLength(5), Validators.maxLength(5)]],
      cod_seguridad: ['',[Validators.required, Validators.minLength(3), Validators.maxLength(3)]],
      nombre_titular: ['',[Validators.required]],
      monto: ['',[Validators.required]]
      })


    this.GetDatos(); 
    
  }

  

  get nroTarjetaNoValido(){
    return this.formIngresoMoney.get('nro_tarjeta').invalid && this.formIngresoMoney.get('nro_tarjeta').touched;
  }

   get fechaVencNoValida(){
    return this.formIngresoMoney.get('fecha_venc').invalid && this.formIngresoMoney.get('fecha_venc').touched;
  }

  get codSeguridadNoValido(){
    return this.formIngresoMoney.get('cod_seguridad').invalid && this.formIngresoMoney.get('cod_seguridad').touched;
  }

  get nombreNoValido(){
    return this.formIngresoMoney.get('nombre_titular').invalid && this.formIngresoMoney.get('nombre_titular').touched;
  }

  get montoNoValido(){
    return this.formIngresoMoney.get('monto').invalid && this.formIngresoMoney.get('monto').touched;
  }


  ngOnInit(): void {
    this.GetHistorialIngresos();
  }

  touchButtonTransferencia(){
    this.mostrarDatosCuenta =! this.mostrarDatosCuenta;
  }

  touchButtonTarjeta(){
    this.mostrarDatosTarjeta =! this.mostrarDatosTarjeta;
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

  

  GetDatos() {
    this.cuentaService.get().subscribe((res: Cuenta[]) => {
      this.Datos = res;
      console.log(this.Datos);
    },
     error => {
      console.log(error); 
     });
  }


  PostIngreso() {
    const fecha_final: string = this.formIngresoMoney.get('fecha_venc')?.value[0][1]  + "30/";
    console.log(fecha_final);
    const itemCopy:IngresoMoney = {      
      CvuDeposito: this.formIngresoMoney.get('cvu_deposito')?.value,
      NroTarjeta: this.formIngresoMoney.get('nro_tarjeta')?.value,
      FechaVenc: this.formIngresoMoney.get('fecha_venc')?.value,
      CodSeguridad: this.formIngresoMoney.get('cod_seguridad')?.value,
      NombreTitular: this.formIngresoMoney.get('nombre_titular')?.value,
      Monto: this.formIngresoMoney.get('monto')?.value,
    }

    console.log(itemCopy);
    this.ingresoMoneyService.ingresar(itemCopy).subscribe(data => {
      alert("Se realizo la operación. En unos minutos verás reflejado el saldo en tu cuenta...");
      this.formIngresoMoney.reset();
      console.log(data);
    }, error => {
      alert("La tarjeta está vencida o no tiene saldo suficiente. Revise los datos de la tarjeta");
      console.log(error);
    });

  
  }
}
