import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';

import { CreateCustomer } from '../../dto/createCustomer';
import { CustomerService } from '../../services/customer.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  customerForm! : FormGroup;
  createCustomer! : CreateCustomer;

  error: string = '';

  constructor(private fb: FormBuilder, private service: CustomerService, private router: Router) {  }

  ngOnInit(): void {
    let name = new FormControl();
    let birthdate = new FormControl();

    this.customerForm = this.fb.group({
      name : name,
      birthdate : birthdate
    });
  }

  addCustomer(){
    this.createCustomer = Object.assign({}, this.createCustomer, this.customerForm.value);

    this.service.add(this.createCustomer)
      .subscribe(
        result => this.success(result),
        fail => this.fail(fail)
      );
  }
  
  success(response: any): void {
    this.customerForm.reset();
    this.error = '';

    this.router.navigate(['/customers'])
  }

  fail(fail: any) {
    this.error = JSON.stringify(fail.error);
  }

}
