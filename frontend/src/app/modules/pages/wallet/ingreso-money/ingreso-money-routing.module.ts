import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { IngresoMoneyComponent } from './ingreso-money.component';

const routes: Routes = [{ path: '', component: IngresoMoneyComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class IngresoMoneyRoutingModule { }