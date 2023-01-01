import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegisterToShuttleComponent } from './register-to-shuttle.component';

describe('RegisterToShuttleComponent', () => {
  let component: RegisterToShuttleComponent;
  let fixture: ComponentFixture<RegisterToShuttleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RegisterToShuttleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RegisterToShuttleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
