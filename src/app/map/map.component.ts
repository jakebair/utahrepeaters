import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { switchMap } from 'rxjs/operators';
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

        this.markers$ = this.route.paramMap.pipe(
            switchMap((params: ParamMap) =>
                this.service.getMarkers(params.get('section'))
          ));
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



