using DapperWebApp.Helpers;
using DapperWebData.BusinessManagers;
using DapperWebData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DapperWebApp.Controllers
{
    public class BaseController<TManager, TEntity> : ApiController
        where TManager : BusinessManager<TEntity>
        where TEntity : class,IEntity
    {
        [HttpGet]
        public IEnumerable<TEntity> Get()
        {
            return BusinessManagerHelper<TManager>.Execute(manager => manager.Get());
        }

        [HttpGet]
        public TEntity Get(Guid id)
        {
            return BusinessManagerHelper<TManager>.Execute(manager => manager.Get(id));
        }

        [HttpPost]
        public TEntity Post(TEntity entity)
        {
            return BusinessManagerHelper<TManager>.Execute(manager => manager.Create(entity));
        }

        [HttpPut]
        public TEntity Put(TEntity entity)
        {
            return BusinessManagerHelper<TManager>.Execute(manager => manager.Update(entity));
        }

        [HttpDelete]
        public void Delete(Guid id)
        {
            BusinessManagerHelper<TManager>.Execute(manager => manager.Delete(id));
        }
    }
}
