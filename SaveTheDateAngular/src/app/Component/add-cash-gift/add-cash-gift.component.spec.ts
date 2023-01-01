import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddCashGiftComponent } from './add-cash-gift.component';

describe('AddCashGiftComponent', () => {
  let component: AddCashGiftComponent;
  let fixture: ComponentFixture<AddCashGiftComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddCashGiftComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddCashGiftComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
