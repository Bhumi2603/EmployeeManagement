import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ApiService } from 'src/app/services/api.service';
import { ActivatedRoute, Router } from '@angular/router';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-employee-dashboard',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './employee-dashboard.component.html',
  styleUrls: ['./employee-dashboard.component.scss']
})
export class EmployeeDashboardComponent implements OnInit{
 
  employees:any[] | undefined;

  constructor () {}

  
  ngOnInit(): void {
  //   console.log(this.router.snapshot.params['id'])
  //   this.apiService.getAllEmployee(this.router.snapshot.params['id'])
  //   .subscribe((result) => result)
  //     console.log("resulr",result)
  //     this.employeeForm = new FormGroup({
  //       id: new FormControl(result['id']),
  //       firstName

  //     })

    

   
  }
  
}
