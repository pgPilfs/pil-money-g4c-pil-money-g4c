import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ModifiedUserRoutingModule } from './modified-user-routing.module';
import { ModifiedUserComponent } from './modified-user.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [ModifiedUserComponent],
  imports: [
    CommonModule,
    ModifiedUserRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class ModifiedUserModule { }
