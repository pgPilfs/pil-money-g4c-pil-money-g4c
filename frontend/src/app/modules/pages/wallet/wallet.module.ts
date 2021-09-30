import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { WalletRoutingModule } from './wallet-routing.module';
import { WalletComponent } from './wallet.component';
import { TransferModule } from './transfer/transfer.module';
import { IngresoMoneyModule } from './ingreso-money/ingreso-money.module';
import { PayServicesComponent } from './pay-services/pay-services.component';
import { PayServicesModule } from './pay-services/pay-services.module';
import { PayServicesDetailComponent } from './pay-services-detail/pay-services-detail.component';
import { ModifiedUserComponent } from './modified-user/modified-user.component';


@NgModule({
  declarations: [WalletComponent],
  imports: [
    CommonModule,
    WalletRoutingModule,
    TransferModule,
    IngresoMoneyModule,
    PayServicesModule
  ]
})

export class WalletModule { }