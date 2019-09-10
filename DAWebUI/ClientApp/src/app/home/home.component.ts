import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css']
})
export class HomeComponent {
    registerMode = false;

    constructor(private http: HttpClient) {

    }

    ngOnInit() {

    }

    registerToggle() {
        this.registerMode = true;
    }

    cancelRegisterMode(registerMode: boolean) {
        this.registerMode = registerMode;
    }
}
