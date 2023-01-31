import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';

import { UserTransactionsComponent } from '@pages/user-transactions/user-transactions';

const components = [
  UserTransactionsComponent
]

@NgModule({
  declarations: [...components],
  imports: [
    CommonModule
  ],
  exports: [...components]
})
export class UserTransactionsModule { }
