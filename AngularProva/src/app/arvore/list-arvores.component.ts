import { Component, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-list-arvores',
  templateUrl: './list-arvores.component.html',
  styleUrls: ['./list-arvores.component.css']
})
export class ListArvoresComponent implements OnInit {

  constructor(private http: HttpClient) { }
  $httpdata;

  ngOnInit(): void {
    this.http.get("api/Arvore").subscribe((data) => this.displaydata(data));
  }

  displaydata(data) {
    this.$httpdata = data;
  }

}
