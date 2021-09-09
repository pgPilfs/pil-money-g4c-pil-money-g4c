import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IngresoMoneyComponent } from './ingreso-money.component';

describe('IngresoMoneyComponent', () => {
  let component: IngresoMoneyComponent;
  let fixture: ComponentFixture<IngresoMoneyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IngresoMoneyComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(IngresoMoneyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
