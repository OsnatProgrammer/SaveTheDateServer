import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
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
import { MyEventLinkComponent } from './Component/my-event-link/my-event-link.component';
import { GuestLoginComponent } from './Component/guest-login/guest-login.component';
import { GuestPageComponent } from './Component/guest-page/guest-page.component';
import { AddGiftComponent } from './Component/add-gift/add-gift.component';
import { RegisterToShuttleComponent } from './Component/register-to-shuttle/register-to-shuttle.component';
import { AddBlessingComponent } from './Component/add-blessing/add-blessing.component';
import { AddCashGiftComponent } from './Component/add-cash-gift/add-cash-gift.component';
import { GuestService } from './Service/guest.service';
import { EventService } from './Service/event.service';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
//import {MatInputModule} from '@angular/material/input';
import {MatAutocompleteModule} from '@angular/material/autocomplete';
import {MatBadgeModule} from '@angular/material/badge';
import {MatBottomSheetModule} from '@angular/material/bottom-sheet';
import {MatButtonModule} from '@angular/material/button';
import {MatButtonToggleModule} from '@angular/material/button-toggle';
import {MatCardModule} from '@angular/material/card';
import {MatChipsModule} from '@angular/material/chips';
import {MatStepperModule} from '@angular/material/stepper';
import {MatDialogModule} from '@angular/material/dialog';
import {MatDividerModule} from '@angular/material/divider';
import {MatExpansionModule} from '@angular/material/expansion';
import {MatListModule} from '@angular/material/list';
import {MatMenuModule} from '@angular/material/menu';
import {MatPaginatorModule} from '@angular/material/paginator';
import {MatProgressBarModule} from '@angular/material/progress-bar';
import {MatProgressSpinnerModule} from '@angular/material/progress-spinner';
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatSlideToggleModule} from '@angular/material/slide-toggle';
import {MatSnackBarModule} from '@angular/material/snack-bar';
import {MatSortModule} from '@angular/material/sort';
import {MatTabsModule} from '@angular/material/tabs';
import {MatTooltipModule} from '@angular/material/tooltip';

import {MatTreeModule} from '@angular/material/tree';
import {MatToolbarModule} from '@angular/material/toolbar';
import { MatDatepickerInput } from '@angular/material/datepicker';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSliderModule } from '@angular/material/slider';
import { MatFormField, MatFormFieldControl, MatFormFieldModule } from '@angular/material/form-field';
import { MatSelectModule } from '@angular/material/select';
import { MatInputModule } from '@angular/material/input';
import { MatNativeDateModule, MatRippleModule } from '@angular/material/core';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { formatDate } from '@angular/common';
import { DataSource} from '@angular/cdk/table' 
import { CdkTableModule} from '@angular/cdk/table' 
import { MatTableModule } from '@angular/material/table';
import { Component, ViewChild } from '@angular/core';
import { MatTable } from '@angular/material/table';
import { MatDialog } from '@angular/material/dialog';
import { MatRadioModule} from '@angular/material/radio';
import { MatIconModule} from '@angular/material/icon';
import { MatGridListModule} from '@angular/material/grid-list';
import { MatCheckboxModule} from '@angular/material/checkbox';

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    LoginComponent,
    RegistrationComponent,
    EventPageComponent,
    AddGuestComponent,
    ShowArrivalConfirmationComponent,
    TablePlacementComponent,
    EventShuttleComponent,
    UpdateEventDetailsComponent,
    AddShuttleComponent,
    EventDetailsComponent,
    CreateEventComponent,
    MyGiftsComponent,
    GiftsListComponent,
    MyEventLinkComponent,
    GuestLoginComponent,
    GuestPageComponent,
    AddGiftComponent,
    RegisterToShuttleComponent,
    AddBlessingComponent,
    AddCashGiftComponent,

    //,
    //MatInputModule,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    MatSliderModule,
    MatNativeDateModule,
    MatInputModule,
    MatFormFieldModule,
    MatTableModule,
   // CdkTableModule,
    MatRadioModule,
    MatGridListModule,
    MatIconModule,
   // BrowserModule,
   // ReactiveFormsModule,
    MatCheckboxModule,
   // HttpClientModule,
   // FlexLayoutModule,
   // CommonModule,
    MatToolbarModule,
   //     //NgxCcModule
   // // FormGroupModule,
   // /*FormControl,
   // FormArray*/
   // A11yModule,
   // CdkAccordionModule,
   // ClipboardModule,
   // CdkStepperModule,
   // CdkTableModule,
   // CdkTreeModule,
   // DragDropModule,
    MatAutocompleteModule,
    MatBadgeModule,
    MatBottomSheetModule,
    MatButtonModule,
    MatButtonToggleModule,
    MatCardModule,
    MatCheckboxModule,
    MatChipsModule,
    MatStepperModule,
    MatDatepickerModule,
    MatDialogModule,
    MatDividerModule,
    MatExpansionModule,
    MatGridListModule,
    MatIconModule,
    MatInputModule,
    MatListModule,
    MatMenuModule,
    MatNativeDateModule,
    MatPaginatorModule,
    MatProgressBarModule,
    MatProgressSpinnerModule,
    MatRadioModule,
    MatRippleModule,
    MatSelectModule,
    MatSidenavModule,
    MatSliderModule,
    MatSlideToggleModule,
    MatSnackBarModule,
    MatSortModule,
    MatTableModule,
    MatTabsModule,
    MatToolbarModule,
    MatTooltipModule,
    MatTreeModule,
   // OverlayModule,
   // PortalModule,
   // ScrollingModule,
    MatButtonModule,
    
    
  ],
  providers: [EventService,GuestService],
  bootstrap: [AppComponent]
})
export class AppModule { }
