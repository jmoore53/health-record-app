import { Component, OnInit } from '@angular/core';
import { Doctor } from './doctor';
import { DoctorsService } from './doctors.service';

@Component({
  selector: 'app-doctors',
  templateUrl: './doctors.component.html',
  styleUrls: ['./doctors.component.css']
})
export class DoctorsComponent implements OnInit {

  doctors: Doctor[]
  constructor(private doctorService: DoctorsService) {}

  getDoctors(){
    this.doctorService.getDoctors().subscribe(doctors => (this.doctors = doctors));
    console.log(this.doctors);
  }

  ngOnInit() {
    this.getDoctors();
  }

}

