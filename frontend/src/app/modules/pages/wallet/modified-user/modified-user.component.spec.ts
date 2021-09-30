import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModifiedUserComponent } from './modified-user.component';

describe('ModifiedUserComponent', () => {
  let component: ModifiedUserComponent;
  let fixture: ComponentFixture<ModifiedUserComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ModifiedUserComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ModifiedUserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
