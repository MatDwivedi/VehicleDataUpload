import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-most-sold-vehicle',
  templateUrl: './most-sold-vehicle.component.html',
  styleUrls: ['./most-sold-vehicle.component.css']
})
export class MostSoldVehicleComponent implements OnInit {

  @Input() mostSoldVehicle: string;
  constructor() { }

  ngOnInit(): void {
  }
}
