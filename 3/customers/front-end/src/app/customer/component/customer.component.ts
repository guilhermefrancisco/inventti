import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';

import { Customer } from '../dto/customer';
import { CustomerService } from '../services/customer.service';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {

  displayedColumns : string[] = ['name', 'birthdate'];
  columnsToDisplay: string[] = this.displayedColumns.slice();
  dataSource = new MatTableDataSource<Customer>();

  constructor(private service: CustomerService) { }

  ngOnInit(): void {
    this.getAllCustomers();
  }

  getAllCustomers(){
    return this.service.getAll()
      .subscribe(res => {
        this.dataSource.data = res;
      })
  }

}
