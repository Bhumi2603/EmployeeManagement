import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddressTypeDetailsComponent } from './address-type-details.component';

describe('AddressTypeDetailsComponent', () => {
  let component: AddressTypeDetailsComponent;
  let fixture: ComponentFixture<AddressTypeDetailsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [AddressTypeDetailsComponent]
    });
    fixture = TestBed.createComponent(AddressTypeDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
