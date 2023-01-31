import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';

import { UserRegisterComponent } from '@pages/user-register/user-register';

const components = [
  UserRegisterComponent
]

@NgModule({
  declarations: [...components],
  imports: [
    CommonModule
  ],
  exports: [...components]
})
export class UserRegisterModule { }
