import { Injectable } from '@angular/core';
import { ResponseResult } from '../models/responseResult';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class VehicleDataUploadService {

  constructor(private http: HttpClient) { }

  upload = (file: File) => {
    const fileToUpload = <File>file;
    const formData = new FormData();
    formData.append('file', fileToUpload);
    return this.http.post<ResponseResult>('/api/upload', formData);
  }
}
