import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import CarRecord from './CarRecord';

@Injectable()
export default class ApiService {
  public API = 'http://localhost:59676/api';
  public CAR_RECORDS_ENDPOINT = `${this.API}/carrecords`;

  constructor(private http: HttpClient) { }

  getAll(): Observable<Array<CarRecord>> {
    return this.http.get<Array<CarRecord>>(this.CAR_RECORDS_ENDPOINT);
  }
}
