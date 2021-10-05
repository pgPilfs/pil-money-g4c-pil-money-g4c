import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RetiroDineroRoutingModule } from './retiro-dinero-routing.module';
import { RetiroDineroComponent } from './retiro-dinero.component';


@NgModule({
  declarations: [RetiroDineroComponent],
  imports: [
    CommonModule,
    RetiroDineroRoutingModule
  ]
})
export class RetiroDineroModule { }
