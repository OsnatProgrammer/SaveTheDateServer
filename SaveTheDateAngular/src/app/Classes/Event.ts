import { EventType } from "./EventType";
import { User } from "./User";

export class Event {
    Id?: number;
    UserId!: number;
    EventType!: number;
    Date!: Date;
    Password!: string;
    Name!: string;
    Location!: string;
    Link?: string;
    Text?: string;
    Picture?: string;

    // EventType?:EventType;
    User?:User;

    constructor() { }
}
