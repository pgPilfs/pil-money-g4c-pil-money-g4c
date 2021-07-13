import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DescpagservicioComponent } from './descpagservicio.component';

describe('DescpagservicioComponent', () => {
  let component: DescpagservicioComponent;
  let fixture: ComponentFixture<DescpagservicioComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DescpagservicioComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DescpagservicioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
