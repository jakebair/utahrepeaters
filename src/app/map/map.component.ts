import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-map',
  templateUrl: './map.component.html',
  styleUrls: ['./map.component.css']
})
export class MapComponent implements OnInit {
    title = 'utahrepeaters';
    latitude = 40.7608;
    longitude = -111.8910;
    zoom = 8;

    markers: Marker[] = [];

    ngOnInit() {
        if (window.navigator.geolocation) {
            window.navigator.geolocation.getCurrentPosition(this.setPosition.bind(this));
        }
    }

    setPosition(position) {
        // center map on user
        this.latitude = position.coords.latitude;
        this.longitude = position.coords.longitude;

        // create a marker
        const positionMarker: Marker = {
            latitude: position.coords.latitude,
            longitude: position.coords.longitude,
            label: 'Current Location',
            draggable: true,
            animation: 'DROP',
            iconUrl: '/'
        };
        this.markers.push(positionMarker);
    }

    markerDragEnd(m: Marker, $event: MouseEvent) {
        this.setPosition($event);
    }
}

interface Marker {
    latitude: number;
    longitude: number;
    label?: string;
    draggable: boolean;
    animation: string;
    iconUrl: string;
}

