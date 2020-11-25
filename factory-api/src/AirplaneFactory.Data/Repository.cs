using AirplaneFactory.Domain.Interfaces.Data;
using AirplaneFactory.Domain.Models;
using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace AirplaneFactory.Data
{
    public class Repository<TModel> : IRepository<TModel> where TModel : BaseModel
    {
        private readonly AirplaneDbContext _dbContext;
        public Repository(AirplaneDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual IQueryable<TModel> Table()
        {
            return _dbContext.Set<TModel>().AsNoTracking();
        }

        public virtual TModel Add(TModel entity)
        {
            _dbContext.Add(entity);
            return entity;
        }

        public virtual TModel Read(int id)
        {
            return _dbContext.Set<TModel>().Find(id);
        }

        public virtual TModel Update(TModel entity)
        {
            _dbContext.Update(entity);
            return entity;
        }

        public virtual TModel Delete(TModel entity)
        {
            _dbContext.Set<TModel>().Remove(entity);
            return entity;
        }

        public virtual IQueryable<TModel> Find(Expression<Func<TModel, bool>> query)
        {
            return _dbContext.Set<TModel>().Where(query);
        }
    }
}
