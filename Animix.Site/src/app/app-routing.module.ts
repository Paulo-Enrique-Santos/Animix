import { NgModule } from '@angular/core';

import { RouterModule, Routes } from '@angular/router';

import { HomeComponent } from '@pages/home/home';
import { CharacterCardComponent } from '@shared/components/character-card';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'teste', component: CharacterCardComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
