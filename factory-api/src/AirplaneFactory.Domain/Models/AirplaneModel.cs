using AirplaneFactory.Domain.Models.Enums;
using System.Collections.Generic;

namespace AirplaneFactory.Domain.Models
{
    public class AirplaneModel : BaseModel
    {
        public EnumAirplaneType AirplaneType { get; set; }
        public int MotorQuantity { get; set; }
        public List<MotorModel> Motors { get; set; }
    }
}
