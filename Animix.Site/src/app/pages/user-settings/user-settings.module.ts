import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';

import { UserSettingsComponent } from '@pages/user-settings/user-settings';

const components = [
  UserSettingsComponent
]

@NgModule({
  declarations: [...components],
  imports: [
    CommonModule
  ],
  exports: [...components]
})
export class UserSettingsModule { }
