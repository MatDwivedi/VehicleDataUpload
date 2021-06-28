import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MostSoldVehicleComponent } from './most-sold-vehicle.component';

describe('BestSellingVehicleComponent', () => {
  let component: MostSoldVehicleComponent;
  let fixture: ComponentFixture<MostSoldVehicleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MostSoldVehicleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MostSoldVehicleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
