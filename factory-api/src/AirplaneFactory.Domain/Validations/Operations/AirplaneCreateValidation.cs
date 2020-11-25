using AirplaneFactory.Domain.Models;
using AirplaneFactory.Domain.Validations.Specs.Airplane;
using System.Collections.Generic;

namespace AirplaneFactory.Domain.Validations.Operations
{
    public class AirplaneCreateValidation : BaseCreateValidation<AirplaneModel>
    {
        protected override IList<ISpecification<AirplaneModel>> Rules()
        {
            var rules = new List<ISpecification<AirplaneModel>>
            {
                new AirplaneValidateMotorsTypeSpec(),
                new AirplaneValidateMotorTypeWithAirplaneTypeSpec(),
                new AirplaneValidateQuantityMotorsSpec(),
            };

            return rules;
        }
    }
}
