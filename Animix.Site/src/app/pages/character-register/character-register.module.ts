import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';

import { CharacterRegisterComponent } from '@pages/character-register/character-register';

const components = [
  CharacterRegisterComponent
]

@NgModule({
  declarations: [...components],
  imports: [
    CommonModule
  ],
  exports: [...components]
})
export class CharacterRegisterModule { }
