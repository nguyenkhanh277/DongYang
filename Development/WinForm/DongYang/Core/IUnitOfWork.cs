using DongYang.Core.Repositories;
using System;
using DongYang.Persistence;

namespace DongYang.Core
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}