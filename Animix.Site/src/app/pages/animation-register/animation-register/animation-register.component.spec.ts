import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AnimationRegisterComponent } from './animation-register.component';

describe('AnimationRegisterComponent', () => {
  let component: AnimationRegisterComponent;
  let fixture: ComponentFixture<AnimationRegisterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AnimationRegisterComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AnimationRegisterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
