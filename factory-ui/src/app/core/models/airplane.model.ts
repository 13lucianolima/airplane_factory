import { IMotorModel } from './motor.model';
import { EnumAirplaneType } from './enums/enum-airplane-type';
export interface IAirplaneModel {
    airplaneType: EnumAirplaneType;
    motorQuantity: number;
    motors: IMotorModel[];
}