import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomePageComponent } from './Component/home-page/home-page.component';
import { LoginComponent } from './Component/login/login.component';
import { RegistrationComponent } from './Component/registration/registration.component';
import { EventPageComponent } from './Component/event-page/event-page.component';
import { AddGuestComponent } from './Component/add-guest/add-guest.component';
import { ShowArrivalConfirmationComponent } from './Component/show-arrival-confirmation/show-arrival-confirmation.component';
import { TablePlacementComponent } from './Component/table-placement/table-placement.component';
import { EventShuttleComponent } from './Component/event-shuttle/event-shuttle.component';
import { UpdateEventDetailsComponent } from './Component/update-event-details/update-event-details.component';
import { AddShuttleComponent } from './Component/add-shuttle/add-shuttle.component';
import { EventDetailsComponent } from './Component/event-details/event-details.component';
import { CreateEventComponent } from './Component/create-event/create-event.component';
import { MyGiftsComponent } from './Component/my-gifts/my-gifts.component';
import { GiftsListComponent } from './Component/gifts-list/gifts-list.component';
import { PageNotFoundComponent } from './Component/page-not-found/page-not-found.component';
import { MyEventLinkComponent } from './Component/my-event-link/my-event-link.component';
import { GuestLoginComponent } from './Component/guest-login/guest-login.component';
import { DialogBoxComponent } from './Component/dialog-box/dialog-box.component';
import { GuestPageComponent } from './Component/guest-page/guest-page.component';
import { RegisterToShuttleComponent } from './Component/register-to-shuttle/register-to-shuttle.component';
import { AddBlessingComponent } from './Component/add-blessing/add-blessing.component';
import { AddCashGiftComponent } from './Component/add-cash-gift/add-cash-gift.component';
import { AddGiftComponent } from './Component/add-gift/add-gift.component';
import { AppComponent } from './app.component';
import { NavComponent } from './Component/nav/nav.component';
import { AddTableComponent } from './Component/add-table/add-table.component';

const routes: Routes = [


  { path: "", component: HomePageComponent },
  {path: "App", component: AppComponent},
  {path: "Nav", component: NavComponent},

  {path: "Home", component: HomePageComponent},
  {path: "Login", component: LoginComponent},
  {path: "Register", component: RegistrationComponent },
  {path: "Add Guest", component: AddGuestComponent },
  {path: "Show Arrival", component: ShowArrivalConfirmationComponent },
  {path: "Table Placement", component: TablePlacementComponent },
  {path: "Add Table", component: AddTableComponent },
  {path: "Event Shuttle", component: EventShuttleComponent },
  {path: "Update EventDetails", component: UpdateEventDetailsComponent },
  {path: "Add Shuttle", component: AddShuttleComponent },
  {path: "Create Event", component: CreateEventComponent },
  {path: "Event Details", component: EventDetailsComponent },
  {path: "My Gifts",component: MyGiftsComponent },
  {path: "Gifts List", component: GiftsListComponent},
  {path: "MyEvent Link", component: MyEventLinkComponent},
  {path: "Event Page", component: EventPageComponent},
  
  {path: "Guest Login", component: GuestLoginComponent},
  {path: "Guest Page", component: GuestPageComponent},
  {path: "Add Gift", component: AddGiftComponent},
  {path: "Register To Shuttle", component: RegisterToShuttleComponent},
  {path: "Add Blessing", component: AddBlessingComponent},
  {path: "Add CashGift", component: AddCashGiftComponent},
  {path: "Dialog Box", component: DialogBoxComponent},

    //הגדרה לכל כתובת אחרת
    { path: "**", component: PageNotFoundComponent },

  // {path: "MoreDetails",component:MoreDetailsComponent,
  //   children: [
  //   {path: ":flightCode",component: MyFlightComponent}
  //     ]
  //    },
  //    { path: "MakeDeal", component: MakeDealComponent },
    
 
  // { path: "Nav", component: NavComponent },
  // { 
  //   path: "ManagerNavigate", component: ManagerNavigateComponent,
  //   children: [
  //     { path: "Add Flight", component: AddFlightComponent },
  //     { path: "Delete Flight", component: DeleteFlightComponent},
  //     { path: "Update Flight", component: UpdateFlightComponent},
  //     { path: "Show Clients Requests", component: ShowClientsRequestsComponent} 
  //     ] 
  // },

  // { path: "Footer Nav", component: FooterNavComponent  },
  // { path: "Leave Message", component: LeaveMessageComponent  },
]

@NgModule({
  imports: [RouterModule.forRoot(routes), CommonModule],
  declarations: []
})
export class myRoutingModule { }


@NgModule({
  imports: [RouterModule.forRoot(routes), CommonModule],
  exports: [RouterModule]
})
export class AppRoutingModule { }



