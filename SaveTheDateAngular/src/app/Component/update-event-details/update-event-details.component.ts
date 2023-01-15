import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EventService } from 'src/app/Service/event.service';
import { Event } from 'src/app/Classes/Event';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-update-event-details',
  templateUrl: './update-event-details.component.html',
  styleUrls: ['./update-event-details.component.scss']
})
export class UpdateEventDetailsComponent implements OnInit {



  eventForm!: FormGroup;
  myEvent: Event=new Event();

  constructor(private EventSer: EventService, private myRoute: Router) { }
//private fb: FormBuilder,public dialog: MatDialog,


//בדיקות תקינות
  ngOnInit(): void {


    this.eventForm = new FormGroup({
      
      userId: new FormControl(0,[Validators.required]),
      eventType:new FormControl(0,[Validators.required,Validators.min(1),Validators.max(3)]),
      dateEvent:new FormControl(new Date(),[Validators.required]),
      password:new FormControl("",[Validators.required]),
      name:new FormControl("",[Validators.required]),
      location:new FormControl("",[Validators.required]),
      link:new FormControl("",[Validators.required]),
      text:new FormControl("",[Validators.required]),
      picture:new FormControl("",[Validators.required]),
 }); 
    this.eventForm.controls['userId'].setValue(this.EventSer.IdentifiedEvent.UserId);
    this.eventForm.controls['eventType'].setValue(this.EventSer.IdentifiedEvent.EventType);
    this.eventForm.controls['dateEvent'].setValue(this.EventSer.IdentifiedEvent.DateEvent);
    this.eventForm.controls['name'].setValue(this.EventSer.IdentifiedEvent.Name);
    this.eventForm.controls['location'].setValue(this.EventSer.IdentifiedEvent.Location);
    this.eventForm.controls['link'].setValue(this.EventSer.IdentifiedEvent.Link);
    this.eventForm.controls['text'].setValue(this.EventSer.IdentifiedEvent.Text);
    this.eventForm.controls['picture'].setValue(this.EventSer.IdentifiedEvent.Picture);
    
  }
  MyIdentifiedEvent:Event =this.EventSer.IdentifiedEvent
  
  edit(eventToEdit:Event) {
  
    console.log('eventToEdit', eventToEdit);
    // this.myEvent = {...eventToEdit};
    this.EventSer.UpdateEvent(eventToEdit).subscribe(data => {
      if (data) {
        console.log("data",data)
      }
      else { alert("הנתונים אינם תואמים, נסה שוב") }
  
}
);
  }
}
