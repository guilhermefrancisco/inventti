import { HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { throwError } from "rxjs";

@Injectable({
  providedIn: 'root'
})
export abstract class BaseService {

  protected UrlService: string = "https://localhost:5001/api/";
  
  httpHeader = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
    })
  }

  protected serviceError(error: Response | any){
    console.error(error);
    return throwError(error);
}
}
