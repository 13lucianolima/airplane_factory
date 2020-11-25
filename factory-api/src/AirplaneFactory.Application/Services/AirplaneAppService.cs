using AirplaneFactory.Application.Interfaces;
using AirplaneFactory.Application.ViewModels;
using AirplaneFactory.Common;
using AirplaneFactory.Domain.Interfaces.Data;
using AirplaneFactory.Domain.Interfaces.Service;
using AirplaneFactory.Domain.Models;
using AutoMapper;
using System.Collections.Generic;

namespace AirplaneFactory.Application.Services
{
    public class AirplaneAppService : IAirplaneAppService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAirplaneService _airplaneService;

        public AirplaneAppService(IUnitOfWork unitOfWork, IMapper mapper, IAirplaneService airplaneService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _airplaneService = airplaneService;
        }

        public List<AirplaneDetailViewModel> All()
        {
            using (_unitOfWork)
            {
                var result = _airplaneService.All();
                var map = _mapper.Map<List<AirplaneDetailViewModel>>(result);
                return map;
            }
        }

        public ResponseResult<AirplaneDetailViewModel> Read(int id)
        {
            var result = _airplaneService.Read(id);
            if (result.IsValid)
            {
                var map = _mapper.Map<AirplaneDetailViewModel>(result.Data);
                return new ResponseResult<AirplaneDetailViewModel>(map);
            }
            else
            {
                return new ResponseResult<AirplaneDetailViewModel>(result.ValidationResult);
            }
        }

        public ResponseResult<int> Add(AirplaneViewModel model)
        {
            using (_unitOfWork)
            {
                var map = _mapper.Map<AirplaneModel>(model);
                var result = _airplaneService.Add(map);
                if (result.IsValid)
                {
                    _unitOfWork.Commit();
                    return new ResponseResult<int>(result.Data.Id);
                }
                else
                {
                    return new ResponseResult<int>(result.ValidationResult);
                }
            }
        }

        public ResponseResult<int> Delete(int id)
        {
            using (_unitOfWork)
            {
                var result = _airplaneService.Delete(id);
                if (result.IsValid)
                {
                    _unitOfWork.Commit();
                    return new ResponseResult<int>(result.Data.Id);
                }
                else
                {
                    return new ResponseResult<int>(result.ValidationResult);
                }
            }
        }

        public ResponseResult<int> RunMotors(int id, int motorId)
        {
            using (_unitOfWork)
            {
                var result = _airplaneService.RunMotor(id, motorId);
                if (result.IsValid)
                {
                    _unitOfWork.Commit();
                    return new ResponseResult<int>(result.Data.Id);
                }
                else
                {
                    return new ResponseResult<int>(result.ValidationResult);
                }
            }
        }

        public ResponseResult<int> StopMotors(int id, int motorId)
        {
            using (_unitOfWork)
            {
                var result = _airplaneService.StopMotors(id, motorId);
                if (result.IsValid)
                {
                    _unitOfWork.Commit();
                    return new ResponseResult<int>(result.Data.Id);
                }
                else
                {
                    return new ResponseResult<int>(result.ValidationResult);
                }
            }
        }
    }
}
