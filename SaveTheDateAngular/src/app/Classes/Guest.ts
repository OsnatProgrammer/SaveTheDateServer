import { Bus } from "./Bus";
import { User } from "./User";
import { Event } from "./Event";
import { EventGift } from "./EventGift";
import { Table } from "./Table";


export class Guest{
 
         Id?: number;
         UserId!: number|undefined;
         EventId!:number|undefined;
         ArrivalConf!:boolean;
         TableNum?: number;
         BusId?: number;
         GiftId?: number;

         Bus?:Bus;
         Event?:Event;
         EventGift?:EventGift
         Table?:Table
         User?:User;
      
         constructor(){}
    };


// export class Guest{
//     constructor(
//         public Id: number,
//         public UserId: number,
//         public EventId:number,
//         public ArrivalConf:boolean,

//         public TableNum?: number,
//         public  BusId?: number,
//         public  GiftId?: number
//     ){}
//     };




    
       