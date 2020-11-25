using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AirplaneFactory.Application.ViewModels.Enums
{
    public enum EnumMotorType
    {
        [Description("Motor")]
        Engine = 1,
        [Description("Turbina")]
        Turbine = 2,
    }
}
