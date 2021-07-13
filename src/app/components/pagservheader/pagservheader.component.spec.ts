import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PagservheaderComponent } from './pagservheader.component';

describe('PagservheaderComponent', () => {
  let component: PagservheaderComponent;
  let fixture: ComponentFixture<PagservheaderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PagservheaderComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PagservheaderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
