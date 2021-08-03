import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PayServicesRoutingModule } from './pay-services-routing.module';
import { PayServicesComponent } from './pay-services.component';

import { FormsModule,ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [PayServicesComponent],
  imports: [
    CommonModule,
    PayServicesRoutingModule,
    ReactiveFormsModule,
    FormsModule
  ]
})
export class PayServicesModule { }
