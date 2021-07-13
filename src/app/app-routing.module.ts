import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path: '', redirectTo: 'home', pathMatch: 'full'},
  { path: 'home', loadChildren: () => import('./modules/pages/home/home.module').then(m => m.HomeModule) }, 
{ path: 'contact', loadChildren: () => import('./modules/pages/contact/contact.module').then(m => m.ContactModule) }, 
{ path: 'register', loadChildren: () => import('./modules/pages/auth/register/register.module').then(m => m.RegisterModule) },
 { path: 'login', loadChildren: () => import('./modules/pages/auth/login/login.module').then(m => m.LoginModule) },
 { path: 'wallet', loadChildren: () => import('./modules/pages/wallet/wallet.module').then(m => m.WalletModule) },
 { path: '**', loadChildren: () => import('./modules/pages/not-found/not-found.module').then(m => m.NotFoundModule) }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
