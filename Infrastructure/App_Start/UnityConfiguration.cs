using Data.Db;
using Data.Services;
using Domain.Services;
using Infrastructure.Db;
using Unity;

namespace Infrastructure
{
    public static class UnityConfiguration
    {
        public static UnityContainer Create()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<ITestTableService, TestTableService>();

            return container;
        }
    }
}