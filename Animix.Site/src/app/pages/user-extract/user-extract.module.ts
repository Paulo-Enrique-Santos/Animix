import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';

import { UserExtractComponent } from '@pages/user-extract/user-extract';

const components = [
  UserExtractComponent
]

@NgModule({
  declarations: [...components],
  imports: [
    CommonModule
  ],
  exports: [...components]
})
export class UserExtractModule { }
