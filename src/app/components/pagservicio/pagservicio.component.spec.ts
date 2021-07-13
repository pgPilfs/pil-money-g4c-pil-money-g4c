import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PagservicioComponent } from './pagservicio.component';

describe('PagservicioComponent', () => {
  let component: PagservicioComponent;
  let fixture: ComponentFixture<PagservicioComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PagservicioComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PagservicioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
