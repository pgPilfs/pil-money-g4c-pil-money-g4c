import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NewUser } from '@app/shared/models/new-user';
import { UserService } from '@app/shared/services/user.service';

@Component({
  selector: 'app-modified-user',
  templateUrl: './modified-user.component.html',
  styleUrls: ['./modified-user.component.css']
})
export class ModifiedUserComponent implements OnInit {
  mostrarDatosUser: boolean = false;

  formModif: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private userService: UserService) 
    { 
      this.formModif = this.formBuilder.group({
        correo: ['',[Validators.email]],
        password: ['',[Validators.minLength(6)]]
        })            
    }

  
  get correoNoValido(){
    return this.formModif.get('correo').invalid && this.formModif.get('correo').touched;
 }
  
  get passwordNoValido(){
    return this.formModif.get('password').invalid && this.formModif.get('password').touched;
  }

  ngOnInit(): void {
  }

  touchButtonModificar(){
    this.mostrarDatosUser =! this.mostrarDatosUser;
  }



  ModificarUsuario() {
  
    const itemCopy:NewUser = {
      Mail: this.formModif.get('correo').value,
      Password: this.formModif.get('password').value
    }
    console.log(itemCopy);

    this.userService.edit(itemCopy).subscribe(data => {
      console.log(data);
      alert("Se modifico tu usuario con exito...");
      this.formModif.reset();
    }, error => {
      console.log(error);
    });
  };  


}







