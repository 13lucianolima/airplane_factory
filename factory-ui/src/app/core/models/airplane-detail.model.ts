import { IMotorDetailModel } from './motor-detail.model';
import { IMotorModel } from './motor.model';
export interface IAirplaneDetailModel {
    id: number;
    airplaneType: number;
    airplaneTypeDescription: string;
    motorQuantity: number;
    running: boolean;
    motors?: IMotorDetailModel[]
}
