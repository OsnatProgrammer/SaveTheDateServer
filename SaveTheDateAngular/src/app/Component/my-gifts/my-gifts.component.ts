import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EventService } from 'src/app/Service/event.service';

@Component({
  selector: 'app-my-gifts',
  templateUrl: './my-gifts.component.html',
  styleUrls: ['./my-gifts.component.scss']
})
export class MyGiftsComponent implements OnInit {

  constructor(private EventSer: EventService, private myRoute: Router) { }

  ngOnInit(): void {
  }
  chooseGifts(){
    this.myRoute.navigate(["/Gifts List"]);
  }

      // //להעביר לאחרי המתנות ולהזריק את הדיולוג בקונסטרקטור 
      // this.dialog.open(DialogBoxComponent)
      // this.myRoute.navigate(["/"]);
}


