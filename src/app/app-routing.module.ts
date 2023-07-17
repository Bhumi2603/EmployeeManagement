import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { EmployeeListComponent } from './components/employee-list/employee-list.component';
import { EmployeeDetailsComponent } from './components/employee-details/employee-details.component';
import { AddressTypeListComponent } from './components/address-type-list/address-type-list.component';
import { AddressTypeDetailComponent } from './components/address-type-details/address-type-details.component';
import { EmployeeRelationDetailComponent } from './components/employeerelation-detail/employeerelation-detail.component';
import { EmployeeRelationListComponent } from './components/employeerelation-list/employeerelation-list.component';
import { EmployeeaddressDetailComponent } from './components/employeeaddress-detail/employeeaddress-detail.component';
import { EmployeeaddressListComponent } from './components/employeeaddress-list/employeeaddress-list.component';
import { EmployeefamilydetailListComponent } from './components/employeefamilydetail-list/employeefamilydetail-list.component';
import { EmployeefamliydetailDetailComponent } from './components/employeefamliydetail-detail/employeefamliydetail-detail.component';

const routes: Routes = [
  {path:'employee-list',component:EmployeeListComponent},

  {path:'employee-details',component:EmployeeDetailsComponent},
  {path:'employee-details/:id',component:EmployeeDetailsComponent},
  {path:'address-type-list',component:AddressTypeListComponent},
  {path:'address-type-details',component:AddressTypeDetailComponent},
  {path:'address-type-details/:id',component:AddressTypeDetailComponent},
  {path:'employeerelation-list',component:EmployeeRelationListComponent},
  {path:'employeerelation-detail',component:EmployeeRelationDetailComponent},
  {path:'employeerelation-detail/:id',component:EmployeeRelationDetailComponent},
  {path:'employeeaddress-list',component:EmployeeaddressListComponent},
  {path:'employeeaddress-detail',component:EmployeeaddressDetailComponent},
  {path:'employeeaddress-detail/:id',component:EmployeeaddressDetailComponent},
  {path:'employeefamilydetail-list',component:EmployeefamilydetailListComponent},
  {path:'employeefamilydetail-detail',component:EmployeefamliydetailDetailComponent},
  {path:'employeefamilydetail-detail/:id',component:EmployeefamliydetailDetailComponent}
  

];

@NgModule({
  imports: [RouterModule.forRoot(routes),
    BrowserModule,
    ReactiveFormsModule,FormsModule],
  exports: [RouterModule]
})
export class AppRoutingModule { }
