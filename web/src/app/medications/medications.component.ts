import { Component, OnInit } from '@angular/core';
import { Medication } from './medication';
import { MedicationsService } from './medications.service';

@Component({
  selector: 'app-medications',
  templateUrl: './medications.component.html',
  styleUrls: ['./medications.component.css']
})
export class MedicationsComponent implements OnInit {

  medications: Medication[]
  constructor(private medicationService: MedicationsService) {}

  getMedications(){
    this.medicationService.getMedications().subscribe(meds => (this.medications = meds));
    console.log(this.medications);
  }

  ngOnInit() {
    this.getMedications();
  }

}

