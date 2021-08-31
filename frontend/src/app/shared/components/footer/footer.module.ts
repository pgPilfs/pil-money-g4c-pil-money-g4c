import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FooterComponent } from './footer.component';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [FooterComponent],
  imports: [
    RouterModule,
    CommonModule
  ],
  exports:[FooterComponent]
})
export class FooterModule { }
