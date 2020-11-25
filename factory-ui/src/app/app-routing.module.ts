import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AirplaneDetailComponent } from 'src/app/components/airplane-detail/airplane-detail.component';
import { AirplaneListComponent } from 'src/app/components/airplane-list/airplane-list.component';
import { NewAirplaneComponent } from 'src/app/components/new-airplane/new-airplane.component';

const routes: Routes = [
  {
    path: '',
    component: AirplaneListComponent
  },
  {
    path: 'new-airplane',
    component: NewAirplaneComponent
  },
  {
    path: 'airplane-detail/:id',
    component: AirplaneDetailComponent
  },


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
