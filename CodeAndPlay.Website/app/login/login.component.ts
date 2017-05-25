import { Component } from '@angular/core';

@Component({
    selector: 'login',
    templateUrl: './login.component.html'
})
export class LoginComponent {
    login(username: string, password: string): void {
        console.log(username, password);
    }
}