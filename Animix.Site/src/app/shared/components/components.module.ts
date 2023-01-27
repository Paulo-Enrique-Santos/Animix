import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';

import { MaterialModule } from '@shared/material';
import { MiniComponentsModule } from '@shared/components/mini-components';
import { HeaderComponent } from '@shared/components/header';
import { CharacterCardComponent } from '@shared/components/character-card';

const components = [
  HeaderComponent,
  CharacterCardComponent
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
