import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import { AuthService } from '@app/shared/services/auth.service';



@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {


  formRegister: FormGroup;

  constructor(private formBuilder: FormBuilder) {
    this.formRegister = this.formBuilder.group({
      nombre: ['',[Validators.required]],
      apellido: ['',[Validators.required]],
      dni: ['',[Validators.required, Validators.maxLength(8)]],
      foto: ['',[Validators.required, Validators.requiredTrue]],
      email: ['',[Validators.required, Validators.email]],
      password: ['',[Validators.required, Validators.minLength(6)]]
    });

   }

   ngOnInit(): void {
  }

  get correoNoValido(){
    return this.formRegister.get('email').invalid && this.formRegister.get('email').touched;
  }

  get dniNoValido(){
    return this.formRegister.get('dni').invalid && this.formRegister.get('dni').touched;
  }

  get fotoNoCargada(){
    return this.formRegister.get('fotodni').invalid && this.formRegister.get('fotodni').touched;
  }

  get passwordNoValido(){
    return this.formRegister.get('password').invalid && this.formRegister.get('password').touched;
  }




  guardar(){
    console.log(this.formRegister);

    if(this.formRegister.invalid){
      return Object.values(this.formRegister.controls).forEach(control => {control.markAsTouched();
      });
    }
    else{
      //const itemCopy: RegistroUsuario = {

      }
    }
  }

  /*PostIngreso() {
    const itemCopy:IngresoMoney = {      
      Nombre: this.formIngresoMoney.get('cvu_deposito')?.value,
      Apellido: this.formIngresoMoney.get('nro_tarjeta')?.value,
      Dni: this.formIngresoMoney.get('fecha_venc')?.value,
      FotoFrente: this.formIngresoMoney.get('cod_seguridad')?.value,
      FotoDorso: this.formIngresoMoney.get('nombre_titular')?.value,
      Mail: this.formIngresoMoney.get('monto')?.value,
      Password: 
    }

    console.log(itemCopy);
    this.ingresoMoneyService.ingresar(itemCopy).subscribe(data => {
      alert("Se realizo la operación. En unos minutos verás reflejado el saldo en tu cuenta...");
      this.formIngresoMoney.reset();
      console.log(data);
    }, error => {
      console.log(error);
    });

  
  }
*/