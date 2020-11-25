using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneFactory.Domain.Interfaces.Data
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
