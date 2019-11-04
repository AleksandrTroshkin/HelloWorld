using Data.Db;
using Domain.Models;
using Domain.Services;

namespace Data.Services
{
    public class TestTableService : ITestTableService
    {
        private readonly IUnitOfWork Uow;

        public TestTableService(IUnitOfWork uow)
        {
            Uow = uow;
        }

        public void Dispose()
        {
            Uow.Dispose();
        }

        public TestTable[] FindAll()
        {
            return Uow.TestTables.FindAll();
        }
    }
}
