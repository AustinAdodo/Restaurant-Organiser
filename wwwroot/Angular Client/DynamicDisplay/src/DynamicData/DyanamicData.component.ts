import { Component, OnInit } from "@angular/core";
import { DynamicDataRetrievalService } from "./DynamicDataRetrieval.service";
import { IDynamicData } from "./IDynamicData.component";

@Component({selector :'DynamicData',
templateUrl:"DynamicDatatemplate.html",
providers:[DynamicDataRetrievalService]
}) 
export class DynamicDatacomponent implements OnInit{
    Statusmessage: string ="There seems to be a problem retrieving this resource...... now retrying";
    Heading:string ="Changes Made for this Employee";
    employee!: IDynamicData;
    constructor(private _employeeService:DynamicDataRetrievalService){}

    ngOnInit(): void {
        this._employeeService.getRetrievedData().subscribe({
            next:(data) =>  this.employee=data,
            error: () => { this.ErrorReturn()}  
        });
    }

    ErrorReturn():void {
         this.Statusmessage;
        //
    }
}
