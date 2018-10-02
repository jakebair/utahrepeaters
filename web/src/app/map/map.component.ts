import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { MarkerService } from '../marker.service';
import { Marker } from '../marker';

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
    section = 'default';

    markers: Marker[] = [];

    constructor(
        private route: ActivatedRoute,
        private router: Router,
        private service: MarkerService
    ) {}

    ngOnInit() {
        if (window.navigator.geolocation) {
            window.navigator.geolocation.getCurrentPosition(this.setPosition.bind(this));
        }

        this.getMarkers();
    }

    getMarkers() {
        this.route.paramMap.subscribe(params => {
            const section = params.get('section');

            if(section) {
                this.service.getMarkers(section).subscribe(markers => {
                    markers.push(this.getPosition())
                    this.markers = markers
                });
            }
        })
    }

    setPosition(position) {
        // center map on user
        this.latitude = position.coords.latitude;
        this.longitude = position.coords.longitude;

        this.markers.push(this.getPosition());
    }

    getPosition() {
        const marker: Marker = {
            latitude: this.latitude,
            longitude: this.longitude,
            label: 'Current Location',
            draggable: true,
            animation: 'DROP',
            iconUrl: '/' 
        }
        return marker;
    }

    markerDragEnd(m: Marker, $event: MouseEvent) {
        this.setPosition($event);
    }
}



