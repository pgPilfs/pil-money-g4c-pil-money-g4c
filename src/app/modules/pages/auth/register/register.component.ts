import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, NgForm, Validators } from '@angular/forms';



@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {


  formRegister: FormGroup;

  constructor(private formBuilder: FormBuilder) {
    this.crearForm();
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

  crearForm(){
    this.formRegister = this.formBuilder.group({
      nombre: ['',[Validators.required]],
      apellido: ['',[Validators.required]],
      dni: ['',[Validators.required, Validators.maxLength(8)]],
      foto: ['',[Validators.required, Validators.requiredTrue]],
      email: ['',[Validators.required, Validators.email]],
      password: ['',[Validators.required, Validators.minLength(6)]]
    });
  }


  guardar(){
    console.log(this.formRegister);

    if(this.formRegister.invalid){
      return Object.values(this.formRegister.controls).forEach(control => {control.markAsTouched();
      });
    }
  }





}
