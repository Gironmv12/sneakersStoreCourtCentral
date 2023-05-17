using AcessoDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Formularios.Productos;
using Dominio.metodos;

namespace Presentacion.Formularios.Productos
{
    public partial class Productos : Form
    {

        public Productos()
        {
            InitializeComponent();
        }

        internal void ActualizarTablaProductos()
        {
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                connection.Open();
                var command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT P.id_Productos as ID, P.Nombre_del_producto as Producto, P.Precio_del_producto as Precio, P.talla as Talla, P.Cantidad, PR.Nombre as Proveedor FROM productos P JOIN Proveedores PR ON P.Proveedor_id = PR.id_Proveedor";

                // Crear un adaptador de datos y llenar el DataGridView con los datos de la tabla de productos
                var adapter = new MySqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvTablaProductos.DataSource = dataTable;

                // Cambiar nombre de las columnas
                dgvTablaProductos.Columns["ID"].HeaderText = "ID";
                dgvTablaProductos.Columns["Producto"].HeaderText = "Producto";
                dgvTablaProductos.Columns["Precio"].HeaderText = "Precio";
                dgvTablaProductos.Columns["Talla"].HeaderText = "Talla";
                dgvTablaProductos.Columns["Cantidad"].HeaderText = "Cantidad";
                dgvTablaProductos.Columns["Proveedor"].HeaderText = "Proveedor";

            }
        }
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            Agregar_Prodcutos agregar_Productos = new Agregar_Prodcutos();
            agregar_Productos.ShowDialog();
             
        }
        private void Productos_Load(object sender, EventArgs e)
        {
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                connection.Open();
                var command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT productos.id_Productos as ID, productos.Nombre_del_producto as Producto, productos.Precio_del_producto as Precio, productos.talla as Talla, productos.Cantidad, proveedores.Nombre as Proveedor FROM productos INNER JOIN proveedores ON productos.Proveedor_id = proveedores.id_Proveedor";

                // Crear un adaptador de datos y llenar el DataGridView con los datos de la tabla de productos
                var adapter = new MySqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvTablaProductos.DataSource = dataTable;

                // Cambiar nombre de las columnas
                dgvTablaProductos.Columns["ID"].HeaderText = "ID";
                dgvTablaProductos.Columns["Producto"].HeaderText = "Producto";
                dgvTablaProductos.Columns["Precio"].HeaderText = "Precio";
                dgvTablaProductos.Columns["Talla"].HeaderText = "Talla";
                dgvTablaProductos.Columns["Cantidad"].HeaderText = "Cantidad";
                dgvTablaProductos.Columns["Proveedor"].HeaderText = "Proveedor";

                dgvTablaProductos.ReadOnly = true;//sirve para que el usuario no edite nada de la tabla
            }

            dgvTablaProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            // Verificar si hay un producto seleccionado en el DataGridView dgvTablaProductos
            if (dgvTablaProductos.SelectedRows.Count > 0)
            {
                // Obtener los datos del producto seleccionado
                int id = Convert.ToInt32(dgvTablaProductos.SelectedRows[0].Cells["Id"].Value);
                string nombre = dgvTablaProductos.CurrentRow.Cells["Producto"].Value.ToString();
                string talla = Convert.ToString(dgvTablaProductos.SelectedRows[0].Cells["Talla"].Value);
                decimal precio = Convert.ToDecimal(dgvTablaProductos.SelectedRows[0].Cells["Precio"].Value);
                int cantidad = Convert.ToInt32(dgvTablaProductos.SelectedRows[0].Cells["Cantidad"].Value);

                // Crear un objeto gProductos con los datos obtenidos
                gProductos producto = new gProductos(id, nombre, talla, precio, cantidad);

                // Crear un objeto del formulario EditarProductos y pasarle el objeto producto
                EditarProductos formularioEditar = new EditarProductos(producto);
                formularioEditar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un producto para editar.", "Editar producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void CargarProductos()
        {
            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                connection.Open();
                var command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT productos.id_Productos as ID, productos.Nombre_del_producto as Producto, productos.Precio_del_producto as Precio, productos.talla as Talla, productos.Cantidad, proveedores.Nombre as Proveedor FROM productos INNER JOIN proveedores ON productos.Proveedor_id = proveedores.id_Proveedor";

                var adapter = new MySqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvTablaProductos.DataSource = dataTable;

                dgvTablaProductos.Columns["ID"].HeaderText = "ID";
                dgvTablaProductos.Columns["Producto"].HeaderText = "Producto";
                dgvTablaProductos.Columns["Precio"].HeaderText = "Precio";
                dgvTablaProductos.Columns["Talla"].HeaderText = "Talla";
                dgvTablaProductos.Columns["Cantidad"].HeaderText = "Cantidad";
                dgvTablaProductos.Columns["Proveedor"].HeaderText = "Proveedor";

                dgvTablaProductos.ReadOnly = true;
            }

            dgvTablaProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            // Verificar que se haya seleccionado una fila
            if (dgvTablaProductos.SelectedRows.Count > 0)
            {
                int idProducto = Convert.ToInt32(dgvTablaProductos.SelectedRows[0].Cells["ID"].Value);
                // Confirmar si el usuario desea eliminar el producto
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el producto seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    coneccionPublica conexion = new coneccionPublica();
                    using (var connection = conexion.GetConnection())
                    {
                        connection.Open();
                        var command = new MySqlCommand();
                        command.Connection = connection;
                        command.CommandText = "DELETE FROM DetalleVenta WHERE PRODUCTOS_id_productos = @idProducto";
                        command.Parameters.AddWithValue("@idProducto", idProducto);
                        command.ExecuteNonQuery();
                    }

                    using (var connection = conexion.GetConnection())
                    {
                        connection.Open();
                        var command = new MySqlCommand();
                        command.Connection = connection;
                        command.CommandText = "DELETE FROM productos WHERE id_productos = @idProducto";
                        command.Parameters.AddWithValue("@idProducto", idProducto);
                        command.ExecuteNonQuery();
                    }
                    CargarProductos();
                }
            }
            else
            {
                CargarProductos();
            }
        }
    }
}
