import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ModifiedUserComponent } from './modified-user.component';

const routes: Routes = [{ path: '', component: ModifiedUserComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ModifiedUserRoutingModule { }
