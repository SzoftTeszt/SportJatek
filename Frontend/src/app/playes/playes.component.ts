import { Component, OnDestroy, OnInit } from '@angular/core';
import { BaseService } from '../base.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-playes',
  templateUrl: './playes.component.html',
  styleUrls: ['./playes.component.css']
})
export class PlayesComponent implements OnDestroy, OnInit{
  players:any
  feliratkozas= new Subscription()
  constructor(private base:BaseService){
  
  }
  ngOnInit(): void {
    this.feliratkozas=this.base.getPlayes().subscribe(
      (res)=>{
        this.players=res
        for (let i = 0; i < this.players; i++) 
          this.players[i].visibleResult=false;         
      }
    )
  }

  ngOnDestroy(): void {
      this.feliratkozas.unsubscribe()
  }
}
