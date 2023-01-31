import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CharacterRegisterComponent } from './character-register.component';

describe('CharacterRegisterComponent', () => {
  let component: CharacterRegisterComponent;
  let fixture: ComponentFixture<CharacterRegisterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CharacterRegisterComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CharacterRegisterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
