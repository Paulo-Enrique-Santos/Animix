import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';

import { ComponentsModule } from '@shared/components';
import { MaterialModule } from '@shared/material';
import { MiniComponentsModule } from './components/mini-components/mini-components.module';

@NgModule({
  imports: [
    CommonModule
  ],
  exports: [
    ComponentsModule,
    MaterialModule,
    MiniComponentsModule
  ]
})
export class SharedModule { }
