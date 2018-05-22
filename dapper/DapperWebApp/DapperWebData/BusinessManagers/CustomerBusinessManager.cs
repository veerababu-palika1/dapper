using DapperWebData.Attributes;
using DapperWebData.Helpers;
using DapperWebData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperWebData.BusinessManagers
{
    [DependencyAttribute(typeof(ICustomerBusinessManager))]
    public class CustomerBusinessManager : BusinessManager<Customer>, ICustomerBusinessManager
    {
        public CustomerBusinessManager(IConnectionFactory cf)
            : base(cf)
        {

        }
    }
}
