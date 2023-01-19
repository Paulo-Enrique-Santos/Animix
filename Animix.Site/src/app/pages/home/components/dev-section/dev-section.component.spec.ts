import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DevSectionComponent } from './dev-section.component';

describe('DevSectionComponent', () => {
  let component: DevSectionComponent;
  let fixture: ComponentFixture<DevSectionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DevSectionComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DevSectionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
