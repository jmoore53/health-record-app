import { Component, OnInit } from '@angular/core';
import { Patient } from './patient';
import { PatientsService } from './patients.service';

@Component({
  selector: 'app-patients',
  templateUrl: './patients.component.html',
  styleUrls: ['./patients.component.css']
})
export class PatientsComponent implements OnInit {

  patients: Patient[]
  constructor(private patientService: PatientsService) {}

  getPatients(){
    this.patientService.getPatients().subscribe(patients => (this.patients = patients));
    console.log(this.patients);
  }

  ngOnInit() {
    this.getPatients();
  }

}
