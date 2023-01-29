import { Gift } from "./Gift";
import { User } from "./User";
import { Event } from "./Event";

  export class EventGift{
      
       Id?: number;
       GiftId!: number;
       EventId!:number;
       UserId!:number;
       Status!:boolean;
       Blessing!: string;

       Event?:Event
       Gift?:Gift
       User?:User

      constructor(){}
    };
        
