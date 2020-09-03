import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListGruposArvoreComponent } from './list-grupos-arvore.component';

describe('ListGruposArvoreComponent', () => {
  let component: ListGruposArvoreComponent;
  let fixture: ComponentFixture<ListGruposArvoreComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListGruposArvoreComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ListGruposArvoreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
