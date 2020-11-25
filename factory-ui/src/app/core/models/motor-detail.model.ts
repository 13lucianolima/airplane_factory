import { EnumMotorType } from './enums/enum-motor-type';
export interface IMotorDetailModel {
    id?: number;
    motorType: EnumMotorType;
    motorTypeDescription: string;
    running: boolean;
}