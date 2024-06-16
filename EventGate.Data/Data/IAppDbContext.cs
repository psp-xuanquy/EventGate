using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;

namespace EventGate.Data
{
    public interface IAppDbContext : IDisposable
    {
        DatabaseFacade DatabaseFacade { get; }
        EntityEntry Add(object entity);
    }
}
