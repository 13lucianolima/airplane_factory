using AirplaneFactory.Application.ViewModels.Enums;
using AirplaneFactory.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneFactory.Application.ViewModels
{
    public class MotorDetailViewModel
    {
        public int Id { get; set; }
        public EnumMotorType MotorType { get; set; }
        public string MotorTypeDescription { get { return this.MotorType.GetDescription(); } }
        public bool Running { get; set; }
    }
}
