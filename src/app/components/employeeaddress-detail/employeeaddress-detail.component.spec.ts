import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeeaddressDetailComponent } from './employeeaddress-detail.component';

describe('EmployeeaddressDetailComponent', () => {
  let component: EmployeeaddressDetailComponent;
  let fixture: ComponentFixture<EmployeeaddressDetailComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [EmployeeaddressDetailComponent]
    });
    fixture = TestBed.createComponent(EmployeeaddressDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
