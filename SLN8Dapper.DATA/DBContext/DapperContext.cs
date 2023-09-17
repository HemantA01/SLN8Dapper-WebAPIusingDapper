using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLN8Dapper.DATA.DBContext
{
    public class DapperContext
    {
        public readonly IConfiguration _config;
        public readonly string _conString;
        public DapperContext(IConfiguration config) 
        {
            _config = config;
            _conString = _config.GetConnectionString("DbConn");
        }
        public IDbConnection CreateConnection() => new SqlConnection(_conString);
    }
}
