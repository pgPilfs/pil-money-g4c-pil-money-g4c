import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { WalletRoutingModule } from './wallet-routing.module';
import { WalletComponent } from './wallet.component';
import { TransferModule } from './transfer/transfer.module';
import { IngresoMoneyModule } from './ingreso-money/ingreso-money.module';


@NgModule({
  declarations: [WalletComponent],
  imports: [
    CommonModule,
    WalletRoutingModule,
    TransferModule,
    IngresoMoneyModule
  ]
})

export class WalletModule { }