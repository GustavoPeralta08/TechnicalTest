import {Pipe, PipeTransform} from '@angular/core';

@Pipe({
    name:'customName'
})
export class CustomName implements PipeTransform{
    transform(value: string, ...args: any[]) {

        var str = value.replace(/\d+/g, '')
        return str.replace(/ /gi, "_").toUpperCase();
    }
}