import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EventService } from 'src/app/Service/event.service';
import { Event } from 'src/app/Classes/Event';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { DialogBoxComponent } from '../dialog-box/dialog-box.component';
import { MatDialog } from '@angular/material/dialog';
import * as XLSX from 'xlsx';
import { User } from 'src/app/Classes/User';
//import { timeStamp } from 'console';
import { Guest } from 'src/app/Classes/Guest';

@Component({
  selector: 'app-create-event',
  templateUrl: './create-event.component.html',
  styleUrls: ['./create-event.component.scss']
})
export class CreateEventComponent implements OnInit {



  hide = true;
  eventId!: string | any
  myEvent: Event = { UserId: 0, EventType: 1, Date: new Date(), Password: '', Name: '', Location: '' };
  newEvent: Event = new Event();
  //myEvent:Event|any

  eventForm!: FormGroup;
  showAllEvent: Event[] = []
  ExcelData: any;
  showListGust: boolean = false;
  newUser: User = new User();
  newGuest: Guest = new Guest();

  constructor(private EventSer: EventService, private myRoute: Router, public dialog: MatDialog) { }
  //בדיקות תקינות
  ngOnInit(): void {
    console.log(this.passwordToPass);
    this.eventForm = new FormGroup({
      eventType: new FormControl(1, [Validators.required, Validators.min(1), Validators.max(3)]),
      date: new FormControl(new Date(), [Validators.required]),
      password: new FormControl(this.passwordToPass, [Validators.required]),
      name: new FormControl("", [Validators.required]),
      location: new FormControl("", [Validators.required]),
      link: new FormControl("", [Validators.required]),
      text: new FormControl("", [Validators.required]),
      picture: new FormControl("", [Validators.required]),
    });
  }

  AddEvent() {
    if (this.eventForm.valid) {
      console.log(this.eventForm)
      this.newEvent = {
        UserId: this.userId, EventType: 1, Date: new Date(),
        Password: this.eventForm.controls.password.value, Name: this.eventForm.controls.name.value,
        Location: this.eventForm.controls.location.value, Link: this.eventForm.controls.link.value,
        Text: this.eventForm.controls.text.value, Picture: this.eventForm.controls.picture.value
      }
      this.EventSer.AddEvent(this.newEvent).subscribe((data) => { alert(data); console.log("data", data) })
      this.EventSer.IdentifiedEvent = this.newEvent
      this.myRoute.navigate(["/My Gifts"]);
    }
    else
      alert("לא תקין");
  }

  ReadExcel(event: any) {

    let file = event.target.files[0];
    let fileReader = new FileReader();
    fileReader.readAsBinaryString(file);

    fileReader.onload = (e) => {

      var workBook = XLSX.read(fileReader.result, { type: 'binary' });
      var sheetNames = workBook.SheetNames;
      this.ExcelData = XLSX.utils.sheet_to_json(workBook.Sheets[sheetNames[0]])
      console.log(this.ExcelData)
      if (this.ExcelData)
        this.showListGust = true;

    }
  }
  AddList() {
    this.showListGust = false;
    this.ExcelData.forEach((data: { Name: string; Phone: string; Email: string }) => {
      this.newUser = { Name: data.Name, Phone: data.Phone, Email: data.Email }
      this.EventSer.AddUser(this.newUser).subscribe(id => {
        this.newGuest={UserId:id,EventId:this.EventSer.IdentifiedEvent.Id,ArrivalConf:false}
        this.EventSer.AddGuest(this.newGuest)
      })
    });
  }

@Input() passwordToPass!: number;
@Input() userId!: number;


}


