import { Component } from '@angular/core';
import { Router, NavigationStart, NavigationEnd,NavigationCancel, Event, NavigationError } from '@angular/router';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: []
})
export class AppComponent {
  title = 'Displaying current changes for this employee';
  waitIndicator: boolean = true;
  constructor(private _router: Router) {
    this._router.events.subscribe((triggeredevent: Event) => {
      if (triggeredevent instanceof NavigationStart) {
        this.waitIndicator = true;
      }
      if (triggeredevent instanceof NavigationEnd || 
        triggeredevent instanceof NavigationCancel|| triggeredevent instanceof NavigationError) {
        this.waitIndicator = false;
      }
    })
  }
}
