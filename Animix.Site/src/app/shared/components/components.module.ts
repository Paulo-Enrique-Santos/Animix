import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';

import { MaterialModule } from '@shared/material';
import { MiniComponentsModule } from '@shared/components/mini-components';
import { HeaderComponent } from '@shared/components/header';
import { CharacterCardComponent } from '@shared/components/character-card';
import { GenericListCardComponent } from '@shared/components/generic-list-card';
import { GenericEditCardComponent } from '@shared/components/generic-edit-card';
import { GenericFormComponent } from './generic-form/generic-form.component';

const components = [
  HeaderComponent,
  CharacterCardComponent,
  GenericListCardComponent,
  GenericEditCardComponent
];

@NgModule({
  declarations: [...components, GenericFormComponent],
  imports: [
    CommonModule,
    MaterialModule,
    MiniComponentsModule
  ],
  exports: [...components]
})
export class ComponentsModule { }
