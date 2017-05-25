import { Component } from '@angular/core';

@Component({
    selector: 'app-symposium',
    templateUrl: './app.component.html'
})
export class AppComponent {
    public isCollapsed: boolean = true;
    public name: string = 'Angular';
}
