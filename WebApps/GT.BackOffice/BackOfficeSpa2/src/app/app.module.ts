import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SideBarComponent } from './shared/layout/side-bar/side-bar.component';
import { HeaderComponent } from './shared/layout/header/header.component';
import { ContentComponent } from './shared/layout/content/content.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatToolbarModule } from  '@angular/material/toolbar';
import { MatIconModule } from  '@angular/material/icon';
import { MatSidenavModule } from  '@angular/material/sidenav';
import {  MatListModule } from  '@angular/material/list';
import {  MatButtonModule } from  '@angular/material/button';
import { HttpClientModule } from '@angular/common/http';
import { FlightsPageComponent } from './pages/flights/flights-page/flights-page.component';
import { NewFlightPageComponent } from './pages/flights/new-flight-page/new-flight-page.component';
import { NavigationItemComponent } from './shared/layout/navigation-item/navigation-item.component';
import { NavigationService } from './services/layout/navigation.service';
;
@NgModule({
  declarations: [
    AppComponent,
    ContentComponent,
    SideBarComponent,
    HeaderComponent,
    FlightsPageComponent,
    NewFlightPageComponent,
    NavigationItemComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatSidenavModule,
    MatListModule,
    MatButtonModule,
    MatIconModule,
    HttpClientModule
  ],
  providers: [NavigationService],
  bootstrap: [AppComponent]
})
export class AppModule { }
