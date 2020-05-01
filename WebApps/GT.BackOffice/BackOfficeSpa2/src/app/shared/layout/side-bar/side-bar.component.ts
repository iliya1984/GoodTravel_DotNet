import { Component, OnInit } from '@angular/core';
import { INavigationItem } from 'src/app/entities/interfaces/layout/navigation-item';
import { INavigationMenu } from 'src/app/entities/interfaces/layout/navigation-menu';
import { FlightsPageComponent } from 'src/app/pages/flights/flights-page/flights-page.component';

@Component({
  selector: 'app-side-bar',
  templateUrl: './side-bar.component.html',
  styleUrls: ['./side-bar.component.scss']
})
export class SideBarComponent implements OnInit {

  public menu: INavigationMenu;

  constructor()
  {
    this.initStaticMenu();
  }

  ngOnInit() {
  }

  private initStaticMenu()
  {
    this.menu = {
      items: [
        {
          displayName: 'Orders',
          route: 'orders'
        },
        {
          displayName: 'Products',
          children:[
            {
              displayName: 'Flights',
              route: 'flights'
            },
            {
              displayName: 'Hotels',
              route: 'hotels'
            },
            {
              displayName: 'Packages',
              route: 'packages'
            }
          ]
        },
        {
          displayName: 'Itinerary',
          children:[
            {
              displayName: 'Airports',
              route: 'airports'
            },
            {
              displayName: 'Airlines',
              route: 'airlines'
            },
            {
              displayName: 'Cities',
              route: 'cities'
            },
            {
              displayName: 'Countires',
              route: 'countries'
            }
          ]
        }
      ]
    };
  }
}
