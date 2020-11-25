using AirplaneFactory.Domain.Models;
using System.Linq;

namespace AirplaneFactory.Domain.Validations.Specs.Airplane
{
    public class AirplaneValidateMotorTypeWithAirplaneTypeSpec : ISpecification<AirplaneModel>
    {
        public string MessageError => "tipo de motor não corresponde ao tipo do avião";
        public bool IsSatisfiedBy(AirplaneModel entity)
        {
            switch (entity.AirplaneType)
            {
                case Models.Enums.EnumAirplaneType.Engine:
                    var existsTurbine = entity.Motors?.Any(x => x.MotorType == Models.Enums.EnumMotorType.Turbine);
                    return !existsTurbine.HasValue || !existsTurbine.Value;                    
                case Models.Enums.EnumAirplaneType.Turbine:
                    var existsEgine = entity.Motors?.Any(x => x.MotorType == Models.Enums.EnumMotorType.Engine);
                    return !existsEgine.HasValue || !existsEgine.Value;
                default:
                    return false;
            }            
        }
    }
}
