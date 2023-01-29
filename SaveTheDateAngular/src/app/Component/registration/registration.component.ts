import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { User } from 'src/app/Classes/User';
import { EventService } from 'src/app/Service/event.service';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.scss']
})
export class RegistrationComponent implements OnInit {

  hide = true;
  registrationForm!: FormGroup;
  newUser: User = new User();
  userId!: number;
  passwordToPass!: number;
  showEvent: boolean = false;


  constructor(private EventSer: EventService, private myRoute: Router, public dialog: MatDialog) { }

  ngOnInit(): void {

    this.registrationForm = new FormGroup({
      name: new FormControl(0, [Validators.required]),
      phone: new FormControl(0, [Validators.required]),
      email: new FormControl("", [Validators.email]),
      password: new FormControl("", [Validators.required]),
    });
  }
  AddUser() {
    if (this.registrationForm.valid) {
      this.passwordToPass = this.registrationForm.controls.password.value
      this.showEvent = true;
      console.log(this.registrationForm)
      this.newUser = {
        Name: this.registrationForm.controls.name.value,
        Phone: this.registrationForm.controls.phone.value,
        Email: this.registrationForm.controls.email.value
      }
      this.EventSer.AddUser(this.newUser).subscribe((data) => {
        this.userId = data;

      })
    }
    else
      alert("לא תקין");
  }
}
