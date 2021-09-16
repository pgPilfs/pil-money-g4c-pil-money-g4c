import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Cuenta } from '@app/shared/models/cuenta';
import { CuentaService } from '@app/shared/services/cuenta.service';

@Component({
  selector: 'app-wallet',
  templateUrl: './wallet.component.html',
  styleUrls: ['./wallet.component.css']
})
export class WalletComponent implements OnInit {
  Datos: Cuenta[] = [];
  cvu = "222222";
  saldoActual = 12.4;

  constructor(public formBuilder: FormBuilder,
    private cuentaService: CuentaService) { }

  ngOnInit(): void {
    this.GetDatos();
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
}

