import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GenericEditCardComponent } from './generic-edit-card.component';

describe('GenericEditCardComponent', () => {
  let component: GenericEditCardComponent;
  let fixture: ComponentFixture<GenericEditCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GenericEditCardComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GenericEditCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
