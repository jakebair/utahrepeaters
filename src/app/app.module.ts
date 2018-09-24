import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AgmCoreModule } from '@agm/core';

import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AgmCoreModule.forRoot({
      apiKey:'AIzaSyA283KmhNJPT5UGp1PEljVUok2ZJ47V_D0'
    })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
