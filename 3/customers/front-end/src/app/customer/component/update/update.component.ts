import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { updateCustomer } from '../../dto/updateCustumer';

@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.css']
})
export class UpdateComponent implements OnInit {

  id! : number;
  updateCustomer! : updateCustomer;

  constructor(private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe(params => {
      this.id = Number(params.get('id'));
    });

    this.getById(this.id)
  }

  getById(id : number){
    console.log(id);
  }

}
