import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { Appointment } from './appointment';

@Injectable({
  providedIn: 'root'
})
export class AppointmentsService {
  private appointmentsUri = 'http://localhost:5000/api/appointments';
  private handleError<T>(operation = 'operation', result ?: T){
    return(error: any): Observable<T> => {
      console.error(`${operation} failed: ${error.message}`);
      return of(result as T);
    };
  }
  constructor(private http: HttpClient) { }

  getAppointments(){
    return this.http.get<Appointment[]>(this.appointmentsUri).pipe(
      tap(_ => console.log('fetched appiontments')),
      catchError(this.handleError<Appointment[]>('getAppointments', []))
    );
  }

  newAppointment(){
    return this.http.post<Appointment[]>(this.appointmentsUri, {id: 5, reason:"Cancer"}).pipe(
      tap(_ => console.log('fetched appiontments')),
      catchError(this.handleError<Appointment[]>('getAppointments', []))
    );
  }
}
