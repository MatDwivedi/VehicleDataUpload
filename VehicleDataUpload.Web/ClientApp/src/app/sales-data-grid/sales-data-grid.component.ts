import { Component, Input, OnInit } from '@angular/core';
import { SalesRecord } from '../models/salesRecord';

@Component({
  selector: 'app-sales-data-grid',
  templateUrl: './sales-data-grid.component.html',
  styleUrls: ['./sales-data-grid.component.css']
})
export class SalesDataGridComponent implements OnInit {
  @Input() salesRecords: SalesRecord[];

  dataSource: SalesRecord[] = [];
  displayedColumns: string[] = ['dealNumber', 'customerName', 'dealershipName', 'vehicle', 'price', 'date'];
  constructor() { }

  ngOnInit(): void {
  }
}
