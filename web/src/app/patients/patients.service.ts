import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { Patient } from './patient';

@Injectable({
  providedIn: 'root'
})
export class PatientsService {
  private patientsUri = 'http://localhost:5000/api/patients';
  private handleError<T>(operation = 'operation', result ?: T){
    return(error: any): Observable<T> => {
      console.error(`${operation} failed: ${error.message}`);
      return of(result as T);
    };
  }
  constructor(private http: HttpClient) { }

  getPatients(){
    return this.http.get<Patient[]>(this.patientsUri).pipe(
      tap(_ => console.log('fetched Patients')),
      catchError(this.handleError<Patient[]>('getPatients', []))
    );
  }

  newPatient(){
    return this.http.post<Patient[]>(this.patientsUri, {id: 5, reason:"Cancer"}).pipe(
      tap(_ => console.log('fetched Patients')),
      catchError(this.handleError<Patient[]>('getPatient', []))
    );
  }
}