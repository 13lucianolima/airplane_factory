using AirplaneFactory.Domain.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneFactory.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool _disposed;
        private readonly AirplaneDbContext _dbContext;
        public UnitOfWork(AirplaneDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            if (_disposed == false)
            {
                _dbContext.Dispose();
                _disposed = true;
            }
        }
    }
}
