import { TestBed } from '@angular/core/testing';

import { ActividadUserService } from './actividad-user.service';

describe('ActividadUserService', () => {
  let service: ActividadUserService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ActividadUserService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
