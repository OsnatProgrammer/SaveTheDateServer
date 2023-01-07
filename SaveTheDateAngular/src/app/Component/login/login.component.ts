import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { EventService } from 'src/app/Service/event.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  eventForm!: FormGroup;
  showAllEvent: Event[] = []

  constructor(private EventSer: EventService, private myRoute: Router) { }
//בדיקות תקינות
  ngOnInit(): void {
    this.eventForm = new FormGroup({
      phone: new FormControl(0,[Validators.required]),
      password:new FormControl("",[Validators.required]),     
 }); 
  }
  //this.EventSer.IdentifiedEvent.Password=this.eventForm.controls.password.value;
  CheckUser(){
    this.EventSer.Login(this.eventForm.controls.phone.value,this.eventForm.controls.password.value)
    .subscribe(data=>this.myRoute.navigate(["/Event Page"]),error => {throw error}
    ,() =>this.EventSer.IdentifiedEvent.Password=this.eventForm.controls.password.value );   
  }
}

