using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AirplaneFactory.Application.ViewModels.Enums
{
    public enum EnumAirplaneType
    {
        [Description("Motor")]
        Engine = 1,
        [Description("Turbina")]
        Turbine = 2,
    }
}
