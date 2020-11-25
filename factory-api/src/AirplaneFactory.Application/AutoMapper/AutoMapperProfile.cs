using AirplaneFactory.Application.ViewModels;
using AirplaneFactory.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneFactory.Application.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AirplaneViewModel, AirplaneModel>().ReverseMap();
            CreateMap<AirplaneDetailViewModel, AirplaneModel>().ReverseMap();
            CreateMap<MotorViewModel, MotorModel>().ReverseMap();
            CreateMap<MotorDetailViewModel, MotorModel>().ReverseMap();
        }
    }
}
