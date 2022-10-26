import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { useMock } from '../../../core/decorators/use-mock.decorator';
import { QBIDeveloperTestAPIBase } from '../../../core/services/api.base';
import { Device } from '../models/device.model';
import { environment } from '../../../../environments/environment'

@Injectable({
    providedIn: 'root'
})
export class QBIDeveloperTestDeviceService extends QBIDeveloperTestAPIBase {
    protected controller: string = '/Device';

    constructor(
        protected override readonly httpClient: HttpClient
    ) {
        super(httpClient);
    }

    getDevices() : Observable<Device[]>{
        return this.httpClient.get<Device[]>(environment.apiUrl + this.controller);
      }
}