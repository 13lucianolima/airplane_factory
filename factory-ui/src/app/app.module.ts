import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AirplaneListComponent } from './components/airplane-list/airplane-list.component';
import { AirplaneDetailComponent } from './components/airplane-detail/airplane-detail.component';
import { HttpClientModule } from '@angular/common/http';
import { NewAirplaneComponent } from './components/new-airplane/new-airplane.component';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    AirplaneListComponent,
    AirplaneDetailComponent,
    NewAirplaneComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
