import { Component, OnInit } from '@angular/core';
import {HttpClient} from "@angular/common/http";

@Component({
  selector: 'app-list-colheitas',
  templateUrl: './list-colheitas.component.html',
  styleUrls: ['./list-colheitas.component.css']
})
export class ListColheitasComponent implements OnInit {

  constructor(private http: HttpClient) { }
  $httpdata;

  ngOnInit(): void {
    this.http.get("api/Colheita").subscribe((data) => this.displaydata(data));
  }

  displaydata(data) {
    this.$httpdata = data;
  }

}
