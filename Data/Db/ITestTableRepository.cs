using Domain.Models;

namespace Data.Db
{
    public interface ITestTableRepository
    {
        TestTable[] FindAll();
    }
}
