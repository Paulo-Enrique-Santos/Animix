import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CharacterSectionComponent } from './character-section.component';

describe('CharacterSectionComponent', () => {
  let component: CharacterSectionComponent;
  let fixture: ComponentFixture<CharacterSectionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CharacterSectionComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CharacterSectionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
