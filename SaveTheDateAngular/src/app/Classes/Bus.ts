import { Event } from "./Event";

export class Bus{

     Id?: number;
     EventId!: number;
     SeatsNum!:number;
     Route!:string;
     DepartureTime!: Date;
     
     Event?:Event;

    constructor(){}
    };


