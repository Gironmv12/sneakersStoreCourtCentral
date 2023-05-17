using AcessoDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Crud.Order.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Dominio.metodos
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        private static int nextId = 1;
        public Proveedor(string nombre, string direccion, string telefono, string email)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.Id = nextId;
            nextId++;
        }
    }
    public class aProveedores
    {

        public static void AgregarProveedor(Proveedor proveedor)
        {
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                string query = "INSERT INTO Proveedores (Nombre, Direccion, Telefono, Email) VALUES (@nombre, @direccion, @telefono, @email)";
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", proveedor.Nombre);
                command.Parameters.AddWithValue("@direccion", proveedor.Direccion);
                command.Parameters.AddWithValue("@telefono", proveedor.Telefono);
                command.Parameters.AddWithValue("@email", proveedor.Email);
                command.ExecuteNonQuery();
            }
        }

        public static DataTable ObtenerProveedores()
        {
            string query = "SELECT id_Proveedor, Nombre, Direccion, Telefono, Email FROM Proveedores";
            DataTable tabla = new DataTable();
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                var adapter = new MySqlDataAdapter(command);
                adapter.Fill(tabla);
            }
            return tabla;
        }

        public static void EliminarProveedor(int idProveedor)
        {
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                // Obtener todos los productos asociados al proveedor que tengan una cantidad igual a cero o menor.
                List<int> productosAEliminar = new List<int>();
                string query = "SELECT id_productos FROM Productos WHERE Proveedor_id = @idProveedor AND Cantidad <= 0";
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@idProveedor", idProveedor);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    productosAEliminar.Add(reader.GetInt32(0));
                }
                reader.Close();

                // Eliminar cada producto de la base de datos.
                foreach (int idProducto in productosAEliminar)
                {
                    query = "DELETE FROM Productos WHERE id_productos = @idProducto";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idProducto", idProducto);
                    command.ExecuteNonQuery();
                }

                // Eliminar el proveedor de la base de datos.
                query = "DELETE FROM Proveedores WHERE id_Proveedor = @idProveedor";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@idProveedor", idProveedor);
                command.ExecuteNonQuery();
            }
        }

        public static bool ExistenProductosAsociados(int idProveedor)
        {
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Productos WHERE Proveedor_id = @idProveedor";
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@idProveedor", idProveedor);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }

        public static int ObtenerCantidadProductos(int idProveedor)
        {
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Productos WHERE Proveedor_id = @idProveedor";
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@idProveedor", idProveedor);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            }
        }


    }
}
