import { Component } from '@angular/core';
import { coreDirectives } from '@agm/core/core.module';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'utahrepeaters';
  latitude = 40.7608;
  longitude = -111.8910;
  zoom: number = 8;

  markers: marker[] = [];

  ngOnInit() {
    if(window.navigator.geolocation) {
      window.navigator.geolocation.getCurrentPosition(this.setPosition.bind(this));
    }
  }

  setPosition(position) {
    console.log(position);
    var marker:marker = {
      latitude: position.coords.latitude,
      longitude: position.coords.longitude,
      label: 'Current Location',
      draggable: true
    }
    this.markers.push(marker);
  }
}

interface marker {
	latitude: number;
	longitude: number;
	label?: string;
	draggable: boolean;
}
