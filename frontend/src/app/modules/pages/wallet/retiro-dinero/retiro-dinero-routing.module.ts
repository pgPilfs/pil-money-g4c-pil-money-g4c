import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RetiroDineroComponent } from './retiro-dinero.component';

const routes: Routes = [{ path: '', component: RetiroDineroComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class RetiroDineroRoutingModule { }
