using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperWebData.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class DependencyAttribute : Attribute
    {
        private readonly Type _dependency;

        public DependencyAttribute(Type dependency)
        {
            _dependency = dependency;
        }

        public Type Dependency
        {
            get { return _dependency; }
        }

    }
}
