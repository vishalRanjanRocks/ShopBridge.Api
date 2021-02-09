import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { ShopBridge } from '../shopbridge-form/shopBridge-model';

@Injectable({
  providedIn: 'root'
})
export class ShopbridgeService {

  private REST_API_SERVER = "http://localhost:8095/";

  constructor(private httpClient: HttpClient) {
    // httpOptions = {
    //   headers: new HttpHeaders({
    //     'Content-Type': 'application/json'
    //   })
    // }
  }

  public sendGetRequest() {
    return this.httpClient.get(this.REST_API_SERVER + 'api/shopbridge/get/data');
  }

  public postData(shopbridge: ShopBridge): Observable<any> {
    let requestUrl = this.REST_API_SERVER + "api/shopbridge/save/data"
    let requestdata: any = {
      Id: shopbridge.id,
      Name: shopbridge.name,
      Price: shopbridge.price,
      Description: shopbridge.description
    }
    // return this.httpClient.post<any>(requestUrl, requestdata);
    const requestOptions: Object = {
      /* other options here */
      responseType: 'text'
    }
    return this.httpClient.post<string>(requestUrl, requestdata, requestOptions).pipe(
      map((result: any) => {
        if (result && result.hasOwnProperty('status') && result['status'] === 200) return result['body'];
        else return null;
      })
    );
  }

  public updateData(shopbridge: ShopBridge) {
    let requestUrl = this.REST_API_SERVER + "api/shopbridge/update/data"
    let requestdata: any = {
      Id: shopbridge.id,
      Name: shopbridge.name,
      Price: shopbridge.price,
      Description: shopbridge.description
    }
    const requestOptions: Object = {
      /* other options here */
      responseType: 'text'
    }
    return this.httpClient.post<any>(requestUrl, requestdata, requestOptions).pipe(
      map((result: any) => {
        if (result && result.hasOwnProperty('status') && result['status'] === 200) return result['body'];
        else return null;
      })
    );
  }

  public deleteData(shopbridge: ShopBridge) {
    let requestUrl = this.REST_API_SERVER + "api/shopbridge/delete/data";
    let requestdata: any = {
      Id: shopbridge.id,
      Name: shopbridge.name,
      Price: shopbridge.price,
      Description: shopbridge.description
    }
    const requestOptions: Object = {
      /* other options here */
      responseType: 'text'
    }
    return this.httpClient.post(requestUrl, requestdata, requestOptions).pipe(
      map((result: any) => {
        if (result && result.hasOwnProperty('status') && result['status'] === 200) return result['body'];
        else return null;
      })
    );
  }
}
