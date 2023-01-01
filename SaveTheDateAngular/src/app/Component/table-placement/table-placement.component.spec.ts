import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TablePlacementComponent } from './table-placement.component';

describe('TablePlacementComponent', () => {
  let component: TablePlacementComponent;
  let fixture: ComponentFixture<TablePlacementComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TablePlacementComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TablePlacementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
