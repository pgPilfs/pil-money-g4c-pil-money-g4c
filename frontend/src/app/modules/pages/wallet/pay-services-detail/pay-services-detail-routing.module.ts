import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PayServicesDetailComponent } from './pay-services-detail.component';

const routes: Routes = [{ path: '', component: PayServicesDetailComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PayServicesDetailRoutingModule { }
