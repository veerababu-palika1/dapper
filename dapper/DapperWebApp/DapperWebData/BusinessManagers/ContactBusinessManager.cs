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
    [DependencyAttribute(typeof(IContactBusinessManager))]
    public class ContactBusinessManager : BusinessManager<Contact>, IContactBusinessManager
    {
        public ContactBusinessManager(IConnectionFactory cf)
            : base(cf)
        {

        }
    }
}
