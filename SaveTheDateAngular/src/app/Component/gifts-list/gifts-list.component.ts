import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Gift } from 'src/app/Classes/Gift';
import { EventService } from 'src/app/Service/event.service';

@Component({
  selector: 'app-gifts-list',
  templateUrl: './gifts-list.component.html',
  styleUrls: ['./gifts-list.component.scss']
})
export class GiftsListComponent implements OnInit {

  showAllGifts!: Gift[];// =new List<Gift>
  constructor(private EventSer: EventService, private myRoute: Router) { }

  ngOnInit(): void {
this.EventSer.GetGiftsByEventType(this.EventSer.IdentifiedEvent.EventType).subscribe((data:Gift[]) => { this.showAllGifts = data;
  console.log(data) },error => { throw error },
  () => console.log("finished"));
  }

  saveChange(){
    
  }

}
