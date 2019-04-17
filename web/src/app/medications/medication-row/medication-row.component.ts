import { Component, OnInit, Input } from '@angular/core';
import { Medication } from '../medication'


@Component({
  selector: 'app-medication-row',
  templateUrl: './medication-row.component.html',
  styleUrls: ['./medication-row.component.css']
})
export class MedicationRowComponent implements OnInit {
  @Input() medication: any;
  constructor() { }

  ngOnInit() {
  }

}
