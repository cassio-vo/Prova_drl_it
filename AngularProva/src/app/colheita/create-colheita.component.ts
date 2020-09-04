import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

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
      informacoes: new FormControl('',Validators.required),
      dataColheita: new FormControl('',Validators.required),
      pesoBruto: new FormControl(0,[Validators.required, Validators.pattern("^[0-9]\d*(\.\d+)?$")]),
      idArvore: new FormControl(1,Validators.required),
    });
  }

  onSubmit(): void{
    console.log(this.colheitaForm.value);
  }

}
