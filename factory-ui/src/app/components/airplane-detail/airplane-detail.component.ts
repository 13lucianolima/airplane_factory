import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IAirplaneDetailModel } from 'src/app/core/models/airplane-detail.model';
import { AirplaneService } from 'src/app/core/services/airplane.service';

@Component({
  selector: 'app-airplane-detail',
  templateUrl: './airplane-detail.component.html',
  styleUrls: ['./airplane-detail.component.css']
})
export class AirplaneDetailComponent implements OnInit {
  id: number;
  airplane: IAirplaneDetailModel;
  constructor(private airplaneService: AirplaneService, private route: ActivatedRoute) {
    if (route.snapshot.paramMap.get("id")) this.id = Number(route.snapshot.paramMap.get("id"));
  }

  ngOnInit(): void {
    this.load();
  }

  load() {
    if (this.id) {
      this.airplaneService.read(this.id).subscribe(response => {
        if (response.success) {
          this.airplane = response.data;
        }
      });
    }
  }

  runMotor(motorId: number) {
    this.airplaneService.runMotor(this.id, motorId).subscribe(response => {
      if (response.success) this.load();
    });
  }

  stopMotor(motorId: number) {
    this.airplaneService.stopMotor(this.id, motorId).subscribe(response => {
      if (response.success) this.load();
    });
  }
}
