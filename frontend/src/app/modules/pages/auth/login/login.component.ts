import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormControlDirective, FormGroup, NgForm, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Login } from '@app/shared/models/login';
import { User } from '@app/shared/models/user';
import { AuthService } from '@app/shared/services/auth.service';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  formLogin: FormGroup;



  /*public formLogin = new FormGroup({
    email: new FormControl(''),
    password: new FormControl('')
  });*/

  //formLogin: FormGroup;
  
  
  constructor(
    private formBuilder: FormBuilder, 
    private authService : AuthService,
    private router : Router
    ) {
    this.formLogin = this.formBuilder.group({
      email: ['',[Validators.required, Validators.email]],
      password: ['',[Validators.required, Validators.minLength(6)]]
    })

    if (this.authService.usuarioData){
      this.router.navigate(['/wallet']);
    }
   }

   get correoNoValido(){
    return this.formLogin.get('email').invalid && this.formLogin.get('email').touched;
  }

  get passwordNoValido(){
    return this.formLogin.get('password').invalid && this.formLogin.get('password').touched;
  }

   ngOnInit(): void {
  }

  
  
  guardar(){
    /*console.log(this.mail, this.password);
    this.authService.login(this.mail,this.password).subscribe(data => {
      console.log(data);
    });*/
    const itemCopy:Login = {
      Mail: this.formLogin.get('email')?.value,
      Password: this.formLogin.get('password')?.value,
    }

    console.log(itemCopy);
    this.authService.login(itemCopy).subscribe(data => {
      if(data.exito === 1){
        this.router.navigate(['/wallet']);
      }
      console.log(data);
      alert("Usuario correcto");
    }, error => {
      console.log(error);
      alert("Usuario incorrecto");
      this.formLogin.reset();
    });

 }
 

  
  




}
