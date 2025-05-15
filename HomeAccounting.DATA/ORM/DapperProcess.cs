using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccounting.DATA.ORM
{
    public class DapperProcess : IDapper
    {
        private readonly IConfiguration config;

        #region Ctor

        public DapperProcess(IConfiguration config)
        {
            this.config = config;
        }

        #endregion

        #region Sql Connection

        public SqlConnection GetOpenConnection()
        {
            var connection = new SqlConnection(config.GetConnectionString("MainConnection"));
            connection.Open();
            return connection;
        }

        #endregion

        #region Query

        public List<T> QueryApp<T>(string sql) 
        {
            using IDbConnection db = GetOpenConnection();
            return db.Query<T>(sql).ToList();
            
        }

        #endregion

        #region Dispose

        public void Dispose()
        {

        }
        #endregion
    }
}
