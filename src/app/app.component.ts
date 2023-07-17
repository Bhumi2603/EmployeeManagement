import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { EmployeeDetailsComponent } from './components/employee-details/employee-details.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  constructor(private _dialog: MatDialog) {}
  title = 'EmployeeManagement-UI';

  openAddEditEmpForm() {
    this._dialog.open(EmployeeDetailsComponent);
  }
}
