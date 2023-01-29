import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.scss']
})
export class RegistrationComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {

    this.eventForm = new FormGroup({
      userId: new FormControl(0, [Validators.required]),
      eventType: new FormControl(1, [Validators.required, Validators.min(1), Validators.max(3)]),
      date: new FormControl(new Date(), [Validators.required]),
      password: new FormControl("", [Validators.required]),
      name: new FormControl("", [Validators.required]),
      location: new FormControl("", [Validators.required]),
      link: new FormControl("", [Validators.required]),
      text: new FormControl("", [Validators.required]),
      picture: new FormControl("", [Validators.required]),
  }

}
