import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-create-especie',
  templateUrl: './create-especie.component.html',
  styleUrls: ['./create-especie.component.css']
})
export class CreateEspecieComponent implements OnInit {
  especieForm: FormGroup; 

  constructor() { }

  ngOnInit(): void {
    this.especieForm = new FormGroup({
      id: new FormControl(),
      descricao: new FormControl(Validators.required)
    });
  }

  onSubmit(): void{
    console.log(this.especieForm.value);
  }

}
