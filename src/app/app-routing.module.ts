import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ComppagservicioComponent } from './components/comppagservicio/comppagservicio.component';
import { DescpagservicioComponent } from './components/descpagservicio/descpagservicio.component';
import { IniciosesionComponent } from './components/iniciosesion/iniciosesion.component';
import { PagservicioComponent } from './components/pagservicio/pagservicio.component';

//Componentes
import { RegistroComponent } from './components/registro/registro.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';

const routes: Routes = [
  { path:"registrarse", component:RegisterComponent },
  { path:"iniciarsesion", component:LoginComponent },
  { path:"servicios", component:PagservicioComponent },
  { path:"servicios/iddelservicio", component:DescpagservicioComponent },
  { path:"servicios/iddelservicio/comprobante", component:ComppagservicioComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
