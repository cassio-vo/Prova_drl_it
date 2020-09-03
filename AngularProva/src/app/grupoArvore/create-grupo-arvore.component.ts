import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-create-grupo-arvore',
  templateUrl: './create-grupo-arvore.component.html',
  styleUrls: ['./create-grupo-arvore.component.css']
})
export class CreateGrupoArvoreComponent implements OnInit {
  grupoArvoreForm: FormGroup; 

  constructor() { }

  ngOnInit(): void {
    this.grupoArvoreForm = new FormGroup({
      id: new FormControl(),
      nome: new FormControl(),
      descricao: new FormControl()
    });
  }

  onSubmit(): void{
    console.log(this.grupoArvoreForm.value);
  }

}
