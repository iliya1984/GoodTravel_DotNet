import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { FlightsPageComponent } from './pages/flights/flights-page/flights-page.component';


const routes: Routes = [
  { path: 'flights', component: FlightsPageComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
