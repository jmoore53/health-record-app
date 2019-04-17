import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { PatientsComponent } from './patients/patients.component';
import { DoctorsComponent } from './doctors/doctors.component';
import { AppointmentsComponent } from './appointments/appointments.component';
import { IllnessComponent } from './illness/illness.component';
import { MedicationsComponent } from './medications/medications.component';
import { AppointmentRowComponent } from './appointments/appointment-row/appointment-row.component';
import { DoctorRowComponent } from './doctors/doctor-row/doctor-row.component';
import { PatientRowComponent } from './patients/patient-row/patient-row.component';
import { IllnessRowComponent } from './illness/illness-row/illness-row.component';
import { MedicationRowComponent } from './medications/medication-row/medication-row.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    NavBarComponent,
    PatientsComponent,
    DoctorsComponent,
    AppointmentsComponent,
    IllnessComponent,
    MedicationsComponent,
    AppointmentRowComponent,
    DoctorRowComponent,
    PatientRowComponent,
    IllnessRowComponent,
    MedicationRowComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
