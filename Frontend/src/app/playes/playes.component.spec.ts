import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PlayesComponent } from './playes.component';

describe('PlayesComponent', () => {
  let component: PlayesComponent;
  let fixture: ComponentFixture<PlayesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PlayesComponent]
    });
    fixture = TestBed.createComponent(PlayesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
