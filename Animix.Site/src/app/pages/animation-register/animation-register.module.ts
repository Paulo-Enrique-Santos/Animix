import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AnimationRegisterComponent } from '@pages/animation-register/animation-register';

const components = [
  AnimationRegisterComponent
]

@NgModule({
  declarations: [...components],
  imports: [
    CommonModule
  ],
  exports: [...components]
})
export class AnimationRegisterModule { }
