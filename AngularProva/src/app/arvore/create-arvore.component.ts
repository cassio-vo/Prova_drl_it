import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-create-arvore',
  templateUrl: './create-arvore.component.html',
  styleUrls: ['./create-arvore.component.css']
})
export class CreateArvoreComponent implements OnInit {
  arvoreForm: FormGroup; 

  constructor() { }

  ngOnInit(): void {
    this.arvoreForm = new FormGroup({
      id: new FormControl(),
      descricao: new FormControl(),
      idade: new FormControl(),
      idEspecie: new FormControl(),
      idGrupo: new FormControl(),
    });
  }

  onSubmit(): void{
    console.log(this.arvoreForm.value);
  }

}
