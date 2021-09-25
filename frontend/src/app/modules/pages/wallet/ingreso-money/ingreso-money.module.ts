import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { IngresoMoneyRoutingModule } from './ingreso-money-routing.module';
import { IngresoMoneyComponent } from './ingreso-money.component';

import { FormGroup, FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [IngresoMoneyComponent],
  imports: [
    CommonModule,
    IngresoMoneyRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class IngresoMoneyModule { }