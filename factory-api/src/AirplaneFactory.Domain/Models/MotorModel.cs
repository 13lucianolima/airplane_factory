using AirplaneFactory.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneFactory.Domain.Models
{
    public class MotorModel : BaseModel
    {
        public EnumMotorType MotorType { get; set; }
        public int AirplaneId { get; set; }
        public AirplaneModel Airplane { get; set; }
        public bool Running { get; set; }

    }
}
