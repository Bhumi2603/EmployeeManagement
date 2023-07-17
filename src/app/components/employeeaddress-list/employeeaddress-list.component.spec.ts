import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeeaddressListComponent } from './employeeaddress-list.component';

describe('EmployeeaddressListComponent', () => {
  let component: EmployeeaddressListComponent;
  let fixture: ComponentFixture<EmployeeaddressListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [EmployeeaddressListComponent]
    });
    fixture = TestBed.createComponent(EmployeeaddressListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
