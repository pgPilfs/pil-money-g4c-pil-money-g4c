import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { IngresoMoneyComponent } from './modules/pages/wallet/ingreso-money/ingreso-money.component';
import { InversionComponent } from './modules/pages/wallet/inversion/inversion.component';
import { PayServicesDetailComponent } from './modules/pages/wallet/pay-services-detail/pay-services-detail.component';
import { PayServicesComponent } from './modules/pages/wallet/pay-services/pay-services.component';
import { TransferComponent } from './modules/pages/wallet/transfer/transfer.component';
import { WalletComponent } from './modules/pages/wallet/wallet.component';
import { AuthGuard } from './security/auth.guard';

const routes: Routes = [
  {path: '', redirectTo: 'home', pathMatch: 'full'},
  { path: 'home', loadChildren: () => import('./modules/pages/home/home.module').then(m => m.HomeModule)}, 
  { path: 'register', loadChildren: () => import('./modules/pages/auth/register/register.module').then(m => m.RegisterModule)},
{ path: 'contact', loadChildren: () => import('./modules/pages/contact/contact.module').then(m => m.ContactModule)}, 
 { path: 'login', loadChildren: () => import('./modules/pages/auth/login/login.module').then(m => m.LoginModule) },
 { path: 'wallet', component: WalletComponent, canActivate:[AuthGuard], loadChildren: () => import('./modules/pages/wallet/wallet.module').then(m => m.WalletModule)},
 { path: 'faq', loadChildren: () => import('./modules/pages/faq/faq.module').then(m => m.FaqModule)},
 { path: 'transfer', component: TransferComponent, canActivate:[AuthGuard], loadChildren: () => import('./modules/pages/wallet/transfer/transfer.module').then(m => m.TransferModule)},
 { path: 'ingreso-money', component: IngresoMoneyComponent, canActivate:[AuthGuard], loadChildren: () => import('./modules/pages/wallet/ingreso-money/ingreso-money.module').then(m => m.IngresoMoneyModule)},
 { path: 'pay-services', component: PayServicesComponent, canActivate:[AuthGuard], loadChildren: () => import('./modules/pages/wallet/pay-services/pay-services.module').then(m => m.PayServicesModule)},
 { path: 'inversion', component: InversionComponent, canActivate:[AuthGuard], loadChildren: () => import('./modules/pages/wallet/inversion/inversion.module').then(m => m.InversionModule)},
 { path: 'pay-services-detail', component: PayServicesDetailComponent, canActivate:[AuthGuard], loadChildren: () => import('./modules/pages/wallet/pay-services-detail/pay-services-detail.module').then(m => m.PayServicesDetailModule)},
 { path: '**', loadChildren: () => import('./modules/pages/not-found/not-found.module').then(m => m.NotFoundModule)}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
