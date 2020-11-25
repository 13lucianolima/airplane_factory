using AirplaneFactory.Domain.Models;
using System.Linq;

namespace AirplaneFactory.Domain.Validations.Specs.Airplane
{
    public class AirplaneValidateMotorsTypeSpec : ISpecification<AirplaneModel>
    {
        public string MessageError => "tipos de motores não podem ser diferentes";
        public bool IsSatisfiedBy(AirplaneModel entity)
        {
            var typeMotors = entity.Motors?.GroupBy(x => x.MotorType).Count();
            typeMotors = typeMotors ?? 0;
            return typeMotors == 1;
        }
    }
}
