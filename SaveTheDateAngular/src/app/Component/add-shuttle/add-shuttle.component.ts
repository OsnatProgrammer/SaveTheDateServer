import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Bus } from 'src/app/Classes/Bus';
import { EventService } from 'src/app/Service/event.service';

@Component({
  selector: 'app-add-shuttle',
  templateUrl: './add-shuttle.component.html',
  styleUrls: ['./add-shuttle.component.scss']
})
export class AddShuttleComponent implements OnInit {


  BusForm!: FormGroup;
  newBus:Bus=new Bus();

  constructor(private EventSer: EventService, private myRoute: Router) { }

  ngOnInit(): void {

    this.BusForm = new FormGroup({
      eventId: new FormControl(this.EventSer.IdentifiedEvent.Id),
      seatsNum:new FormControl("",[Validators.required]),
      route:new FormControl("",[Validators.required]),
      departureTime:new FormControl("",[Validators.required]),

    });
  }
    //  Id?: number;
    //  EventId!: number;
    //  SeatsNum!:number;
    //  Route!:string;
    //  DepartureTime!: Date;
    
  addBus(){
    if( this.BusForm.valid){
      console.log(this.BusForm)
      this.newBus={EventId:this.BusForm.controls.eventId.value,
                    SeatsNum:this.BusForm.controls.seatsNum.value,
                    Route:this.BusForm.controls.route.value,
                    DepartureTime:this.BusForm.controls.departureTime.value,
                  }
    this.EventSer.AddBus(this.newBus).subscribe((data)=>{alert(data);console.log("data",data)})
    this.myRoute.navigate(["/Event Shuttle"]);
  }
    else{
       alert("לא תקין");
      }
    }
  }
