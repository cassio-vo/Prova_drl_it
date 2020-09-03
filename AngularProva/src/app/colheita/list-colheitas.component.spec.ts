import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListColheitasComponent } from './list-colheitas.component';

describe('ListColheitasComponent', () => {
  let component: ListColheitasComponent;
  let fixture: ComponentFixture<ListColheitasComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListColheitasComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ListColheitasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
