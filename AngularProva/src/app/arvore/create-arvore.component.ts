import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

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
      descricao: new FormControl(Validators.required),
      idade: new FormControl([Validators.required,Validators.pattern("^[0-9]{1,5}$")]),
      idEspecie: new FormControl(Validators.required),
      idGrupo: new FormControl(Validators.required),
    });
  }

  onSubmit(): void{
    console.log(this.arvoreForm.value);
  }

}
