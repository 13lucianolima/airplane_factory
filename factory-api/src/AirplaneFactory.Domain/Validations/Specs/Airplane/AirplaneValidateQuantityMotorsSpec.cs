using AirplaneFactory.Domain.Models;

namespace AirplaneFactory.Domain.Validations.Specs.Airplane
{
    public class AirplaneValidateQuantityMotorsSpec : ISpecification<AirplaneModel>
    {
        public string MessageError => "total de motores não corresponde a quantidade especificada";
        public bool IsSatisfiedBy(AirplaneModel entity)
        {
            var totalMotors = entity.Motors?.Count;
            totalMotors = totalMotors ?? 0;
            return totalMotors == entity.MotorQuantity;
        }
    }
}
