import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
// import { strict } from 'assert';
import { Guest } from 'src/app/Classes/Guest';
import { Table } from 'src/app/Classes/Table';
import { User } from 'src/app/Classes/User';
import { EventService } from 'src/app/Service/event.service';

@Component({
  selector: 'app-table-placement',
  templateUrl: './table-placement.component.html',
  styleUrls: ['./table-placement.component.scss']
})
export class TablePlacementComponent implements OnInit {

  showAllConfirmGuests: Guest[] = []
  showAllUsers: User[] = []
  showAllTables: Table[] = []
  myForm!: FormGroup;
  GuestsToShow: Guest[] = []
  numOfPepole:number []=[]
numberOfPeople:number=0

  constructor(private EventSer: EventService, private myRoute: Router) { }

  ngOnInit(): void {

    this.EventSer.GetAllTablesOfEvent(this.EventSer.IdentifiedEvent.Id).subscribe(res => {
      if (res) {
        console.log("All ConfirmTables", res);
        this.showAllTables = res;
      }
      else
        alert("there is no data")
    });;



    this.EventSer.GetAllConfirmGuests(this.EventSer.IdentifiedEvent.Id).subscribe(res => {
      if (res) {
        console.log("All ConfirmGuests", res);
        this.showAllConfirmGuests = res;
        this.GuestsToShow = res;
      }
      else
        alert("there is no data")
    });;

    this.EventSer.GetAllUsers().subscribe(res => {
      if (res) {
        console.log("All Users", res);
        this.showAllUsers = res;
      }
      else
        alert("there is no data")
    });;

    this.myForm = new FormGroup({
      selected: new FormControl("", [Validators.required])
    });
  }
  selectFilter(option: string) {

    switch (option) {
      case "haveTable": this.GuestsToShow = this.showAllConfirmGuests.filter(g => g.TableNum != null); break;
      case "noTable": this.GuestsToShow = this.showAllConfirmGuests.filter(g => g.TableNum == null); break;
      default: this.GuestsToShow = this.showAllConfirmGuests;
    }
  }

}




// this.EventSer.GetAllConfirmGuestsCount(this.EventSer.IdentifiedEvent.Id).subscribe(data => { this.ConfirmGuestsCount = data; console.log(data) },
// error => { throw error },
// () => console.log("finished"));
// }
//}