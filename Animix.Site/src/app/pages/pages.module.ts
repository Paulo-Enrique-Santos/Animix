import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';

import { HomeModule } from '@pages/home';
import { AnimationRegisterModule } from '@pages/animation-register';
import { CartModule } from '@pages/cart';
import { CharacterRegisterModule } from '@pages/character-register';
import { LoginModule } from '@pages/login';
import { MarketplaceModule } from '@pages/marketplace';
import { UserRegisterModule } from '@pages/user-register';
import { UserSettingsModule } from '@pages/user-settings';
import { UserTransactionsModule } from '@pages/user-transactions';
import { UserExtractModule } from '@pages/user-extract';

@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ],
  exports: [
    HomeModule,
    AnimationRegisterModule,
    CartModule,
    CharacterRegisterModule,
    LoginModule,
    MarketplaceModule,
    UserRegisterModule,
    UserSettingsModule,
    UserTransactionsModule,
    UserExtractModule
  ]
})
export class PagesModule { }
