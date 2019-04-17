import { Component, OnInit, Input } from '@angular/core';
import { Patient } from '../patient'


@Component({
  selector: 'app-patient-row',
  templateUrl: './patient-row.component.html',
  styleUrls: ['./patient-row.component.css']
})
export class PatientRowComponent implements OnInit {
  @Input() patient: any;
  constructor() { }

  ngOnInit() {
  }

}
