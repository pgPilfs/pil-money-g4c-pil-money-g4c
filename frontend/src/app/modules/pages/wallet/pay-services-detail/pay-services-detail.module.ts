import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PayServicesDetailRoutingModule } from './pay-services-detail-routing.module';
import { PayServicesDetailComponent } from './pay-services-detail.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [PayServicesDetailComponent],
  imports: [
    CommonModule,
    PayServicesDetailRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class PayServicesDetailModule { }




