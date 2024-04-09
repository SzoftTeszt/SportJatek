import { Component, Input } from '@angular/core';
import { BaseService } from '../base.service';

@Component({
  selector: 'app-results',
  templateUrl: './results.component.html',
  styleUrls: ['./results.component.css']
})
export class ResultsComponent {

  @Input() results:any
  @Input() playerId:any
  newRound:any={}

  oszlopok=["round1","round2","round3","round4", "totalRounds"]
  constructor(private base:BaseService){}

  deleteRound(round:any){
    this.base.deleteRound(round)
  }
  createRound(){
    this.newRound.playerId=this.playerId;
    this.base.createRound(this.newRound)
  }
  updateRound(round:any){
    this.base.updateRound(round)
  }
}
