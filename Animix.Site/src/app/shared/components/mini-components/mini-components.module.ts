import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';

import { HamburgerComponent } from '@shared/components/mini-components/hamburger';

const components = [
  HamburgerComponent
];

@NgModule({
  declarations: [...components],
  imports: [
    CommonModule
  ],
  exports: [...components]
})
export class MiniComponentsModule { }
