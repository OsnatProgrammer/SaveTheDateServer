import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { EventService } from 'src/app/Service/event.service';

@Component({
  selector: 'app-guest-login',
  templateUrl: './guest-login.component.html',
  styleUrls: ['./guest-login.component.scss']
})
export class GuestLoginComponent implements OnInit {
  
  eventForm!: FormGroup;

  constructor(private EventSer: EventService, private myRoute: Router) { }

//בדיקות תקינות
  ngOnInit(): void {
    this.eventForm = new FormGroup({
      phone: new FormControl(0,[Validators.required]),
 }); 
  }
}
