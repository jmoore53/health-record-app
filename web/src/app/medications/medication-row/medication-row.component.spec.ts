import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MedicationRowComponent } from './medication-row.component';

describe('MedicationRowComponent', () => {
  let component: MedicationRowComponent;
  let fixture: ComponentFixture<MedicationRowComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MedicationRowComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MedicationRowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
