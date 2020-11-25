import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NewAirplaneComponent } from './new-airplane.component';

describe('NewAirplaneComponent', () => {
  let component: NewAirplaneComponent;
  let fixture: ComponentFixture<NewAirplaneComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NewAirplaneComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NewAirplaneComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
