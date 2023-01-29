import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Guest } from 'src/app/Classes/Guest';
import { User } from 'src/app/Classes/User';
import { EventService } from 'src/app/Service/event.service';

@Component({
  selector: 'app-add-guest',
  templateUrl: './add-guest.component.html',
  styleUrls: ['./add-guest.component.scss']
})
export class AddGuestComponent implements OnInit {

  UserForm!: FormGroup;
  newUser:User =new User();
  newGuest: Guest =new Guest();
  
  constructor(private EventSer: EventService, private myRoute: Router) { }

  ngOnInit(): void {
    this.UserForm = new FormGroup({
      name: new FormControl("",[Validators.required]),
      phone:new FormControl("",[Validators.required]),
      email:new FormControl("",[Validators.required])
    });
  }

  AddUser(){
    if( this.UserForm.valid){
      console.log(this.UserForm)
      this.newUser = {Name:this.UserForm.controls.name.value,Phone:this.UserForm.controls.phone.value,
         Email:this.UserForm.controls.email.value}
      this.EventSer.AddUser(this.newUser).subscribe((data)=>{this.AddGuest(data),alert(data);})
    }
    else
    alert("לא תקין");
  }

AddGuest(userId:number){
      this.newGuest={UserId:userId,EventId:this.EventSer.IdentifiedEvent.Id,
        ArrivalConf:false}
      this.EventSer.AddGuest(this.newGuest).subscribe((data)=>{alert(data);console.log("data",data)})
      }
}
        // Id?: number;
        //  UserId!: number;
        //  EventId!:number;
        //  ArrivalConf!:boolean;

        //  TableNum?: number;
        //  BusId?: number;
        //  GiftId?: number