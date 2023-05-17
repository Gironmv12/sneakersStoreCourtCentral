using Dominio.metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using AcessoDatos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Presentacion.Formularios.Productos;

namespace Presentacion.Formularios.Porveedores
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();

        }

        private void btnAñadirProveedores_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(txtNombreProveedor.Text) ||
                    string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    throw new Exception("Por favor, rellene todos los campos");
                }

                // Obtener los valores de los TextBox
                string nombre = txtNombreProveedor.Text;
                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;
                string email = txtEmail.Text;

                // Validar que el nombre no contenga números
                if (nombre.Any(char.IsDigit))
                {
                    throw new Exception("El nombre no debe contener números");
                }

                // Validar que la dirección no contenga caracteres especiales
                if (!direccion.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
                {
                    throw new Exception("La dirección no debe contener caracteres especiales");
                }

                // Validar que el teléfono contenga solo números
                if (!telefono.All(char.IsDigit))
                {
                    throw new Exception("El teléfono debe contener solo números");
                }

                // Validar que el email contenga un solo @
                int count = email.Count(f => f == '@');
                if (count != 1)
                {
                    throw new Exception("El email debe contener un solo @");
                }

                // Crear un objeto de la clase Proveedor
                Proveedor proveedor = new Proveedor(nombre, direccion, telefono, email);

                // Llamar al método AgregarProveedor de la clase aProveedores
                aProveedores.AgregarProveedor(proveedor);

                // Mostrar el mensaje de que el proveedor ha sido agregado
                MessageBox.Show("¡Proveedor agregado correctamente!", "Agregado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar el DataGridView con los datos de los proveedores
                DataTable proveedores = aProveedores.ObtenerProveedores();
                dgvProveedoresAlta.DataSource = proveedores;

                // Limpiar los campos de texto
                txtNombreProveedor.Text = "";
                txtDireccion.Text = "";
                txtEmail.Text = "";
                txtTelefono.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {

            // Obtener los proveedores existentes de la base de datos
            DataTable proveedores = aProveedores.ObtenerProveedores();

            // Asignar los proveedores al DataGridView
            dgvProveedoresAlta.DataSource = proveedores;
            CargarProductosProveedores();
            CargarProveedores();
            MostrarPedidos();

        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {

            if (dgvProveedoresAlta.SelectedRows.Count > 0)
            {
                int idProveedor = Convert.ToInt32(dgvProveedoresAlta.SelectedRows[0].Cells["id_Proveedor"].Value);

                int cantidadProductos = aProveedores.ObtenerCantidadProductos(idProveedor);

                if (cantidadProductos > 0)
                {
                    MessageBox.Show("El proveedor no se puede eliminar hasta que se eliminen o se transfieran los productos asociados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el proveedor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        aProveedores.EliminarProveedor(idProveedor);
                        dgvProveedoresAlta.Rows.Remove(dgvProveedoresAlta.SelectedRows[0]);
                        MessageBox.Show("El proveedor se ha eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la clase coneccionPublica para obtener la conexión
            coneccionPublica conexion = new coneccionPublica();

            // Abrir la conexión y comenzar la transacción
            using (var connection = conexion.GetConnection())
            {
                connection.Open();
                var transaction = connection.BeginTransaction();

                try
                {
                    // Obtener el id del proveedor seleccionado en el ComboBox
                    string nombreProveedor = cbProveedor.SelectedValue.ToString();
                    string query = "SELECT id_Proveedor FROM Proveedores WHERE Nombre = @nombreProveedor";
                    var command = new MySqlCommand(query, connection, transaction);
                    command.Parameters.AddWithValue("@nombreProveedor", nombreProveedor);
                    int idProveedor = Convert.ToInt32(command.ExecuteScalar());

                    // Obtener el id del producto seleccionado en el ComboBox
                    int idProducto;
                    string nombreProducto = cbProducto.Text;

                    string queryProducto = "SELECT id_productos FROM PRODUCTOS WHERE Nombre_del_producto = @nombreProducto";
                    command = new MySqlCommand(queryProducto, connection, transaction);
                    command.Parameters.AddWithValue("@nombreProducto", nombreProducto);
                    idProducto = Convert.ToInt32(command.ExecuteScalar());

                    // Insertar el nuevo pedido en la tabla de PedidosProveedores
                    query = "INSERT INTO PedidosProveedores (Fecha_Orden, Proveedores_id_Proveedor) VALUES (@fecha, @proveedor)";
                    command = new MySqlCommand(query, connection, transaction);
                    command.Parameters.AddWithValue("@fecha", dtpFechaPedido.Value);
                    command.Parameters.AddWithValue("@proveedor", idProveedor);
                    command.ExecuteNonQuery();

                    // Obtener el ID del pedido que acabamos de insertar
                    query = "SELECT LAST_INSERT_ID()";
                    command = new MySqlCommand(query, connection, transaction);
                    int idPedido = Convert.ToInt32(command.ExecuteScalar());

                    // Insertar el detalle del suministro en la tabla DetalleSuministro
                    query = "INSERT INTO DetalleSuministro (PRODUCTOS_id_productos, PedidosProveedores_id_orden, " +
                        "Proveedores_id_proveedor, CantidadPedida) VALUES (@producto, @pedido, @proveedor, @cantidad)";
                    command = new MySqlCommand(query, connection, transaction);
                    command.Parameters.AddWithValue("@producto", idProducto);
                    command.Parameters.AddWithValue("@pedido", idPedido);
                    command.Parameters.AddWithValue("@proveedor", idProveedor);
                    command.Parameters.AddWithValue("@cantidad", Convert.ToInt32(nudCantidadPedir.Value));
                    command.ExecuteNonQuery();

                    // Actualizar la cantidad disponible del producto en la tabla PRODUCTOS
                    int cantidadDisponibleActual = ObtenerCantidadDisponible(idProducto, connection, transaction);
                    int cantidadPedida = Convert.ToInt32(nudCantidadPedir.Value);
                    int cantidadNueva = cantidadDisponibleActual + cantidadPedida;
                    ActualizarCantidadDisponible(idProducto, cantidadNueva, connection, transaction);

                    // Hacer commit de la transacción
                    transaction.Commit();

                    MessageBox.Show("¡Pedido guardado exitosamente!\n\nSu producto llegará en cualquier momento.", "Guardado exitoso", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Si ocurre un error, hacer rollback de la transacción
                    transaction.Rollback();
                    MessageBox.Show("Error al guardar el pedido: " + ex.Message);
                }
                finally
                {
                    // Cerrar la conexión
                    connection.Close();
                }
                MostrarPedidos();
            }
        }

        private void ActualizarCantidadDisponible(int idProducto, int cantidadNueva, MySqlConnection connection, MySqlTransaction transaction)
        {
            string query = "UPDATE PRODUCTOS SET Cantidad = @cantidadNueva WHERE id_productos = @idProducto";
            var command = new MySqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@cantidadNueva", cantidadNueva);
            command.Parameters.AddWithValue("@idProducto", idProducto);
            command.ExecuteNonQuery();
        }

        private int ObtenerCantidadDisponible(int idProducto, MySqlConnection connection, MySqlTransaction transaction)
        {
            string query = "SELECT Cantidad FROM PRODUCTOS WHERE id_productos = @idProducto";
            var command = new MySqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@idProducto", idProducto);
            int cantidadDisponible = Convert.ToInt32(command.ExecuteScalar());
            return cantidadDisponible;
        }

        private void CargarProveedores()
        {
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                connection.Open();
                var command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT Nombre FROM Proveedores";

                // Crear un adaptador de datos y llenar el ComboBox con los datos de la tabla de proveedores
                var adapter = new MySqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                cbProveedor.DataSource = dataTable;
                cbProveedor.DisplayMember = "Nombre";
                cbProveedor.ValueMember = "Nombre";
            }
        }

        private void CargarProductosProveedores()
        {
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                connection.Open();
                var command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT id_productos, Nombre_del_producto FROM PRODUCTOS";

                // Crear un adaptador de datos y llenar el ComboBox con los datos de la tabla de productos
                var adapter = new MySqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                cbProducto.DataSource = dataTable;
                cbProducto.DisplayMember = "Nombre_del_producto";
                cbProducto.ValueMember = "id_productos";
            }
        }

        private void MostrarPedidos()
        {
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new MySqlCommand();
                    command.Connection = connection;
                    // Configurar el comando con la consulta
                    command.CommandText = "SELECT pp.id_orden AS id_pedido, pp.Fecha_Orden AS Fecha, pp.Proveedores_id_Proveedor AS IDProveedor, " +
                                           "p.Nombre AS Proveedor, ds.PRODUCTOS_id_productos AS IDProducto, prod.Nombre_del_producto AS Producto, " +
                                           "ds.PedidosProveedores_id_orden AS Pedidos, ds.CantidadPedida, " +
                                           "(ds.CantidadPedida * prod.Precio_del_producto) AS Total " +
                                           "FROM PedidosProveedores pp " +
                                           "INNER JOIN Proveedores p ON pp.Proveedores_id_Proveedor = p.id_Proveedor " +
                                           "INNER JOIN DetalleSuministro ds ON pp.id_orden = ds.PedidosProveedores_id_orden " +
                                           "INNER JOIN PRODUCTOS prod ON ds.PRODUCTOS_id_productos = prod.id_productos";

                    // Crear el adaptador y llenar el DataTable
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Asignar el DataTable al DataSource del DataGridView
                    dgvPedidos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los pedidos: " + ex.Message);
                }
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permite solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}

