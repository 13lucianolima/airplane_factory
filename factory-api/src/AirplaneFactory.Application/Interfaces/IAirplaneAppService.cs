using AirplaneFactory.Application.ViewModels;
using AirplaneFactory.Common;
using System.Collections.Generic;

namespace AirplaneFactory.Application.Interfaces
{
    public interface IAirplaneAppService
    {
        List<AirplaneDetailViewModel> All();
        ResponseResult<AirplaneDetailViewModel> Read(int id);
        ResponseResult<int> Add(AirplaneViewModel model);
        ResponseResult<int> Delete(int id);
        ResponseResult<int> RunMotors(int id, int motorId);
        ResponseResult<int> StopMotors(int id, int motorId);
    }
}
