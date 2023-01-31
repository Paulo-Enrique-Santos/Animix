import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserExtractComponent } from './user-extract.component';

describe('UserExtractComponent', () => {
  let component: UserExtractComponent;
  let fixture: ComponentFixture<UserExtractComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserExtractComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UserExtractComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
