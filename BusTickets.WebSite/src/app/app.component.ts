import { Component, OnInit } from '@angular/core';
import { ClientService} from './client.service';
import { ICity, IBus } from './Models';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent  {
   constructor() {}
   title = 'app';
}
