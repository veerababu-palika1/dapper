using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperWebData.Models
{
   public class Contact:IEntity
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }
    }
}
