using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperWebData.Models
{
    public class Customer : IEntity
    {
        public Guid Id { get; set; }

        public string CustomerName { get; set; }

        public DateTime CustomerSince { get; set; }
        public virtual Contact Contact { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
