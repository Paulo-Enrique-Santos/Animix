import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListItemGenericCardComponent } from './list-item-generic-card.component';

describe('ListItemGenericCardComponent', () => {
  let component: ListItemGenericCardComponent;
  let fixture: ComponentFixture<ListItemGenericCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListItemGenericCardComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListItemGenericCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
