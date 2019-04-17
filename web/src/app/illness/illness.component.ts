import { Component, OnInit } from '@angular/core';
import { Illness } from './illness'
import { IllnessService } from './illness.service'

@Component({
  selector: 'app-illness',
  templateUrl: './illness.component.html',
  styleUrls: ['./illness.component.css']
})
export class IllnessComponent implements OnInit {

  illness: Illness[]
  constructor(private illnessService: IllnessService) {}

  getIllness(){
    this.illnessService.getIllness().subscribe(illness => (this.illness = illness));
    console.log(this.illness);
  }

  ngOnInit() {
    this.getIllness();
  }
}
