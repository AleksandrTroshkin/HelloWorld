using System;
using Domain.Models;

namespace Domain.Services
{
    public interface ITestTableService : IDisposable
    {
        TestTable[] FindAll();
    }
}
