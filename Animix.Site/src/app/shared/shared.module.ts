import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';

import { ComponentsModule } from '@shared/components';
import { MaterialModule } from '@shared/material';

@NgModule({
  imports: [
    CommonModule
  ],
  exports: [
    ComponentsModule,
    MaterialModule
  ]
})
export class SharedModule { }
