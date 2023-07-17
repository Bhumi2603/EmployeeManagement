import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeefamliydetailDetailComponent } from './employeefamliydetail-detail.component';

describe('EmployeefamliydetailDetailComponent', () => {
  let component: EmployeefamliydetailDetailComponent;
  let fixture: ComponentFixture<EmployeefamliydetailDetailComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [EmployeefamliydetailDetailComponent]
    });
    fixture = TestBed.createComponent(EmployeefamliydetailDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
