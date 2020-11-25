import { AirplaneService } from './../../core/services/airplane.service';
import { EnumMotorType } from './../../core/models/enums/enum-motor-type';
import { EnumAirplaneType } from './../../core/models/enums/enum-airplane-type';
import { ISelectModel } from './../../core/models/select.model';
import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-new-airplane',
  templateUrl: './new-airplane.component.html',
  styleUrls: ['./new-airplane.component.css']
})
export class NewAirplaneComponent implements OnInit {
  airplaneTypes: ISelectModel[] = [];
  motorTypes: ISelectModel[] = [];
  errors: string[] = [];
  form: FormGroup;
  constructor(private fb: FormBuilder, private airplaneService: AirplaneService, private router: Router) {
    this.form = fb.group({
      airplaneType: [null, Validators.required],
      motorQuantity: [null, Validators.required],
      motors: fb.array([])
    });
  }

  ngOnInit(): void {
    this.getAirplaneTypes();
    this.getMotorsTypes();
  }

  getAirplaneTypes() {
    this.airplaneTypes = [
      {
        label: 'selecione..',
        value: null,
      },
      {
        label: 'Motor',
        value: EnumAirplaneType.engine,
      },
      {
        label: 'turbina',
        value: EnumAirplaneType.Turbine,
      },
    ];
  }

  getMotorsTypes() {
    this.motorTypes = [
      {
        label: 'selecione..',
        value: null,
      },
      {
        label: 'Motor',
        value: EnumMotorType.engine,
      },
      {
        label: 'turbina',
        value: EnumMotorType.Turbine,
      },
    ];
  }


  newMotor() {
    const newMotor = this.fb.group({
      motorType: [null, Validators.required]
    });
    this.motors.push(newMotor);
  }

  save() {
    if (this.form.valid) {
      const formValue = this.form.value;
      this.airplaneService.add(formValue).subscribe(response => {
        if (!response.success) {
          this.errors = response.errors;
        } else {
          this.errors = [];
          this.router.navigate(['']);
        }
      });
    } else {
      this.form.markAllAsTouched();
    }
  }

  get motors(): FormArray {
    return this.form.get("motors") as FormArray;
  }

  get f() {
    return this.form.controls;
  }
}
