import { TestBed } from '@angular/core/testing';

import { MedicationsService } from './medications.service';

describe('MedicationsService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: MedicationsService = TestBed.get(MedicationsService);
    expect(service).toBeTruthy();
  });
});
