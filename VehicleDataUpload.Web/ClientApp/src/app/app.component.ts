import { Component } from '@angular/core';
import { ResponseResult } from './models/responseResult';
import { VehicleDataUploadService } from './services/vehicleDataUpload.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Vehicle Sales Data';
  centered = false;
  disabled = false;
  unbounded = false;
  radius: number;
  color: string;
  result: ResponseResult;
  dataReturned = false;
  errorMessage = '';


  constructor(private uploadService: VehicleDataUploadService) {    
  }

  public uploadFile = (event) => {
    const file = event.target.files[0];
    this.uploadService.upload(file)
      .subscribe(response => {
        this.result = response;
        this.dataReturned = response.responseCode === 0;
        this.errorMessage = response.responseCode === 0 ? '' : response.responseMessage;
      },err => {
        this.errorMessage = "Error connecting to API!";
        this.dataReturned = false;
      });
  }
}
