import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Table } from 'src/app/Classes/Table';
import { EventService } from 'src/app/Service/event.service';

@Component({
  selector: 'app-add-table',
  templateUrl: './add-table.component.html',
  styleUrls: ['./add-table.component.scss']
})
export class AddTableComponent implements OnInit {

  TableForm!: FormGroup;
  newTable:Table|null=null;

  constructor(private EventSer: EventService, private myRoute: Router) { }

  ngOnInit(): void {
    this.TableForm = new FormGroup({
      eventId: new FormControl(this.EventSer.IdentifiedEvent.Id),
      seatsNum:new FormControl(this.EventSer.numOfSeatsInTable),
      description:new FormControl("",[Validators.required])
    });
  }

  addTable(){
    if( this.TableForm.valid){
      console.log(this.TableForm)
      this.newTable={EventId:this.TableForm.controls.eventId.value,
                    SeatsNum:this.TableForm.controls.seatsNum.value,
                    Description:this.TableForm.controls.description.value}
  this.EventSer.AddTable(this.newTable).subscribe((data)=>{alert(data);console.log("data",data)})
  this.myRoute.navigate(["/Table Placement"]);
}
else
alert("לא תקין");
}


}



//   .subscribe(data => { this.ConfirmGuestsCount = data; console.log(data) },
//   error => { throw error },
//   () => console.log("finished"));
// }




