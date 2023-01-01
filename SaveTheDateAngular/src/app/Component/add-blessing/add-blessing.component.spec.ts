import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddBlessingComponent } from './add-blessing.component';

describe('AddBlessingComponent', () => {
  let component: AddBlessingComponent;
  let fixture: ComponentFixture<AddBlessingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddBlessingComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddBlessingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
