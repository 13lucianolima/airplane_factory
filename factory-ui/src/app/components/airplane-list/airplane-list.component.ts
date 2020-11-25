import { AirplaneService } from './../../core/services/airplane.service';
import { Component, OnInit } from '@angular/core';
import { IAirplaneDetailModel } from 'src/app/core/models/airplane-detail.model';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';

@Component({
  selector: 'app-airplane-list',
  templateUrl: './airplane-list.component.html',
  styleUrls: ['./airplane-list.component.css']
})
export class AirplaneListComponent implements OnInit {
  airplanes: IAirplaneDetailModel[] = [];
  constructor(private airplaneService: AirplaneService) { }

  ngOnInit(): void {
    this.load();
  }

  load() {
    this.airplaneService.all().subscribe(response => {
      if (response) {
        this.airplanes = response;
      }
    });
  }

  delete(id: number) {
    this.airplaneService.delete(id).subscribe(response => {
      if (response.success) this.load();
    });
  }
}
