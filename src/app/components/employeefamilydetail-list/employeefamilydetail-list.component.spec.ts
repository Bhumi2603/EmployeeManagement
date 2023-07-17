import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeefamilydetailListComponent } from './employeefamilydetail-list.component';

describe('EmployeefamilydetailListComponent', () => {
  let component: EmployeefamilydetailListComponent;
  let fixture: ComponentFixture<EmployeefamilydetailListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [EmployeefamilydetailListComponent]
    });
    fixture = TestBed.createComponent(EmployeefamilydetailListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
