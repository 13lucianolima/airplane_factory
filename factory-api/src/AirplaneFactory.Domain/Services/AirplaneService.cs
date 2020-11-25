using AirplaneFactory.Common;
using AirplaneFactory.Domain.Interfaces.Data;
using AirplaneFactory.Domain.Interfaces.Service;
using AirplaneFactory.Domain.Models;
using AirplaneFactory.Domain.Validations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirplaneFactory.Domain.Services
{
    public class AirplaneService : IAirplaneService
    {
        private readonly IRepository<AirplaneModel> _airplaneRepository;
        private readonly IRepository<MotorModel> _motorRepository;
        public AirplaneService(IRepository<AirplaneModel> repository, IRepository<MotorModel> motorRepository)
        {
            _airplaneRepository = repository;
            _motorRepository = motorRepository;
        }

        public List<AirplaneModel> All()
        {
            return _airplaneRepository.Table().ToList();
        }

        public ResponseResult<AirplaneModel> Read(int id)
        {
            var result = new ResponseResult<AirplaneModel>();

            var airplane = _airplaneRepository.Read(id);
            if (airplane == null) result.ValidationResult.Add("avião não encontrado");
            if (!result.IsValid) return result;

            airplane.Motors = _motorRepository.Table().Where(x => x.AirplaneId == id).ToList();

            return new ResponseResult<AirplaneModel>(airplane);
        }

        public ResponseResult<AirplaneModel> Add(AirplaneModel entity)
        {
            var validation = new AirplaneCreateValidation().Validate(entity);
            if (!validation.IsValid) return new ResponseResult<AirplaneModel>(validation);
            _airplaneRepository.Add(entity);
            return new ResponseResult<AirplaneModel>(entity);
        }

        public ResponseResult<AirplaneModel> Delete(int id)
        {
            var result = new ResponseResult<AirplaneModel>();

            var entity = _airplaneRepository.Read(id);
            if (entity == null) result.ValidationResult.Add("avião não encontrado");

            if (!result.IsValid) return result;
            _airplaneRepository.Delete(entity);
            return new ResponseResult<AirplaneModel>(entity);
        }

        public ResponseResult<AirplaneModel> RunMotor(int id, int motorId)
        {
            var result = new ResponseResult<AirplaneModel>();

            var airplane = _airplaneRepository.Read(id);
            if (airplane == null) result.ValidationResult.Add("avião não encontrado");
            if (!result.IsValid) return result;

            var motor = _motorRepository.Find(x => x.AirplaneId == id && x.Id == motorId).FirstOrDefault();
            if (motor == null) result.ValidationResult.Add("motor não encontrado");

            motor.Running = true;

            return new ResponseResult<AirplaneModel>(airplane);
        }

        public ResponseResult<AirplaneModel> StopMotors(int id, int motorId)
        {
            var result = new ResponseResult<AirplaneModel>();

            var airplane = _airplaneRepository.Read(id);
            if (airplane == null) result.ValidationResult.Add("avião não encontrado");
            if (!result.IsValid) return result;

            var motor = _motorRepository.Find(x => x.AirplaneId == id && x.Id == motorId).FirstOrDefault();
            if (motor == null) result.ValidationResult.Add("motor não encontrado");

            motor.Running = false;

            return new ResponseResult<AirplaneModel>(airplane);
        }
    }
}
