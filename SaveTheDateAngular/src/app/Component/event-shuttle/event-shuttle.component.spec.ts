import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EventShuttleComponent } from './event-shuttle.component';

describe('EventShuttleComponent', () => {
  let component: EventShuttleComponent;
  let fixture: ComponentFixture<EventShuttleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EventShuttleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EventShuttleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
