using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperWebData.Helpers
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        public IDbConnection GetConnection
        {
            get
            {

                var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
                var connection = factory.CreateConnection();
                connection.ConnectionString = _connectionString;
                connection.Open();
                return connection;
            }
        }
    }
}
