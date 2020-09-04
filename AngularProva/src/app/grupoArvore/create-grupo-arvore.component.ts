import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

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
      nome: new FormControl(Validators.required),
      descricao: new FormControl(Validators.required)
    });
  }

  onSubmit(): void{
    console.log(this.grupoArvoreForm.value);
  }

}
