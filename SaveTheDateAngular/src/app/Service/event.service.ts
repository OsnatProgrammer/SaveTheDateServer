import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, observable } from 'rxjs'
import { Route } from '@angular/router';
import { Event } from '../Classes/Event';
import { Gift } from '../Classes/Gift';
import { MatDialog } from '@angular/material/dialog';


@Injectable({
  providedIn: 'root'
})
export class EventService {
  //localhost - הכתובת שהסוואגר רץ עליו
  //האם יש אפשרות ליצור משתנה לקונטרולר??

  readonly APIUrlEvent = "https://localhost:44304/api/Event"
  readonly APIUrlEventGift = "https://localhost:44304/api/EventGift"
  readonly APIUrlGift = "https://localhost:44304/api/Gift"
  readonly APIUrlGuest = "https://localhost:44304/api/Guest"
  readonly APIUrlTable = "https://localhost:44304/api/Table"
  readonly APIUrlBus = "https://localhost:44304/api/Bus"

  IdentifiedEvent:Event=new Event()
  
  constructor(private http: HttpClient,public dialog: MatDialog) { }

  //Event

  GetEventById(val: any): Observable<any> {
    return this.http.get(`${this.APIUrlEvent}/GetEventById/${val}`);
  }

  AddEvent(val: Event) {    
    return this.http.post(this.APIUrlEvent + '/AddEvent', val);
  }

  Login(phone:any,password:any): Observable<any> {
    return this.http.post(this.APIUrlEvent + '/Login',phone, password );
  }

  UpdateEvent(val: any) {
    return this.http.put(this.APIUrlEvent + '/UpdateEvent', val);
  }

  //Event Gift
  GetAGiftFromGuest(val1: number, val2: number, val3: string) {
    return this.http.get<any>(`${this.APIUrlEventGift}/GetAGiftFromGuest/${val1}`);
  }

  GetAllGivenGifts(eventId: number) {
    return this.http.get<any>(this.APIUrlEventGift + '/GetAllGivenGifts');
  }

  GetAllUnGivenGifts(eventId: number) {
    return this.http.get<any>(this.APIUrlEventGift + '/GetAllUnGivenGifts');
  }

  //Gift

  GetGiftsByEventType(val: any): Observable<Gift[]> {
    return this.http.get<Gift[]>(`${this.APIUrlGift}/GetGiftsByEventType/${val}`);
  }

  GetAllGift(): Observable<any> {
    return this.http.get(`${this.APIUrlGift}/GetAllGift`);
  }

  //Guest
  AddGuest(val: any) {
    return this.http.post(this.APIUrlGuest + '/AddGuest', val);
  }

  DeleteGuest(val:any){
    return this.http.delete(`${this.APIUrlGuest}/DeleteGuest/${val}`);
  }

  GetAllConfirmGuests(val: any): Observable<any> {
    return this.http.get(`${this.APIUrlGuest}/GetGiftsByEventType/${val}`);
  }

  GetAllInvitedGuests(val: any): Observable<any> {
    return this.http.get(`${this.APIUrlGuest}/GetAllInvitedGuests/${val}`);
  }

  GetAllUnConfirmGuests(val: any): Observable<any> {
    return this.http.get(`${this.APIUrlGuest}/GetAllUnConfirmGuests/${val}`);
  }

  GetGuestByPhone(phone: string, eventId: number) {
    return this.http.get<any>(this.APIUrlGuest + '/GetAGiftFromGuest');
  }

//Table
AddTable(val: any) {
    return this.http.post(this.APIUrlTable + '/AddTable', val);
  }

  DeleteTable(val:any){
    return this.http.delete(`${this.APIUrlTable}/DeleteTable/${val}`);
  }

  GetAllTablesOfEvent(val: any): Observable<any> {
    return this.http.get(`${this.APIUrlTable}/GetAllTablesOfEvent/${val}`);
  }

  GetNotTakePlaceGuests(val: any): Observable<any> {
    return this.http.get(`${this.APIUrlTable}/GetNotTakePlaceGuests/${val}`);
  }

  GetTakePlaceGuests(val: any): Observable<any> {
    return this.http.get(`${this.APIUrlTable}/GetTakePlaceGuests/${val}`);
  }

  GuestsInTable(val: any): Observable<any> {
    return this.http.get(`${this.APIUrlTable}/GuestsInTable/${val}`);
  }

//  UpdateGuestToTable(guestId: number,tableNum:number) {
//    return this.http.put(this.APIUrlEvent + '/UpdateGuestToTable', guestId ,tableNum);
//  }

//Bus
  AddBus(val: any) {
    return this.http.post(this.APIUrlBus + '/AddBus', val);
  }

  DeleteBus(val:any){
    return this.http.delete(`${this.APIUrlBus}/DeleteBus/${val}`);
  }

  GetAllBus(): Observable<any> {
    return this.http.get(`${this.APIUrlBus}/GetAllBus/`);
  }

  GetAllBusesOfEvent(val: any): Observable<any> {
    return this.http.get(`${this.APIUrlBus}/GetAllBusesOfEvent/${val}`);
  }

  GetSumPersonInBus(val: any){
    return this.http.get(`${this.APIUrlBus}/GetSumPersonInBus`,val);
  }

  EmptySeatsOnTheBus(val: any) {
    return this.http.get(`${this.APIUrlBus}/EmptySeatsOnTheBus`,val);
  }

//  UpdateGuestToBus(guestId: number, busId:number) {
//    return this.http.put(`${this.APIUrlBus}/UpdateGuestToBus/"${guestId}","${busId}"`);
//  }
//
//  UpdateRoute(busId: number, RouteToUpdate:string) {
//    return this.http.put(`${this.APIUrlBus}/UpdateRoute/['MyCompB', {id: "busId", id2: "RouteToUpdate"}])
//
//);
//  }




  





  // getAllPersonalInfo():Observable<any[]>{
  //   return this.http.get<any>(this.APIUrl+'/GetAllCovid19InfoPerPerson' );
  // }



  // updateCovid19InfoPerPerson(val:any){
  //   return this.http.put(this.APIUrl+'/UpdateCovid19InfoPerPerson',val);
  // }

  // deletePersonalInfo(val:any){
  //   return this.http.delete(`${this.APIUrl}/DeleteCovid19InfoPerPerson/${val}`);
  // }
}
