import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PlayesComponent } from './playes/playes.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  {path:"players", component:PlayesComponent},
  {path:"home", component:HomeComponent},
  {path:"", component:HomeComponent},
  {path:"**", component:HomeComponent} 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
