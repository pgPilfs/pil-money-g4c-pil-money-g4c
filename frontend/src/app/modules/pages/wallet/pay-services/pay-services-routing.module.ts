import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PayServicesComponent } from './pay-services.component';

const routes: Routes = [{ path: '', component: PayServicesComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PayServicesRoutingModule { }