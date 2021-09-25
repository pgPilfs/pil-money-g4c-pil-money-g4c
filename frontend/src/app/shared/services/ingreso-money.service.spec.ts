import { TestBed } from '@angular/core/testing';

import { IngresoMoneyService } from './ingreso-money.service';

describe('IngresoMoneyService', () => {
  let service: IngresoMoneyService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(IngresoMoneyService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
