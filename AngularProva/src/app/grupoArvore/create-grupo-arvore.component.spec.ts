import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateGrupoArvoreComponent } from './create-grupo-arvore.component';

describe('CreateGrupoArvoreComponent', () => {
  let component: CreateGrupoArvoreComponent;
  let fixture: ComponentFixture<CreateGrupoArvoreComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateGrupoArvoreComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateGrupoArvoreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
