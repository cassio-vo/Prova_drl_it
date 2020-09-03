import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListArvoresComponent } from './list-arvores.component';

describe('ListArvoresComponent', () => {
  let component: ListArvoresComponent;
  let fixture: ComponentFixture<ListArvoresComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListArvoresComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ListArvoresComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
