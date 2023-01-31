import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';

import { CartComponent } from '@pages/cart/cart';

const components = [
  CartComponent
];

@NgModule({
  declarations: [...components],
  imports: [
    CommonModule
  ],
  exports: [...components]
})
export class CartModule { }
