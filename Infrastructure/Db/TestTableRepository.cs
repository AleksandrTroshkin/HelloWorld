using Data.Db;
using Domain.Models;
using System.Linq;

namespace Infrastructure.Db
{
    class TestTableRepository : ITestTableRepository
    {
        private readonly TestTableContext Context;
        public TestTableRepository(TestTableContext context)
        {
            Context = context;
        }

        public TestTable[] FindAll()
        {
            return Context.TestTables.ToArray();
        }
    }
}
