import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EventService } from 'src/app/Service/event.service';
import { Event } from 'src/app/Classes/Event';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-create-event',
  templateUrl: './create-event.component.html',
  styleUrls: ['./create-event.component.scss']
})
export class CreateEventComponent implements OnInit {
  
  
  
  hide = true;
  eventId!: string | any
  myEvent: Event = {UserId:0, EventType: 1, DateEvent: new Date(), Password: '',Name: '',Location: ''};
  newEvent: Event =new Event();
  //myEvent:Event|any

  eventForm!: FormGroup;
  showAllEvent: Event[] = []

  constructor(private EventSer: EventService, private myRoute: Router) { }
//בדיקות תקינות
  ngOnInit(): void {
    this.eventForm = new FormGroup({
      userId: new FormControl(0,[Validators.required,Validators.min(1),Validators.max(3)]),
      eventType:new FormControl(0,[Validators.required]),
      dateEvent:new FormControl(new Date(),[Validators.required]),
      password:new FormControl("",[Validators.required]),
      name:new FormControl("",[Validators.required]),
      location:new FormControl("",[Validators.required]),
      link:new FormControl("",[Validators.required]),
      text:new FormControl("",[Validators.required]),
      picture:new FormControl("",[Validators.required]),
 }); 
  }

  AddEvent(){
    if( this.eventForm.valid){
      console.log(this.eventForm)
      this.newEvent = {UserId:this.eventForm.controls.userId.value, EventType:1,DateEvent:new Date(),
        Password:this.eventForm.controls.password.value, Name:this.eventForm.controls.name.value,
        Location:this.eventForm.controls.location.value, Link: this.eventForm.controls.link.value,
        Text:this.eventForm.controls.text.value,Picture: this.eventForm.controls.picture.value}
      this.EventSer.AddEvent(this.newEvent).subscribe((data)=>{alert(data);console.log("data",data)})

    }
    else
    alert("לא תקין");
  }
}


