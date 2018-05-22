using DapperWebData.Helpers;
using DapperWebData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib;
using Dapper.Mapper;

namespace DapperWebData.BusinessManagers
{
    public class BusinessManager<TEntity> : IBusinessManager<TEntity> where TEntity : class,IEntity
    {
        internal IConnectionFactory _connectionFactory;

        public BusinessManager(IConnectionFactory _cf)
        {
            _connectionFactory = _cf;
        }
        public virtual TEntity Get(Guid id)
        {
            using (var cn = _connectionFactory.GetConnection)
            {
                return cn.Get<TEntity>(id);

            }
        }

        public virtual IEnumerable<TEntity> Get()
        {
            using (var cn = _connectionFactory.GetConnection)
            {
                return cn.GetList<TEntity>();

            }
        }

        public virtual TEntity Create(TEntity entity)
        {
            using (var cn = _connectionFactory.GetConnection)
            {
                entity.Id = Guid.NewGuid();
                cn.Insert<TEntity>(entity);

                return entity;
            }
        }

        public virtual TEntity Update(TEntity entity)
        {
            using (var cn = _connectionFactory.GetConnection)
            {
                cn.Update(entity);
                return entity;
            }
        }

        public virtual void Delete(Guid id)
        {
            using (var cn = _connectionFactory.GetConnection)
            {
                cn.Delete<TEntity>(id);
            }
        }
    }
}
