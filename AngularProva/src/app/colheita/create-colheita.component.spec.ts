import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateColheitaComponent } from './create-colheita.component';

describe('CreateColheitaComponent', () => {
  let component: CreateColheitaComponent;
  let fixture: ComponentFixture<CreateColheitaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateColheitaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateColheitaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
