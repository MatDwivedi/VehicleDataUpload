import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SalesDataGridComponent } from './sales-data-grid.component';

describe('SalesDataGridComponent', () => {
  let component: SalesDataGridComponent;
  let fixture: ComponentFixture<SalesDataGridComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [SalesDataGridComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SalesDataGridComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
