import { Component, OnInit, Injectable } from '@angular/core';
import { Appointment } from './appointment';
import { AppointmentsService } from './appointments.service';

@Component({
  selector: 'app-appointments',
  templateUrl: './appointments.component.html',
  styleUrls: ['./appointments.component.css']
})
export class AppointmentsComponent implements OnInit {

  appointments: Appointment[]
  constructor(private appointmentService: AppointmentsService) {}

  getAppointments(){
    this.appointmentService.getAppointments().subscribe(appointments => (this.appointments = appointments));
    console.log(this.appointments);
  }

  ngOnInit() {
    this.getAppointments();
  }

}
