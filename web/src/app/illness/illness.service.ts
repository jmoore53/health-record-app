import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { Illness } from './illness';

@Injectable({
  providedIn: 'root'
})
export class IllnessService {
  private illnessUri = 'http://localhost:5000/api/illnesses';
  private handleError<T>(operation = 'operation', result ?: T){
    return(error: any): Observable<T> => {
      console.error(`${operation} failed: ${error.message}`);
      return of(result as T);
    };
  }
  constructor(private http: HttpClient) { }

  getIllness(){
    return this.http.get<Illness[]>(this.illnessUri).pipe(
      tap(_ => console.log('fetched illness')),
      catchError(this.handleError<Illness[]>('getIllness', []))
    );
  }

  newIllness(){
    return this.http.post<Illness[]>(this.illnessUri, {id: 5, reason:"Cancer"}).pipe(
      tap(_ => console.log('fetched illness')),
      catchError(this.handleError<Illness[]>('getIllness', []))
    );
  }
}