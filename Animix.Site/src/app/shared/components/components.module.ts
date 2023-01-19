import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';

import { MaterialModule } from '@shared/material';
import { HeaderComponent } from '@shared/components/header';
import { MiniComponentsModule } from '@shared/components/mini-components';

const components = [
  HeaderComponent
];

@NgModule({
  declarations: [...components],
  imports: [
    CommonModule,
    MaterialModule,
    MiniComponentsModule
  ],
  exports: [...components]
})
export class ComponentsModule { }
