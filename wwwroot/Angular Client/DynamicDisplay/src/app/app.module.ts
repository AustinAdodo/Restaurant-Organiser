import { NgModule } from '@angular/core';
// import { RouterModule,Routes } from '@angular/router'; 
import { BrowserModule } from '@angular/platform-browser';
import { DynamicDataRetrievalService } from 'src/DynamicData/DynamicDataRetrieval.service';
import { HttpClientModule } from '@angular/common/http';
import { DynamicDatacomponent } from 'src/DynamicData/DyanamicData.component';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ItemsDisplaycomponentComponent } from './items-displaycomponent.component';
import { SearchFilterPipe } from 'src/searchFilter.pipe';

// const dynamicRoutes: Routes=[
//   { path :'../../Home/Activity', component:DynamicDatacomponent } 
//  ];

@NgModule({
  declarations: [
    AppComponent, DynamicDatacomponent, ItemsDisplaycomponentComponent,
    SearchFilterPipe
  ],

  imports: [
    BrowserModule,
    AppRoutingModule, HttpClientModule
    //  ,RouterModule.forRoot(dynamicRoutes) 
  ],

  providers: [DynamicDataRetrievalService],
  bootstrap: [AppComponent]
})
export class AppModule { }





// do not use pipes to filter and sort data as it will significantly reduce performance.
//move the filtering sorting logic to the code itself.//
///to retain query params use the query params handling directive queryParamsHandling:preserve or merge
/// to see the sequence of navigation events triggared during navigation you need to enable tracing 
/// by passing an object  as a second parameter to the forRoot method.
//canActiviate guard check if a user can proceed to a particuar route or resource. e.g when Authenticating.
////or if a resource exists.
///Example of Route Guards are canActiviate and CanDeavtivate Guards.