using Infrastructure;
using System.Web.Mvc;
using Unity.Mvc5;

namespace TestMVC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = UnityConfiguration.Create();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}