import { Component, OnInit, Input } from '@angular/core';
import { Appointment } from '../appointment'

@Component({
  selector: 'app-appointment-row',
  templateUrl: './appointment-row.component.html',
  styleUrls: ['./appointment-row.component.css']
})
export class AppointmentRowComponent implements OnInit {
  @Input() appointment: any;
  constructor() { }

  ngOnInit() {
  }

}
