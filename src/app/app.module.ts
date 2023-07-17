import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeeDashboardComponent } from './components/employee-dashboard/employee-dashboard.component';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { EmployeeListComponent } from "./components/employee-list/employee-list.component";
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatIconModule} from '@angular/material/icon';
import {MatMenuModule} from '@angular/material/menu';
import {MatButtonModule} from '@angular/material/button';
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatListModule} from '@angular/material/list';
import {FlexLayoutModule} from '@angular/flex-layout';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { EmployeeDetailsComponent } from './components/employee-details/employee-details.component';
import {MatFormField, MatFormFieldModule} from '@angular/material/form-field';
import { MatDialogModule, MatDialogRef } from '@angular/material/dialog';
import {MatTableModule} from '@angular/material/table';
import { MatToolbar } from '@angular/material/toolbar';
import { MatTableDataSource } from "@angular/material/table";
import { MatPaginator, MatPaginatorModule } from "@angular/material/paginator";
import {MatSort, MatSortModule} from "@angular/material/sort";
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import { MatInputModule } from '@angular/material/input';
import { ApiService } from './services/api.service';




@NgModule({
    declarations: [
        AppComponent
    ],
    providers: [ApiService],
    bootstrap: [AppComponent],
    imports: [
        BrowserModule,
        HttpClientModule,
        EmployeeDashboardComponent,
        ReactiveFormsModule,
        AppRoutingModule,
        EmployeeListComponent,
        MatToolbarModule,
      MatIconModule,
    MatMenuModule,
    MatButtonModule,
    MatSidenavModule,
    MatListModule,
    FlexLayoutModule,
    BrowserAnimationsModule,
    EmployeeDetailsComponent,
    MatFormFieldModule,
    MatDialogModule,
    MatTableModule,
    MatToolbarModule,
    MatPaginatorModule,
    MatSortModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatInputModule,
    FormsModule,

        
    ]
    
})
export class AppModule { }
