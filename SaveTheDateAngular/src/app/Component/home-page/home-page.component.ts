import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EventService } from 'src/app/Service/event.service';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.scss']
})
export class HomePageComponent implements OnInit {

  constructor(private EventSer: EventService, private myRoute: Router) { }

  ngOnInit(): void {
  }
  
  Registration (){
    this.myRoute.navigate(["/Register"]);

  }
  Login(){
    this.myRoute.navigate(["/Login"]);

  }
}
