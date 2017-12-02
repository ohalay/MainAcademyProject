import { Injectable } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IJourney, ICity, IBus, IBusStop, ITicket } from './Models';
import { Observable } from 'rxjs/Observable';


@Injectable()
export class ClientService {

  constructor(private http: HttpClient) { }

  getTrips(arrivalStation: number, departueStation: number): Observable<IJourney> {
    return this.http.get<IJourney>('http://localhost:55194/api/v1/trips');
  }
  getCity(startwithcity: string): Observable<ICity> {
    return this.http.get<ICity>('http://localhost:55194/api/v1/cities/{startwithcity}');
  }
  getBus(id: number): Observable<IBus> {
    return this.http.get<IBus>('http://localhost:55194/api/v1/buses/{id}');
  }
  getBusSop(id: number): Observable<IBusStop> {
    return this.http.get<IBusStop>('http://localhost:55194/api/v1/busStops/{id}');
  }
  getTicket(journeyid: number): Observable<ITicket> {
    return this.http.get<ITicket>('http://localhost:55194/api/v1/busStops/{journeyid}');
  }
}
