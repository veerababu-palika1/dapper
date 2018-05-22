using DapperWebData.BusinessManagers;
using DapperWebData.Helpers;
using System;
using Unity;
using Unity.Lifetime;
namespace DapperWebApp.Dependency
{
    public class DependencyResolver
    {
        private static IUnityContainer _container;
        public static void RegisterDependency(IUnityContainer container)
        {
            _container = container;
            _container.RegisterType<IContactBusinessManager, ContactBusinessManager>(new HierarchicalLifetimeManager());
            _container.RegisterType<IConnectionFactory, ConnectionFactory>(new HierarchicalLifetimeManager());
            _container.RegisterType<ICustomerBusinessManager, CustomerBusinessManager>(new HierarchicalLifetimeManager());
            _container.RegisterType<IOrderBusinessManager, OrderBusinessManager>(new HierarchicalLifetimeManager());
        }

        public static object GetInstance(Type type)
        {
            return _container.Resolve(type);
        }

    }
}