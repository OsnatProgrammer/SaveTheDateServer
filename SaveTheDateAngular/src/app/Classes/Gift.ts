import { EventType } from "./EventType";
import { GiftCategory } from "./GiftCategory";

export class Gift{
        
     Id?: number;
     Name!:string;
     CategoryId!: number;
     EventTypeId!: number;

     GiftCategory?:GiftCategory
     EventType?:EventType
           
constructor(){}
};
    


