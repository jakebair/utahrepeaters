import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';

import { adminLteConf } from './admin-lte.conf';
import { LayoutModule } from 'angular-admin-lte';

import { NgModule } from '@angular/core';
import { AgmCoreModule } from '@agm/core';

import { AppComponent } from './app.component';
import { MapComponent } from './map/map.component';

const appRoutes: Routes = [
    {
        path: '',
        redirectTo: '/map',
        pathMatch: 'full'
    },
    {
        path: 'map',
        component: MapComponent
    }
];

@NgModule({
    declarations: [
        AppComponent,
        MapComponent
    ],
    imports: [
        BrowserModule,
        AgmCoreModule.forRoot({
            apiKey: 'AIzaSyA283KmhNJPT5UGp1PEljVUok2ZJ47V_D0'
        }),
        RouterModule.forRoot(appRoutes),
        LayoutModule.forRoot(adminLteConf)
    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule { }
