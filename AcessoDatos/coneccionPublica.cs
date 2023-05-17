using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AcessoDatos
{
    public class coneccionPublica : conectionMySQL
    {
        public new MySqlConnection GetConnection()
        {
            return base.GetConnection();
        }

        public bool ExisteUsuario(string nombreUsuario)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM usuarios WHERE Nombre_Usuario=@nombreUsuario", conn);
                cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }

}
