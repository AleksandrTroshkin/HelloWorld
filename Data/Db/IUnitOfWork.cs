using System;

namespace Data.Db
{
    public interface IUnitOfWork : IDisposable
    {
        ITestTableRepository TestTables { get; }
        void SaveChanges();
    }
}
