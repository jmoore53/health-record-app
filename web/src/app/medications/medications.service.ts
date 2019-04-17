import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { Medication } from './medication';

@Injectable({
  providedIn: 'root'
})
export class MedicationsService {
  private medicationsUri = 'http://localhost:5000/api/medications';
  private handleError<T>(operation = 'operation', result ?: T){
    return(error: any): Observable<T> => {
      console.error(`${operation} failed: ${error.message}`);
      return of(result as T);
    };
  }
  constructor(private http: HttpClient) { }

  getMedications(){
    return this.http.get<Medication[]>(this.medicationsUri).pipe(
      tap(_ => console.log('fetched meds')),
      catchError(this.handleError<Medication[]>('getMedication', []))
    );
  }

  newMedication(){
    return this.http.post<Medication[]>(this.medicationsUri, {id: 5, reason:"Cancer"}).pipe(
      tap(_ => console.log('fetched meds')),
      catchError(this.handleError<Medication[]>('getMedication', []))
    );
  }
}