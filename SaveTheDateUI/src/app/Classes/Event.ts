export class Event{
    constructor(
        public Id: number,
        public UserId: number,
        public EventType:number,
        public Date:Date,
        public Password:string,
        public Name:string,
        public Location: string,
        public Link: string,
        public  Text: string,
        public  Picture: string
    ){}
    };
