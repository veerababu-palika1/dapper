using DapperWebData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperWebData.BusinessManagers
{
    public interface IBusinessManager<TEntity> where TEntity : IEntity
    {
        TEntity Get(Guid id);
        IEnumerable<TEntity> Get();
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(Guid id);

    }
}
