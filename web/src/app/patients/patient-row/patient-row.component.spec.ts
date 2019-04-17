import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PatientRowComponent } from './patient-row.component';

describe('PatientRowComponent', () => {
  let component: PatientRowComponent;
  let fixture: ComponentFixture<PatientRowComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PatientRowComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PatientRowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
