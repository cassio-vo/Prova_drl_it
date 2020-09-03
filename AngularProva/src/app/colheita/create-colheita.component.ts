import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-create-colheita',
  templateUrl: './create-colheita.component.html',
  styleUrls: ['./create-colheita.component.css']
})
export class CreateColheitaComponent implements OnInit {
  colheitaForm: FormGroup; 

  constructor() { }

  ngOnInit(): void {
    this.colheitaForm = new FormGroup({
      id: new FormControl(),
      informacoes: new FormControl(),
      dataColheita: new FormControl(),
      pesoBruto: new FormControl(),
      idArvore: new FormControl(),
    });
  }

  onSubmit(): void{
    console.log(this.colheitaForm.value);
  }

}
