import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DoctorRowComponent } from './doctor-row.component';

describe('DoctorRowComponent', () => {
  let component: DoctorRowComponent;
  let fixture: ComponentFixture<DoctorRowComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DoctorRowComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DoctorRowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
