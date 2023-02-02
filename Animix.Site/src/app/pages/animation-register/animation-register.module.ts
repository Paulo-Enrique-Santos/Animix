import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';

import { AnimationRegisterComponent } from '@pages/animation-register/animation-register';
import { SharedModule } from '@shared/shared.module';

const components = [
  AnimationRegisterComponent
]

@NgModule({
  declarations: [...components],
  imports: [
    CommonModule,
    SharedModule
  ],
  exports: [...components]
})
export class AnimationRegisterModule { }
