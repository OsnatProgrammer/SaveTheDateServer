import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Table } from 'src/app/Classes/Table';
import { EventService } from 'src/app/Service/event.service';

@Component({
  selector: 'app-table-placement',
  templateUrl: './table-placement.component.html',
  styleUrls: ['./table-placement.component.scss']
})
export class TablePlacementComponent implements OnInit {

  showAllITable:Table[]=[]

  constructor(private EventSer: EventService, private myRoute: Router) { }

  ngOnInit(): void {
  
  this.EventSer.GetAllTablesOfEvent(this.EventSer.IdentifiedEvent.Id).subscribe(res => {
    if (res) {
      console.log("All Table",res);
      this.showAllITable = res;
    }
    else
      alert("there is no data")
  });;
  }
}
// this.EventSer.GetAllConfirmGuestsCount(this.EventSer.IdentifiedEvent.Id).subscribe(data => { this.ConfirmGuestsCount = data; console.log(data) },
// error => { throw error },
// () => console.log("finished"));
// }
//}