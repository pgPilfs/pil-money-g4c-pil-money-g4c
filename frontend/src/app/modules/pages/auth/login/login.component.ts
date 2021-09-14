import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormControlDirective, FormGroup, NgForm, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '@app/shared/services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  public formLogin = this.formBuilder.group({
    email: ['',[Validators.required, Validators.email]],
    password: ['',[Validators.required, Validators.minLength(6)]]
  })

  /*public formLogin = new FormGroup({
    email: new FormControl(''),
    password: new FormControl('')
  });*/

  //formLogin: FormGroup;

  constructor(private formBuilder: FormBuilder, private authService: AuthService, private router: Router) {
    //this.crearForm();
    if (this.authService.usuarioData){
      this.router.navigate(['/wallet']);
    }
   }

   ngOnInit(): void {
  }

  //get correoNoValido(){
  //  return this.formLogin.get('email').invalid && this.formLogin.get('email').touched;
  //}
//
  //get passwordNoValido(){
  //  return this.formLogin.get('password').invalid && this.formLogin.get('password').touched;
  //}
//
  //crearForm(){
  //  this.formLogin = this.formBuilder.group({
  //    email: ['',[Validators.required, Validators.email]],
  //    password: ['',[Validators.required, Validators.minLength(6)]]
  //  });
  //}


  //guardar(){
    //console.log(this.formLogin);

    //if(this.formLogin.invalid){
    //  return Object.values(this.formLogin.controls).forEach(control => {control.markAsTouched();
    //    this.usersService.addUser(this.formLogin.value);
    //  });
    //}
 // }

  login(){
    this.authService.login(this.formLogin.value).subscribe(response => {
      if (response.exito === 1){
        this.router.navigate(['/']);
      };  
    });
  }



}
