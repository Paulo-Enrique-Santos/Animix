import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';

import { MarketplaceComponent } from '@pages/marketplace/marketplace';

const components = [
  MarketplaceComponent
]

@NgModule({
  declarations: [...components],
  imports: [
    CommonModule
  ],
  exports: [...components]
})
export class MarketplaceModule { }
