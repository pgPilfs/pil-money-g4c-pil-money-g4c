import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { OpinionRoutingModule } from './opinion-routing.module';
import { OpinionComponent } from './opinion.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [OpinionComponent],
  imports: [
    CommonModule,
    OpinionRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class OpinionModule { }
