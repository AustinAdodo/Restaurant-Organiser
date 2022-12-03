import { ErrorHandler, Injectable } from '@angular/core';
import { IDynamicData } from './IDynamicData.component';
import {HttpClient } from '@angular/common/http';
import {Observable } from 'rxjs';

@Injectable()
export class DynamicDataRetrievalService 
{
    ReturnMessage!: ErrorHandler;
    ApiUrl="/Employees/RetrieveCurrentEditedEmployee";
    constructor(private _http: HttpClient ){ }
    getRetrievedData(): Observable<IDynamicData>
    { 
        return  this._http.get<IDynamicData>(this.ApiUrl);
    }
}
  