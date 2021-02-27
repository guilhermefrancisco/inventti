import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { Router } from '@angular/router';

import { Customer } from '../dto/customer';
import { updateCustomer } from '../dto/updateCustumer';
import { CustomerService } from '../services/customer.service';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {

  updateCustomer! : updateCustomer;

  displayedColumns : string[] = ['name', 'birthdate', 'delete', 'redirectUpdate'];
  columnsToDisplay: string[] = this.displayedColumns.slice();
  dataSource = new MatTableDataSource<Customer>();

  constructor(private service: CustomerService, private router: Router) { }

  ngOnInit(): void {
    this.getAllCustomers();
  }

  getAllCustomers(){
    return this.service.getAll()
      .subscribe(res => {
        this.dataSource.data = res;
      })
  }

  delete(id : number){
    return this.service.remove(id)
    .subscribe(res =>{
      this.getAllCustomers();
    })
  }

  redirectUpdate(id : number){
    this.router.navigate(['update', id]);
  }

}
