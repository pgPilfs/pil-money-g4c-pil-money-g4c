import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import { Register } from '@app/shared/models/register';
import { AuthService } from '@app/shared/services/auth.service';
import { RegisterService } from '@app/shared/services/register.service';



@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {


  formRegister: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private registerService: RegisterService
    ) {
    this.formRegister = this.formBuilder.group({
      nombre: ['',[Validators.required]],
      apellido: ['',[Validators.required]],
      dni: ['',[Validators.required, Validators.maxLength(8)]],
      fotofrente: [''],
      fotodorso: [''],
      email: ['',[Validators.required, Validators.email]],
      password: ['',[Validators.required, Validators.minLength(6)]]
    });
   }

   

   get nombreNoValido(){
    return this.formRegister.get('nombre').invalid && this.formRegister.get('nombre').touched;
  }

  get apellidoNoValido(){
    return this.formRegister.get('apellido').invalid && this.formRegister.get('apellido').touched;
  }

  get correoNoValido(){
    return this.formRegister.get('email').invalid && this.formRegister.get('email').touched;
  }

  get dniNoValido(){
    return this.formRegister.get('dni').invalid && this.formRegister.get('dni').touched;
  }

  /*get fotoNoCargada(){
    return this.formRegister.get('foto').invalid && this.formRegister.get('foto').touched;
  }*/

  get passwordNoValido(){
    return this.formRegister.get('password').invalid && this.formRegister.get('password').touched;
  }


   ngOnInit(): void {
  }
  


  PostRegistro() {
    console.log(this.formRegister);
    const itemCopy:Register = {      
      Nombre: this.formRegister.get('nombre')?.value,
      Apellido: this.formRegister.get('apellido')?.value,
      Dni: this.formRegister.get('dni')?.value,
      FotoDniFrente: this.formRegister.get('fotofrente')?.value,
      FotoDniDorso: this.formRegister.get('fotodorso')?.value,
      Mail: this.formRegister.get('email')?.value,
      Password: this.formRegister.get('password')?.value
    }

    console.log(itemCopy);
    this.registerService.save(itemCopy).subscribe(data => {
      alert("Tu cuenta se creó exitosamente. Vamos a evaluar tu perfil y en breve tendrás disponible tu cuenta");
      this.formRegister.reset();
      console.log(data);
    }, error => {
      console.log(error);
    });

  
  }
}
