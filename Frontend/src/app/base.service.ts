import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BaseService {
  private playersSub= new BehaviorSubject(null)
  constructor(private http:HttpClient) {
    this.loadPlayers();
   }

  private loadPlayers(){
    this.http.get("http://172.16.16.136:5001/api/Players").subscribe(
      (res:any)=>this.playersSub.next(res)
    )
  }

  getPlayes(){
    return this.playersSub
  }

  deleteRound(round:any){
    this.http.delete("http://172.16.16.136:5001/api/Results/"+round.id).forEach(
      ()=>this.loadPlayers()
    )
  }

  createRound(round:any){
    this.http.post("http://172.16.16.136:5001/api/Results/",round).forEach(
      ()=>this.loadPlayers()
    )
  }

  updateRound(round:any){
    this.http.put("http://172.16.16.136:5001/api/Results/"+round.id, round).forEach(
      ()=>this.loadPlayers()
    )
  }
}
