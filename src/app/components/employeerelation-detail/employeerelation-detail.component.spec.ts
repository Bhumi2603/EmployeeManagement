import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeeRelationDetailComponent } from './employeerelation-detail.component';

describe('EmployeeRelationDetailComponent', () => {
  let component: EmployeeRelationDetailComponent;
  let fixture: ComponentFixture<EmployeeRelationDetailComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [EmployeeRelationDetailComponent]
    });
    fixture = TestBed.createComponent(EmployeeRelationDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
