using Data.Db;

namespace Infrastructure.Db
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TestTableContext Context;

        public UnitOfWork()
        {
            Context = new TestTableContext();
            TestTables = new TestTableRepository(Context);
        }

        public ITestTableRepository TestTables { get; private set; }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
