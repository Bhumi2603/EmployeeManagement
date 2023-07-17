import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
//import { environment } from 'src/environments/environment.development';
@Injectable({
  providedIn: 'root'
})
export class ApiService {
  baseApiUrl:string ="https://localhost:7258"
  constructor(private http: HttpClient) { }

  getAllEmployee():Observable<any>{
    return this.http.get<any>(this.baseApiUrl + '/api/Employee/GetAllEmployee/GetAll')
  }

  getEmployee(id: string): Observable<any> {
    return this.http.get<any>(this.baseApiUrl + '/api/Employee/GetEmployee?Id=' + id)
  }


  addEmployee(addEmployeeRequest: any): Observable<any> {
    addEmployeeRequest.id = '00000000-0000-0000-0000-000000000000';
    return this.http.post<any>(this.baseApiUrl + '/api/Employee/AddEmployee', addEmployeeRequest)
  }

  updateEmployee(id: string, Employee: any): Observable<any> {
    return this.http.put<any>(this.baseApiUrl + '/api/Employee/UpdateEmployee?id=' + id, Employee)
  }
  deleteEmployee(id: string): Observable<any> {
    return this.http.delete<any>(this.baseApiUrl + '/api/Employee/DeleteEmployee?Id=' + id)
  }

  //Employeeaddress
  getAllEmployeeaddress(): Observable<any> {
    return this.http.get<any>(this.baseApiUrl + '/api/EmployeeAddress/GetAll/GetAll')
  }

  getEmployeeaddress(id: string): Observable<any> {
    return this.http.get<any>(this.baseApiUrl + '/api/EmployeeAddress/Get?id=' + id)
  }


  addEmployeeaddress(addEmployeeaddressRequest: any): Observable<any> {
    addEmployeeaddressRequest.id = '00000000-0000-0000-0000-000000000000';
    return this.http.post<any>(this.baseApiUrl + '/api/EmployeeAddress/AddEmployeeAddress', addEmployeeaddressRequest)
  }

  updateEmployeeaddress(id: string, Employeeaddress: any): Observable<any> {
    return this.http.put<any>(this.baseApiUrl + '/api/EmployeeAddress/UpdateEmployeeAddress' , Employeeaddress)
  }
  deleteEmployeeaddress(id: string): Observable<any> {
    return this.http.delete<any>(this.baseApiUrl + '/api/EmployeeAddress/DeleteEmployeeAddress?id=' + id)
  }

  //AddressType
  getAllAddressType(): Observable<any> {
    return this.http.get<any>(this.baseApiUrl + '/api/AddressType/GetAllAddressType')
  }

  getAddressType(id: string): Observable<any> {
    return this.http.get<any>(this.baseApiUrl + '/api/AddressType/GetAddressTypeById?Id=' + id)
  }


  addAddressType(addAddressTypeRequest: any): Observable<any> {
    addAddressTypeRequest.id = '00000000-0000-0000-0000-000000000000';
    return this.http.post<any>(this.baseApiUrl + '/api/AddressType/AddAddressType', addAddressTypeRequest)
  }

  updateAddressType(id: string, AddressType: any): Observable<any> {
    return this.http.put<any>(this.baseApiUrl + '/api/AddressType/UpdateAddressType' , AddressType)
  }
  deleteAddressType(id: string): Observable<any> {
    return this.http.delete<any>(this.baseApiUrl + '/api/AddressType/DeleteAddressType?Id=' + id)
  }

  //EmployeeFamilyDetail
  getAllEmployeeFamilyDetail(): Observable<any> {
    return this.http.get<any>(this.baseApiUrl + '/api/EmployeeFamilyDetail/GetAllEmployeeFamilyDetail')
  }

  getEmployeeFamilyDetail(id: string): Observable<any> {
    return this.http.get<any>(this.baseApiUrl + '/api/EmployeeFamilyDetail/GetEmployeeFamilyDetail?Id=' + id)
  }


  addEmployeeFamilyDetail(addEmployeeFamilyDetailRequest: any): Observable<any> {
    addEmployeeFamilyDetailRequest.id = '00000000-0000-0000-0000-000000000000';
    return this.http.post<any>(this.baseApiUrl + '/api/EmployeeFamilyDetail/AddEmployeeFamilyDetail', addEmployeeFamilyDetailRequest)
  }

  updateEmployeeFamilyDetail(id: string, EmployeeFamilyDetail: any): Observable<any> {
    return this.http.put<any>(this.baseApiUrl + '/api/EmployeeFamilyDetail/UpdateEmployeeFamilyDetail', EmployeeFamilyDetail)
  }
  deleteEmployeeFamilyDetail(id: string): Observable<any> {
    return this.http.delete<any>(this.baseApiUrl + '/api/EmployeeFamilyDetail/DeleteEmployeeFamilyDetail?id=' + id)
  }

  //EmployeeRelation
  getAllEmployeeRelation(): Observable<any> {
    return this.http.get<any>(this.baseApiUrl + '/api/EmployeeRelation/GetAllEmployeeRelation')
  }

  getEmployeeRelation(id: string): Observable<any> {
    return this.http.get<any>(this.baseApiUrl + '/api/EmployeeRelation/Get?id' + id)
  }


  addEmployeeRelation(addEmployeeRelationRequest: any): Observable<any> {
    addEmployeeRelationRequest.id = '00000000-0000-0000-0000-000000000000';
    return this.http.post<any>(this.baseApiUrl + '/api/EmployeeRelation/AddEmployeeRelation', addEmployeeRelationRequest)
  }

  updateEmployeeRelation(id: string, EmployeeRelation: any): Observable<any> {
    return this.http.put<any>(this.baseApiUrl + '/api/EmployeeRelation/UpdateEmployeeRelation', EmployeeRelation)
  }
  deleteEmployeeRelation(id: string): Observable<any> {
    return this.http.delete<any>(this.baseApiUrl + '/api/EmployeeRelation/DeleteEmployeeRelatio?id=' + id)
  }
}


