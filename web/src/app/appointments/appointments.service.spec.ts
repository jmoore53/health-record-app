import { TestBed } from '@angular/core/testing';

import { AppointmentsService } from './appointments.service';

describe('AppointmentsService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: AppointmentsService = TestBed.get(AppointmentsService);
    expect(service).toBeTruthy();
  });
});
