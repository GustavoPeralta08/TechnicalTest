import { Component, Input } from '@angular/core';
import { Observable } from 'rxjs';
import { Device } from '../../models/device.model';

@Component({
    selector: 'qbi-developer-test-table',
    templateUrl: 'table.component.html',
    styleUrls: ['table.component.scss']
})
export class QBIDeveloperTestTableComponent {
    @Input() devices: Observable<Device[]> | undefined;
}

