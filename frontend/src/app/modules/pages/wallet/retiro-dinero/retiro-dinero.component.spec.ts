import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RetiroDineroComponent } from './retiro-dinero.component';

describe('RetiroDineroComponent', () => {
  let component: RetiroDineroComponent;
  let fixture: ComponentFixture<RetiroDineroComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RetiroDineroComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RetiroDineroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
