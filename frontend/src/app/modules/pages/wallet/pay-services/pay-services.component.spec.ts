import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PayServicesComponent } from './pay-services.component';

describe('PayServicesComponent', () => {
  let component: PayServicesComponent;
  let fixture: ComponentFixture<PayServicesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PayServicesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PayServicesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
