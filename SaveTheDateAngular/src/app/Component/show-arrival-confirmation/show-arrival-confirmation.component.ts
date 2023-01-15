import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Guest } from 'src/app/Classes/Guest';
import { EventService } from 'src/app/Service/event.service';

@Component({
  selector: 'app-show-arrival-confirmation',
  templateUrl: './show-arrival-confirmation.component.html',
  styleUrls: ['./show-arrival-confirmation.component.scss']
})
export class ShowArrivalConfirmationComponent implements OnInit {

  showAllInvitedGuests:Guest[] = [];
  ConfirmGuestsCount!:number;

  constructor(private EventSer: EventService, private myRoute: Router) { }

  ngOnInit(): void {
    this.EventSer.GetAllInvitedGuests(this.EventSer.IdentifiedEvent.Id).subscribe(res => {
      if (res) {
        console.log("All Invite",res);
        this.showAllInvitedGuests = res;
      }
      else
        alert("there is no data")
    });;
 
this.EventSer.GetAllConfirmGuestsCount(this.EventSer.IdentifiedEvent.Id).subscribe(data => { this.ConfirmGuestsCount = data; console.log(data) },
error => { throw error },
() => console.log("finished"));
}

}
