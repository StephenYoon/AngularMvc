import { Component, OnInit } from '@angular/core';

import CarRecord from './shared/CarRecord';
import ApiService from './shared/api.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  carRecords: Array<CarRecord>;

  constructor(private apiService: ApiService) {
  }

  ngOnInit() {
    this.apiService.getAll().subscribe(data => {
      this.carRecords = data;
    });
  }
}
