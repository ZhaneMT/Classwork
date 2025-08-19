import { Component } from '@angular/core';
import { GamblerDataLayout } from '../../interfaces/GamblerDataLayout';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-home-page',
  imports: [CommonModule],
  templateUrl: './home-page.html',
  styleUrl: './home-page.css'
})
export class HomePage {
//Temporary Test Data for the app.
theGamblers : GamblerDataLayout[] = [
{ id : 1, address : "Detroit" ,name : "Wolf", birthDate: "01/05/2005" , salary : 250 }
,{ id : 2, address : "Lansing" ,name : "Idk", birthDate: "01/02/2005" , salary : 150 }
]
}
