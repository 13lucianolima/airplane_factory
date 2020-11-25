using AirplaneFactory.Domain.Models;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace AirplaneFactory.Domain.Interfaces.Data
{
    public interface IRepository<TModel> where TModel : BaseModel
    {
        IQueryable<TModel> Table();
        TModel Add(TModel entity);
        TModel Read(int id);
        TModel Update(TModel entity);
        TModel Delete(TModel entity);
        IQueryable<TModel> Find(Expression<Func<TModel, bool>> query);
    }
}
