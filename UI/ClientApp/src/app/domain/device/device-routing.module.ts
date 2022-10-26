import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { QBIDeveloperTestDevicePage } from './pages/device/device.page';

const routes: Routes = [
    { path: '', component: QBIDeveloperTestDevicePage }
];


@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class QBIDeveloperTestDeviceRoutingModule { }