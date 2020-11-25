import { Result } from '../models/result';
import { IAirplaneModel } from './../models/airplane.model';
import { IAirplaneDetailModel } from './../models/airplane-detail.model';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AirplaneService {
  resourceUrl = "/airplanes"
  constructor(private http: HttpClient) {
    this.resourceUrl = environment.api + this.resourceUrl
  }

  all(): Observable<IAirplaneDetailModel[]> {
    return this.http.get<IAirplaneDetailModel[]>(this.resourceUrl);
  }

  read(id: number): Observable<Result<IAirplaneDetailModel>> {
    return this.http.get<Result<IAirplaneDetailModel>>(`${this.resourceUrl}/${id}`);
  }

  add(model: IAirplaneModel): Observable<Result<number>> {
    return this.http.post<Result<number>>(this.resourceUrl, model);
  }

  delete(id: number): Observable<Result<number>> {
    return this.http.delete<Result<number>>(`${this.resourceUrl}/${id}`);
  }

  runMotor(id: number, motorId: number): Observable<Result<number>> {
    return this.http.patch<Result<number>>(`${this.resourceUrl}/${id}/run/${motorId}`, {});
  }
  
  stopMotor(id: number, motorId: number): Observable<Result<number>> {
    return this.http.patch<Result<number>>(`${this.resourceUrl}/${id}/stop/${motorId}`, {});
  }

}
