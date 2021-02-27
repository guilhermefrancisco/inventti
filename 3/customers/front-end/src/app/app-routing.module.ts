import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { CustomerComponent } from './customer/component/customer.component';
import { RegisterComponent } from './customer/component/register/register.component';
import { UpdateComponent } from './customer/component/update/update.component';
import { HomeComponent } from './navigation/home/home.component';

const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'customers', component: CustomerComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'update/:id', component: UpdateComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
