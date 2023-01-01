import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowArrivalConfirmationComponent } from './show-arrival-confirmation.component';

describe('ShowArrivalConfirmationComponent', () => {
  let component: ShowArrivalConfirmationComponent;
  let fixture: ComponentFixture<ShowArrivalConfirmationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowArrivalConfirmationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowArrivalConfirmationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
