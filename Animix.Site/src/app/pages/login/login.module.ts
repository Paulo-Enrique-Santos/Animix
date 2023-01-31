import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';

import { LoginComponent } from '@pages/login/login';

const components = [
  LoginComponent
]

@NgModule({
  declarations: [...components],
  imports: [
    CommonModule
  ],
  exports: [...components]
})
export class LoginModule { }
