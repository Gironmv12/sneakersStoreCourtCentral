using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDatos;
using MySql.Data.MySqlClient;

namespace Dominio
{
    public class ModeloUsuario
    {
        UsuarioDatos usuarioDatos = new UsuarioDatos();
        public bool LoginUsuario(string usuario, string contraseña)
        {
            return usuarioDatos.Login(usuario, contraseña);//mandé allmar el metodo login usando paramentros de usurario y contraseña
        }
    }
}
