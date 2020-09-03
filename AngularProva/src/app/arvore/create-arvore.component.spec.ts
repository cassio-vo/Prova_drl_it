import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateArvoreComponent } from './create-arvore.component';

describe('CreateArvoreComponent', () => {
  let component: CreateArvoreComponent;
  let fixture: ComponentFixture<CreateArvoreComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateArvoreComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateArvoreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
