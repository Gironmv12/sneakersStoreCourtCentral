using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using comun.Cache;

namespace AcessoDatos
{
    public class UsuarioDatos : conectionMySQL
    {
        public bool Login(string usuario, string contraseña)//metodo y firma
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using(var command = new MySqlCommand())
                {
                    command.Connection = conection;
                    command.CommandText = "SELECT * FROM usuarios WHERE Nombre_Usuario = @user AND Password_Usuario = @pass;";
                    command.Parameters.AddWithValue("@user", usuario);
                    command.Parameters.AddWithValue("@pass", contraseña);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CacheLoginUser.NombreUsuario = reader.GetString(1);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
