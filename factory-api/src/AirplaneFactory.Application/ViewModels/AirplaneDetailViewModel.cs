using AirplaneFactory.Application.ViewModels.Enums;
using System.Collections.Generic;
using AirplaneFactory.Common;

namespace AirplaneFactory.Application.ViewModels
{
    public class AirplaneDetailViewModel
    {
        public int Id { get; set; }
        public EnumAirplaneType AirplaneType { get; set; }
        public string AirplaneTypeDescription { get { return this.AirplaneType.GetDescription(); } }
        public int MotorQuantity { get; set; }
        public List<MotorDetailViewModel> Motors { get; set; }
    }
}
