import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FlexLayoutModule } from '@angular/flex-layout';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { Land1Component } from './components/land1/land1.component';
import { IntelComponent } from './components/intel/intel.component';
import { CedukComponent } from './components/ceduk/ceduk.component';
import { RegistroComponent } from './components/registro/registro.component';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { LandPageComponent } from './components/land-page/land-page.component';

const appRoutes: Routes = [
  { path: 'registro', component: RegistroComponent },
  { path: 'land', component: LandPageComponent },
  { path: '',   redirectTo: '/land', pathMatch: 'full' }
  // { path: '**', component: NotFoundComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    Land1Component,
    IntelComponent,
    CedukComponent,
    RegistroComponent,
    LandPageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FlexLayoutModule,
    RouterModule.forRoot(
      appRoutes,
    )
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
