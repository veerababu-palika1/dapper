using DapperWebApp.Dependency;
using DapperWebData.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace DapperWebApp.Helpers
{
    public class BusinessManagerHelper<TManager> where TManager : class
    {
        public static TResult Execute<TResult>(Expression<Func<TManager, TResult>> lambda)
        {

            var instance = CreateInstance();
            var result = default(TResult);
            result = lambda.Compile().Invoke(instance);
            return result;
        }

        public static void Execute(Expression<Action<TManager>> lambda)
        {
            var instance = CreateInstance();
            lambda.Compile().Invoke(instance);
        }

        private static TManager CreateInstance()
        {
            var attribute = typeof(TManager).GetCustomAttributes(typeof(DependencyAttribute), false).FirstOrDefault();
            if (attribute != null)
            {
                var dependency = (attribute as DependencyAttribute).Dependency;
                return DependencyResolver.GetInstance(dependency) as TManager;
            }

            return Activator.CreateInstance<TManager>();
        }
    }

}