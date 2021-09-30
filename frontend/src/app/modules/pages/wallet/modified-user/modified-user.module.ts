import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ModifiedUserRoutingModule } from './modified-user-routing.module';
import { ModifiedUserComponent } from './modified-user.component';


@NgModule({
  declarations: [ModifiedUserComponent],
  imports: [
    CommonModule,
    ModifiedUserRoutingModule
  ]
})
export class ModifiedUserModule { }
