import { TestBed } from '@angular/core/testing';

import { IllnessService } from './illness.service';

describe('IllnessService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: IllnessService = TestBed.get(IllnessService);
    expect(service).toBeTruthy();
  });
});
