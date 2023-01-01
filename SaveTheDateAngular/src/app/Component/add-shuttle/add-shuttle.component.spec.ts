import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddShuttleComponent } from './add-shuttle.component';

describe('AddShuttleComponent', () => {
  let component: AddShuttleComponent;
  let fixture: ComponentFixture<AddShuttleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddShuttleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddShuttleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
