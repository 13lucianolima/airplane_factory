using AirplaneFactory.Common;
using AirplaneFactory.Domain.Models;
using System.Collections.Generic;

namespace AirplaneFactory.Domain.Validations
{
    public abstract class BaseCreateValidation<TModel> where TModel : BaseModel
    {
        private ValidationResult ValidationResult { get; set; }
        public BaseCreateValidation()
        {
            ValidationResult = new ValidationResult();
        }

        protected abstract IList<ISpecification<TModel>> Rules();

        public ValidationResult Validate(TModel entity)
        {
            var rules = Rules();
            foreach (var role in rules)
            {
                var isValid = role.IsSatisfiedBy(entity);
                if (!isValid)
                {
                    ValidationResult.Add(role.MessageError);
                }
            }
            return ValidationResult;
        }
    }
}
