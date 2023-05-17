using AcessoDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dominio.metodos
{
    public class rVentas
    {
        public static decimal ObtenerPrecioProducto(string nombreProducto)
        {
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                connection.Open();
                var command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT Precio_del_producto FROM productos WHERE Nombre_del_producto = @nombreProducto";
                command.Parameters.AddWithValue("@nombreProducto", nombreProducto);

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    decimal precioProducto = Convert.ToDecimal(reader["Precio_del_producto"]);

                    return precioProducto;
                }

                // Devolver un valor por defecto en caso de que no se haya encontrado el precio del producto
                return 0;
            }
        }

        public static void ActualizarCantidadProducto(string nombreProducto, int cantidadComprada)
        {
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                connection.Open();
                var command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "UPDATE productos SET Cantidad = Cantidad - @cantidadComprada WHERE Nombre_del_producto = @nombreProducto";
                command.Parameters.AddWithValue("@cantidadComprada", cantidadComprada);
                command.Parameters.AddWithValue("@nombreProducto", nombreProducto);
                command.ExecuteNonQuery();
            }
        }

        public static void ActualizarTotales(DataGridView dgvProductosAgregados, Label lblTotalProductos, Label lblArticulos)
        {
            decimal totalProductos = 0;
            int totalArticulos = 0;

            foreach (DataGridViewRow row in dgvProductosAgregados.Rows)
            {
                string nombreProducto = row.Cells["Nombre"].Value != null ? row.Cells["Nombre"].Value.ToString() : string.Empty;
                decimal precioProducto = ObtenerPrecioProducto(nombreProducto);
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                decimal total = precioProducto * cantidad;

                row.Cells["Precio"].Value = precioProducto;
                row.Cells["Total"].Value = total;

                totalProductos += total;
                totalArticulos += cantidad;

                // Actualizar la cantidad del producto en la base de datos
                rVentas.ActualizarCantidadProducto(nombreProducto, cantidad);
            }
            lblTotalProductos.Text = totalProductos.ToString("0.00");
            lblArticulos.Text = totalArticulos.ToString();
        }

        public static List<ClientesB> ObtenerClientes()
        {
            List<ClientesB> clientes = new List<ClientesB>();
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                string query = "SELECT Nombre FROM Clientes";
                connection.Open();
                var command = new MySqlCommand(query, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    clientes.Add(new ClientesB(reader.GetString(0)));
                }
            }
            return clientes;
        }

        // ==================== METODO INSERTAR VENTAS =======================
        public static void InsertarDetalleVenta(int idVenta, int idProducto, int cantidad, decimal precioProducto)
        {
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                string query = "INSERT INTO DetalleVenta (Fecha, Cantidad, PrecioProducto, PRODUCTOS_id_productos, Ventas_id_Venta) VALUES (@fecha, @cantidad, @precioProducto, @idProducto, @idVenta)";
                var command = new MySqlCommand(query, connection);
                connection.Open();
                // Asignar valores a los parámetros de la consulta
                command.Parameters.AddWithValue("@fecha", DateTime.Now);
                command.Parameters.AddWithValue("@cantidad", cantidad);
                command.Parameters.AddWithValue("@precioProducto", precioProducto);
                command.Parameters.AddWithValue("@idProducto", idProducto);
                command.Parameters.AddWithValue("@idVenta", idVenta);

                // Ejecutar la consulta
                command.ExecuteNonQuery();

                try
                {

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar detalle de venta: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public static int InsertarVenta(int idCliente, DateTime fechaVenta, decimal totalVenta)
        {
            int idVenta = 0;

            try
            {
                coneccionPublica conexion = new coneccionPublica();
                using (var connection = conexion.GetConnection())
                {
                    connection.Open();
                    string query = "INSERT INTO Ventas (Clientes_id_Clientes, Fecha_venta, Precio_venta) VALUES (@idCliente, @fechaVenta, @totalVenta); SELECT LAST_INSERT_ID();";
                    var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idCliente", idCliente);
                    command.Parameters.AddWithValue("@fechaVenta", fechaVenta);
                    command.Parameters.AddWithValue("@totalVenta", totalVenta);
                    idVenta = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al insertar la venta en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return idVenta;
        }

        // =========== OBTENER ID PRODUCTO ============
        public static int ObtenerIdProducto(string nombreProducto)
        {
            int idProducto = -1; // inicializamos con un valor que indique que no se encontró el producto

            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                connection.Open();
                string query = "SELECT id_productos FROM Productos WHERE Nombre_del_producto = @NombreProducto";
                var command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@NombreProducto", nombreProducto);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    idProducto = reader.GetInt32(0); // obtenemos el valor del primer campo (el id del producto)
                }
                reader.Close();
            }
            return idProducto;
        }

        // ========= OBTENER STOCK DEL PRODUCTO ================

        public static int ObtenerStockProducto(string nombreProducto)
        {
            int stock = 0;
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                connection.Open();
                string query = "SELECT Cantidad FROM productos WHERE Nombre_del_producto = @nombreProducto";
                var command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@nombreProducto", nombreProducto);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    stock = reader.GetInt32(0);
                }
                reader.Close();
            }

            return stock;
        }
    }
}
