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
  
  GuestLoginForm!: FormGroup;

  constructor(private EventSer: EventService, private myRoute: Router) { }

//בדיקות תקינות
  ngOnInit(): void {
    this.GuestLoginForm = new FormGroup({
      phone: new FormControl(0,[Validators.required]),
    }); 
  }

  CheckUser(){
    this.EventSer.GetGuestByPhone(this.GuestLoginForm.controls.phone.value, 2)
    .subscribe(data => {
      if (data) {
        console.log("data",data)
        this.myRoute.navigate(["/Guest Page"])         
      }
      else { alert("הנתונים אינם תואמים, נסה שוב") }
      }
    );
  }

}