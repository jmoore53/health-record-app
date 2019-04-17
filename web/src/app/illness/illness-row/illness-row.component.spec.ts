import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { IllnessRowComponent } from './illness-row.component';

describe('IllnessRowComponent', () => {
  let component: IllnessRowComponent;
  let fixture: ComponentFixture<IllnessRowComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ IllnessRowComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(IllnessRowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
