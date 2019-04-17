import { Component, OnInit, Input } from '@angular/core';
import { Doctor } from '../doctor'


@Component({
  selector: 'app-doctor-row',
  templateUrl: './doctor-row.component.html',
  styleUrls: ['./doctor-row.component.css']
})
export class DoctorRowComponent implements OnInit {
  @Input() doctor: any;
  constructor() { }

  ngOnInit() {
  }

}
