import { Component, OnInit } from '@angular/core';
import { ClientService} from './client.service';
import { ICity, IBus } from './Models';

@Component({
  selector: 'app-root',
providers: [ClientService]
})
export class AppComponent  {
   constructor() {}
   title = 'app';
}
