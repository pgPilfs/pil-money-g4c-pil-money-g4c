import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { IniciosesionComponent } from './components/iniciosesion/iniciosesion.component';

//Componentes
import { RegistroComponent } from './components/registro/registro.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';

const routes: Routes = [
  { path:"registrarse", component:RegistroComponent },
  { path:"iniciarsesion", component:LoginComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
