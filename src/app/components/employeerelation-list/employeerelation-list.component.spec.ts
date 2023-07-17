import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeeRelationListComponent } from './employeerelation-list.component';

describe('EmployeeRelationListComponent', () => {
  let component: EmployeeRelationListComponent;
  let fixture: ComponentFixture<EmployeeRelationListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [EmployeeRelationListComponent]
    });
    fixture = TestBed.createComponent(EmployeeRelationListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});