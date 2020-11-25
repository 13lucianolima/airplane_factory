using AirplaneFactory.Common;
using AirplaneFactory.Domain.Models;
using System.Collections.Generic;

namespace AirplaneFactory.Domain.Interfaces.Service
{
    public interface IAirplaneService
    {
        List<AirplaneModel> All();
        ResponseResult<AirplaneModel> Read(int id);
        ResponseResult<AirplaneModel> Add(AirplaneModel entity);
        ResponseResult<AirplaneModel> Delete(int id);
        ResponseResult<AirplaneModel> RunMotor(int id, int motorId);
        ResponseResult<AirplaneModel> StopMotors(int id, int motorId);
    }
}
