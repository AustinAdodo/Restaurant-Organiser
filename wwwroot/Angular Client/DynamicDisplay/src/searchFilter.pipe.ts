import { PipeTransform ,Pipe} from "@angular/core";
// import { pipeline } from "stream";

@Pipe({name:'searchquery'})
//pipe-naming: [true, "camelCase", "app" ]  
export class SearchFilterPipe implements PipeTransform {
    transform(value: any, ...args: any[]) {
        throw new Error("Method not implemented.");
    }
}