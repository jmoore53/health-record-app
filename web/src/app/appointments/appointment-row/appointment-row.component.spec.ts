import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AppointmentRowComponent } from './appointment-row.component';

describe('AppointmentRowComponent', () => {
  let component: AppointmentRowComponent;
  let fixture: ComponentFixture<AppointmentRowComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AppointmentRowComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AppointmentRowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
