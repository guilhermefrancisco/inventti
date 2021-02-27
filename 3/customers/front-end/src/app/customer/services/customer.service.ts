import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { Observable } from 'rxjs';
import { catchError, map } from "rxjs/operators";

import { BaseService } from 'src/app/utils/base.service';
import { CreateCustomer } from '../dto/createCustomer';

@Injectable({
  providedIn: 'root'
})
export class CustomerService extends BaseService {

  urlCustomer! : string;

  constructor(private http: HttpClient) 
  {
    super();
    this.urlCustomer = this.UrlService + 'customer/';
  }

  add(customer : CreateCustomer): Observable<CreateCustomer>{
    return this.http.post<CreateCustomer>(this.urlCustomer + 'insert', customer, super.httpHeader)
    .pipe(
      catchError(super.serviceError))
  }

}
