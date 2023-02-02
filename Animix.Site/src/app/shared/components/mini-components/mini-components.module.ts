import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';

import { HamburgerComponent } from '@shared/components/mini-components/hamburger';
import { ListItemGenericCardComponent } from '@shared/components/mini-components/list-item-generic-card';
import { MaterialModule } from '@shared/material';

const components = [
  HamburgerComponent,
  ListItemGenericCardComponent
];

@NgModule({
  declarations: [...components],
  imports: [
    CommonModule,
    MaterialModule
  ],
  exports: [...components]
})
export class MiniComponentsModule { }
