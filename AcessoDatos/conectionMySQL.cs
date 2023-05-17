using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace AcessoDatos
{
    public abstract class conectionMySQL
    {
        private readonly string connectionString;

        public conectionMySQL()
        {
            connectionString = "server=127.0.0.1;database=courtcentral;uid=root;pwd=root;";
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
