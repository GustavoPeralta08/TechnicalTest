import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { QBIDeveloperTestCoreModule } from '../../core/core.module';
import { QBIDeveloperTestTableComponent } from './components/table/table.component';
import { QBIDeveloperTestDeviceRoutingModule } from './device-routing.module';
import { QBIDeveloperTestDevicePage } from './pages/device/device.page';

@NgModule({
    declarations: [
        QBIDeveloperTestDevicePage,
        QBIDeveloperTestTableComponent,
    ],
    imports: [
        CommonModule,
        QBIDeveloperTestCoreModule,
        QBIDeveloperTestDeviceRoutingModule,
        

    ]
})
export class QBIDeveloperTestDeviceModule {

}
