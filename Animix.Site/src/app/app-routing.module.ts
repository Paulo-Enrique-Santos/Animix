import { NgModule } from '@angular/core';

import { RouterModule, Routes } from '@angular/router';

import { AnimationRegisterComponent } from '@pages/animation-register/animation-register';
import { CartComponent } from '@pages/cart/cart';
import { CharacterRegisterComponent } from '@pages/character-register/character-register';
import { HomeComponent } from '@pages/home/home';
import { LoginComponent } from '@pages/login/login';
import { MarketplaceComponent } from '@pages/marketplace/marketplace';
import { UserExtractComponent } from '@pages/user-extract/user-extract';
import { UserRegisterComponent } from '@pages/user-register/user-register';
import { UserSettingsComponent } from '@pages/user-settings/user-settings';
import { UserTransactionsComponent } from '@pages/user-transactions/user-transactions';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'criar-animacao', component: AnimationRegisterComponent},
  {path: 'carrinho', component: CartComponent},
  {path: 'criar-personagem', component: CharacterRegisterComponent},
  {path: 'login', component: LoginComponent},
  {path: 'loja', component: MarketplaceComponent},
  {path: 'extrato', component: UserExtractComponent},
  {path: 'cadastro', component: UserRegisterComponent},
  {path: 'configuracao', component: UserSettingsComponent},
  {path: 'transacao', component: UserTransactionsComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
