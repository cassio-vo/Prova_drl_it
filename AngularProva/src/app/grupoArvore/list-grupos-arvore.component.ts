import { Component, OnInit } from '@angular/core';
import {HttpClient} from "@angular/common/http";

@Component({
  selector: 'app-list-grupos-arvore',
  templateUrl: './list-grupos-arvore.component.html',
  styleUrls: ['./list-grupos-arvore.component.css']
})
export class ListGruposArvoreComponent implements OnInit {

  constructor(private http: HttpClient) { }
  $httpdata;

  ngOnInit(): void {
    this.http.get("api/GrupoArvore").subscribe((data) => this.displaydata(data));
  }

  displaydata(data) {
    this.$httpdata = data;
  }

}
