import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PayServicesDetailComponent } from './pay-services-detail.component';

describe('PayServicesDetailComponent', () => {
  let component: PayServicesDetailComponent;
  let fixture: ComponentFixture<PayServicesDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PayServicesDetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PayServicesDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
