import { Component, Inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatFormField, MatFormFieldModule } from '@angular/material/form-field';
import { MatRadioModule } from "@angular/material/radio";
import { MatSelectModule } from '@angular/material/select';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatInputModule } from '@angular/material/input';
import { MatNativeDateModule } from '@angular/material/core';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule, MatDialog, MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { ApiService } from 'src/app/services/api.service';
import { FormControl, FormGroup, FormsModule, Validators } from '@angular/forms';
import { ActivatedRoute, Route, Router } from '@angular/router';
import { ReactiveFormsModule } from "@angular/forms";
// import { ToastrService } from 'ngx-toastr';
@Component({
  selector: 'app-employeefamliydetail-detail',
  standalone: true,
  imports: [CommonModule
  ,MatFormFieldModule,
  MatRadioModule,
  MatSelectModule,
  MatDatepickerModule,
  MatInputModule,
  MatNativeDateModule,
  MatButtonModule,
  MatDialogModule,
  ReactiveFormsModule],
  templateUrl: './employeefamliydetail-detail.component.html',
  styleUrls: ['./employeefamliydetail-detail.component.scss']
})
export class EmployeefamliydetailDetailComponent {
  employee:any[]=[]
  employeeRelation:any[]=[]

  employeefamilydetailForm = new FormGroup({


    id: new FormControl(null),
    employeeId: new FormControl(null),
    firstName: new FormControl(null, Validators.required),
    middleName: new FormControl(null, Validators.required),
    lastName: new FormControl(null, Validators.required),
    dob: new FormControl(' ', Validators.required),
    relationId: new FormControl(null),


  })


  constructor(private apiService: ApiService,
    private router: Router,
    private route: ActivatedRoute,
    private dialogRef: MatDialogRef<EmployeefamliydetailDetailComponent>,
    //  private toaster:ToastrService,
    @Inject(MAT_DIALOG_DATA) public data: any) { }
  //public employeeForm:FormGroup;



  ngOnInit() {
    this.employeefamilydetailForm.patchValue(this.data);
    this.apiService.getAllEmployee()
        .subscribe({
          next:result =>{
            this.employee=result;
          }
        })

        this.apiService.getAllEmployeeRelation()
        .subscribe({
          next:result =>{
            this.employeeRelation=result;
          }
        })
  }

  // public hasError = (controlName: string, errorName: string) =>{
  //   return this.employeeForm.controls[controlName].hasError(errorName);
  // }


  onSubmit() {
    if (this.data) {
      console.log(this.employeefamilydetailForm.value)
      this.apiService.updateEmployeeFamilyDetail(this.data.id, this.employeefamilydetailForm.value)
        .subscribe({
          next: (result) => {
            alert("user Updated")
            this.dialogRef.close(true)
          }
        })
    }
    else {
      console.log(this.employeefamilydetailForm.value)
      this.apiService.addEmployeeFamilyDetail(this.employeefamilydetailForm.value)
        .subscribe({
          next: (result) => {
            alert("user Added Successfully")
            this.dialogRef.close(true)
          }
        })
    }
  }

  updateEmployeeFamilyDetail(employeefamilydetailForm: any) {
    this.apiService.updateEmployeeFamilyDetail(this.route.snapshot.params['id'], this.employeefamilydetailForm.value)
      .subscribe({
        next: (response) => {
          this.router.navigate(['employeefamilydetail-list'])
        }
      });
  }


}


