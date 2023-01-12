import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EventService } from 'src/app/Service/event.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.scss']
})
export class NavComponent implements OnInit {

  constructor( public EventSer: EventService, private myRoute: Router) { }

  ngOnInit(): void {
  }
  
  logOut(){
    //this.dialog.open(IdentifiedClientComponent);
    //this.myClientSer.isIdentified=false      
    this.myRoute.navigate(["/Home"])
   }

   showHome(){
     
     //this.myTravelAgencySer.isShowHome=true;
   }


}
