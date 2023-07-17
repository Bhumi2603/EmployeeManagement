import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddressTypeListComponent } from './address-type-list.component';

describe('AddressTypeListComponent', () => {
  let component: AddressTypeListComponent;
  let fixture: ComponentFixture<AddressTypeListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [AddressTypeListComponent]
    });
    fixture = TestBed.createComponent(AddressTypeListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
