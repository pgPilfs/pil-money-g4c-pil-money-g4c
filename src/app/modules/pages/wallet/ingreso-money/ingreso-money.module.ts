import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { IngresoMoneyRoutingModule } from './ingreso-money-routing.module';
import { IngresoMoneyComponent } from './ingreso-money.component';

@NgModule({
  declarations: [IngresoMoneyComponent],
  imports: [
    CommonModule,
    IngresoMoneyRoutingModule
  ]
})
export class IngresoMoneyModule { }