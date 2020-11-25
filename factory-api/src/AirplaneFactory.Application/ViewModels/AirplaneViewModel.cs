using AirplaneFactory.Application.ViewModels.Enums;
using System.Collections.Generic;

namespace AirplaneFactory.Application.ViewModels
{
    public class AirplaneViewModel
    {
        public EnumAirplaneType AirplaneType { get; set; }
        public int MotorQuantity { get; set; }
        public List<MotorViewModel> Motors { get; set; }
    }
}
