import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Marker } from './marker';

@Injectable({
  providedIn: 'root'
})
export class MarkerService {

  constructor() { }

  getMarkers(section:string): Observable<Marker[]>{
    console.log(section);
    var markers: Marker[] = [{
      latitude: 40.7608,
      longitude: -111.8910,
      label: section,
      draggable: false,
      animation: 'DROP',
      iconUrl: '/'
    }];
    return of(markers);
  }
}
