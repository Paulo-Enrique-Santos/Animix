import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';

import { HomeComponent } from '@pages/home/home';
import { 
  HomeSectionComponent,
  CharacterSectionComponent,
  SkySectionComponent,
  DevSectionComponent
} from '@pages/home/components';

const components = [
  HomeComponent,
  HomeSectionComponent,
  CharacterSectionComponent,
  SkySectionComponent,
  DevSectionComponent
]

@NgModule({
  declarations: [...components],
  imports: [
    CommonModule
  ],
  exports: [...components]
})
export class HomeModule { }
