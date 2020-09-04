import { Component, OnInit } from '@angular/core';
import {HttpClient} from "@angular/common/http";

@Component({
  selector: 'app-list-especies',
  templateUrl: './list-especies.component.html',
  styleUrls: ['./list-especies.component.css']
})
export class ListEspeciesComponent implements OnInit {

  constructor(private http: HttpClient) { }
  $httpdata;

  ngOnInit(): void {    
    this.http.get("api/Especie").subscribe((data) => this.displaydata(data));
  }

  displaydata(data) {
    this.$httpdata = data;
  }

}
