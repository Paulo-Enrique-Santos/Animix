import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SkySectionComponent } from './sky-section.component';

describe('SkySectionComponent', () => {
  let component: SkySectionComponent;
  let fixture: ComponentFixture<SkySectionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SkySectionComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SkySectionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
