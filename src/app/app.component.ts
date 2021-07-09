import { Component } from '@angular/core';

//router
import { Location } from '@angular/common';
import { Router } from '@angular/router';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'PIL - MONEY - GRUPO 4 AULA 4';

  portada:boolean

  constructor(
    location: Location,
    router: Router
  ) {
    router.events.subscribe((val) => {
      if(location.path() === ''){
        this.portada = true
      } else {
        this.portada = false
      }
    });

  }

  ngOnInit(): void {

  }
}
