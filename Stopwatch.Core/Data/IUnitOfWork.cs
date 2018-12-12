using System;

namespace Stopwatch.Core.Data
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}