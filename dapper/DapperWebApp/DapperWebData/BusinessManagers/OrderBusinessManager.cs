using DapperWebData.Helpers;
using DapperWebData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperWebData.BusinessManagers
{
    public class OrderBusinessManager : BusinessManager<Order>, IOrderBusinessManager
    {
        public OrderBusinessManager(IConnectionFactory cf)
            : base(cf)
        {

        }
    }
}
