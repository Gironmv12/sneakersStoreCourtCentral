using AcessoDatos;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Dominio.metodos
{
    public class ClientesA
    {
        public string Nombre { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public string Telefono { get; set;}
        public string Email { get; set; }
        public string Direccion { get; set;}
        public int ClienteDescuento { get; set;}

        public ClientesA(string Nombre, string RFC, string CURP, string Telefono, string Email, string Direccion, int ClienteDescuento)
        {
            this.Nombre = Nombre;
            this.RFC = RFC;
            this.CURP = CURP;
            this.Telefono = Telefono;
            this.Email = Email;
            this.Direccion = Direccion;
            this.ClienteDescuento = ClienteDescuento;
        }  
    }

    public class ClientesB
    {
        public string Nombre { get; set; }

        public ClientesB(string nombre)
        {
            Nombre = nombre;
        }
    }

    public class aClientes
    {

        public static void AgregarCliente(ClientesA clientesA)
        {
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                string query = "INSERT INTO Clientes (Nombre, RFC, CURP, Telefono,Email, Direccion, ClienteDescuento) VALUES (@nombre, @RFC, @CURP, @Telefono, @Email, @Direccion, @ClienteDescuento)";
                connection.Open();
                var command = new MySqlCommand(query, connection);

                //Añadir los aprametros y los objetos previamente creadas
                command.Parameters.AddWithValue("@nombre", clientesA.Nombre);
                command.Parameters.AddWithValue("@RFC", clientesA.RFC);
                command.Parameters.AddWithValue("@CURP", clientesA.CURP);
                command.Parameters.AddWithValue("@Telefono", clientesA.Telefono);
                command.Parameters.AddWithValue("@Email", clientesA.Email);
                command.Parameters.AddWithValue("@Direccion", clientesA.Direccion);
                command.Parameters.AddWithValue("@ClienteDescuento", clientesA.ClienteDescuento);
                command.ExecuteNonQuery();
            }
        }

        public static DataTable ObtenerClientes()
        {
            string query = "SELECT id_Clientes, Nombre, RFC, CURP, Telefono, Email, Direccion, ClienteDescuento FROM Clientes";
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

        public static void EliminarCliente( int id_Clientes)
        {
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                // Elimina los registros relacionados en la tabla "detalleventa"
                string detalleventaQuery = "DELETE FROM detalleventa WHERE Ventas_id_Venta IN (SELECT id_Venta FROM ventas WHERE Clientes_id_Clientes = @idCliente)";
                var detalleventaCommand = new MySqlCommand(detalleventaQuery, connection);
                detalleventaCommand.Parameters.AddWithValue("@idCliente", id_Clientes);
                connection.Open();
                detalleventaCommand.ExecuteNonQuery();

                // Elimina los registros relacionados en la tabla "ventas"
                string ventasQuery = "DELETE FROM ventas WHERE Clientes_id_Clientes = @idCliente";
                var ventasCommand = new MySqlCommand(ventasQuery, connection);
                ventasCommand.Parameters.AddWithValue("@idCliente", id_Clientes);
                ventasCommand.ExecuteNonQuery();

                // Elimina el registro de la tabla "Clientes"
                string clientesQuery = "DELETE FROM Clientes WHERE id_Clientes = @idCliente";
                var clientesCommand = new MySqlCommand(clientesQuery, connection);
                clientesCommand.Parameters.AddWithValue("@idCliente", id_Clientes);
                clientesCommand.ExecuteNonQuery();
            }
        }
    }
}
