import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Bus } from 'src/app/Classes/Bus';
import { EventService } from 'src/app/Service/event.service';

@Component({
  selector: 'app-event-shuttle',
  templateUrl: './event-shuttle.component.html',
  styleUrls: ['./event-shuttle.component.scss']
})
export class EventShuttleComponent implements OnInit {

  showAllBuses: Bus[] = []

  constructor(private EventSer: EventService, private myRoute: Router) { }

  ngOnInit(): void {
    this.EventSer.GetAllBusesOfEvent(this.EventSer.IdentifiedEvent.Id).subscribe(res => {
      if (res) {
        console.log("All Bus",res);
        this.showAllBuses = res;
      }
      else
        alert("there is no data")
    });;
  }

  

}
