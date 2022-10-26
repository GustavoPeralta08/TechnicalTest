import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Device } from '../../models/device.model';
import { QBIDeveloperTestDeviceService } from '../../services/device.service';

@Component({
    selector: 'qbi-developer-test-device-page',
    templateUrl: 'device.page.html',
    styleUrls: ['device.page.scss']
})
export class QBIDeveloperTestDevicePage implements OnInit {
    device$: Observable<Device[]> | undefined;

    constructor(
        private readonly QBIDeveloperTestDeviceService: QBIDeveloperTestDeviceService
    ) { }

    ngOnInit() {
        this.device$ = this.QBIDeveloperTestDeviceService.getDevices();
    }
}