using AirplaneFactory.Domain.Models;

namespace AirplaneFactory.Domain.Validations
{
    public interface ISpecification<TModel> where TModel : BaseModel
    {
        bool IsSatisfiedBy(TModel entity);
        string MessageError { get; }
    }
}
