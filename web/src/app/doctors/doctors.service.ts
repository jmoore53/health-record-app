import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { Doctor } from './doctor';

@Injectable({
  providedIn: 'root'
})
export class DoctorsService {
  private doctorsUri = 'http://localhost:5000/api/doctors';
  private handleError<T>(operation = 'operation', result ?: T){
    return(error: any): Observable<T> => {
      console.error(`${operation} failed: ${error.message}`);
      return of(result as T);
    };
  }
  constructor(private http: HttpClient) { }

  getDoctors(){
    return this.http.get<Doctor[]>(this.doctorsUri).pipe(
      tap(_ => console.log('fetched appiontments')),
      catchError(this.handleError<Doctor[]>('getDoctors', []))
    );
  }

  newDoctor(){
    return this.http.post<Doctor[]>(this.doctorsUri, {id: 5, reason:"Cancer"}).pipe(
      tap(_ => console.log('fetched appiontments')),
      catchError(this.handleError<Doctor[]>('getDoctor', []))
    );
  }
}