using Presentacion.Formularios.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio.metodos;
using AcessoDatos;
using MySql.Data.MySqlClient;

namespace Presentacion.Formularios.Productos
{
    public partial class EditarProductos : Form
    {
        private gProductos producto;
        public EditarProductos( gProductos productos, int proveedorId = 0)
        {
            InitializeComponent();
            this.producto = productos;
            this.producto.ProveedorId = proveedorId;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Obtener los valores actualizados de los controles
            string nombre = txtEditarNombreProducto.Text;
            string talla = nudEditarTalla.Value.ToString();
            decimal precio = Convert.ToDecimal(txtEditarPrecio.Text);
            int cantidad = Convert.ToInt32(nudEditarCantidad.Value);
            int proveedorId = (int)cbProveedoresE.SelectedValue; // Obtener el valor seleccionado del ComboBox 
            try
            {
                precio = Convert.ToDecimal(txtEditarPrecio.Text);
                if (precio < 0)
                {
                    throw new ArgumentException("El precio debe ser mayor o igual a cero.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El precio debe ser un número válido.");
                return;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                proveedorId = (int)cbProveedoresE.SelectedValue;
                if (proveedorId == 0)
                {
                    throw new ArgumentException("Debe seleccionar un proveedor.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                cantidad = Convert.ToInt32(nudEditarCantidad.Value);
                if (cantidad < 0 || cantidad > 999)
                {
                    throw new ArgumentException("La cantidad debe estar entre 0 y 999.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("La cantidad debe ser un número válido.");
                return;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                int tallaInt = Convert.ToInt32(talla);
                if (tallaInt < 0 || tallaInt > 10)
                {
                    throw new ArgumentException("La talla debe estar entre 0 y 10.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("La talla debe ser un número válido.");
                return;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // Asignar los valores actualizados al objeto producto
            producto.Nombre = nombre;
            producto.Talla = talla;
            producto.Precio = precio;
            producto.Cantidad = cantidad;
            producto.ProveedorId = proveedorId; // Asignar el proveedor seleccionado al producto

            if (nombre.Length > 45)
            {
                MessageBox.Show("El nombre del producto no puede tener más de 45 caracteres.");
                return;
            }



            // Actualizar el producto en la base de datos o en la lista de productos
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Crear la consulta SQL para actualizar el producto
                string query = "UPDATE PRODUCTOS SET Nombre_del_producto=@nombre, Talla=@talla, Precio_del_producto=@precio, Cantidad=@cantidad, Proveedor_id=@proveedorId WHERE id_productos=@id";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Asignar los parámetros a la consulta SQL
                command.Parameters.AddWithValue("@nombre", producto.Nombre);
                command.Parameters.AddWithValue("@talla", producto.Talla);
                command.Parameters.AddWithValue("@precio", producto.Precio);
                command.Parameters.AddWithValue("@cantidad", producto.Cantidad);
                command.Parameters.AddWithValue("@proveedorId", producto.ProveedorId); // Agregar el parámetro del proveedor seleccionado
                command.Parameters.AddWithValue("@id", producto.Id);

                // Ejecutar la consulta SQL
                int rowsAffected = command.ExecuteNonQuery();

                // Verificar si la actualización fue exitosa
                if (rowsAffected > 0)
                {
                    MessageBox.Show("¡Producto actualizado correctamente!", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Productos productos = (Productos)Application.OpenForms["Productos"];
                    productos.CargarProductos();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el producto.");
                }

            }
        }

        private void EditarProductos_Load(object sender, EventArgs e)
        {
            // Asignar los valores del producto a los diferentes controles
            txtEditarNombreProducto.Text = producto.Nombre;
            nudEditarTalla.Value = Convert.ToDecimal(producto.Talla);
            txtEditarPrecio.Text = producto.Precio.ToString();
            nudEditarCantidad.Value = producto.Cantidad;

            // Conectar con la base de datos
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())//llamando al metodo de la conexion
            {
                connection.Open();

                // Crear un nuevo comando para obtener los proveedores
                var command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT id_Proveedor, Nombre FROM Proveedores";

                // Crear un nuevo adaptador y llenar un DataTable con los datos de los proveedores
                var adapter = new MySqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Asignar el DataTable al ComboBox
                cbProveedoresE.DisplayMember = "Nombre";
                cbProveedoresE.ValueMember = "id_Proveedor";
                cbProveedoresE.DataSource = dataTable;
            }

            // Seleccionar el proveedor correspondiente en el ComboBox
            string proveedorNombre = ObtenerNombreProveedor(producto.ProveedorId);
            cbProveedoresE.SelectedItem = proveedorNombre;

        }

        private string ObtenerNombreProveedor(int proveedorId)
        {
            // Buscar el nombre del proveedor correspondiente al proveedorId
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT Nombre FROM PROVEEDORES WHERE id_Proveedor=@id_proveedor";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_proveedor", proveedorId);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetString(0);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }



        private void btnCerrarP_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtEditarPrecio_KeyPress(object sender, KeyPressEventArgs e)
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
