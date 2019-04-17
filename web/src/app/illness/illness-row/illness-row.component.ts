import { Component, OnInit, Input } from '@angular/core';
import { Illness } from '../illness'

@Component({
  selector: 'app-illness-row',
  templateUrl: './illness-row.component.html',
  styleUrls: ['./illness-row.component.css']
})
export class IllnessRowComponent implements OnInit {
  @Input() illness: any;
  constructor() { }

  ngOnInit() {
  }

}
