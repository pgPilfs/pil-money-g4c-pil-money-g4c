import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComppagservicioComponent } from './comppagservicio.component';

describe('ComppagservicioComponent', () => {
  let component: ComppagservicioComponent;
  let fixture: ComponentFixture<ComppagservicioComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ComppagservicioComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ComppagservicioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
