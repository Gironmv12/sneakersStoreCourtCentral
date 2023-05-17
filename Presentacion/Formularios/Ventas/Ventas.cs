using AcessoDatos;
using Dominio.metodos;
using MySql.Data.MySqlClient;
using Presentacion.Formularios.Cliente;
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

namespace Presentacion.Formularios.Ventas
{
    public partial class Ventas : Form
    {

        
        public Ventas()
        {
            InitializeComponent();
            timer1.Start();
            BackColor= Color.White;

            dgvProductosAgregados.Columns.Add("ID_Producto", "ID_Producto"); // Nueva columna
            dgvProductosAgregados.Columns.Add("Nombre", "Nombre");
            dgvProductosAgregados.Columns.Add("Precio", "Precio");
            dgvProductosAgregados.Columns.Add("Cantidad", "Cantidad");
            dgvProductosAgregados.Columns.Add("Total", "Total");

            dgvProductosAgregados.RowsAdded += dgvProductosAgregados_RowsAdded;
            dgvProductosAgregados.RowsRemoved += dgvProductosAgregados_RowsRemoved;
        }
        public DataGridView ProductosAgregadosTable
        {
            get { return dgvProductosAgregados; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            LlenarComboBoxClientes();
            btnEliminarProductoAgregado.Enabled = false;
            btnAgregarCompra.Enabled = false;
            btnCancelarCompra.Enabled = false;

        }
        private void LlenarComboBoxClientes()
        {
            var listaClientes = rVentas.ObtenerClientes();
            cbCliente.DataSource = listaClientes;
            cbCliente.DisplayMember = "Nombre";
        }

        
        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            // Obtener el ID del cliente seleccionado
            int idCliente = 0;
            try
            {
                coneccionPublica conexion = new coneccionPublica();
                using (var connection = conexion.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT id_Clientes FROM Clientes WHERE Nombre = @nombre";
                    var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", cbCliente.Text.ToLower());
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        idCliente = reader.GetInt32("id_Clientes");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al obtener el ID del cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (idCliente == 0)
            {
                MessageBox.Show("El cliente seleccionado no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal totalVenta = 0;

            // Iterar por cada fila en la tabla de productos agregados
            foreach (DataGridViewRow row in dgvProductosAgregados.Rows)
            {
                if (row.Cells["Nombre"].Value != null && row.Cells["Cantidad"].Value != null && row.Cells["Precio"].Value != null)
                {
                    int cantidadComprada = int.Parse(row.Cells["Cantidad"].Value.ToString());
                    decimal precioVenta = decimal.Parse(row.Cells["Precio"].Value.ToString());
                    totalVenta += cantidadComprada * precioVenta;
                }
            }

            // Insertar la venta y obtener su ID
            int idVenta = rVentas.InsertarVenta(idCliente, DateTime.Now, totalVenta);

            // Iterar por cada fila en la tabla de productos agregados
            foreach (DataGridViewRow row in dgvProductosAgregados.Rows)
            {
                if (row.Cells["Nombre"].Value != null && row.Cells["Cantidad"].Value != null && row.Cells["Precio"].Value != null)
                {
                    int idProducto = rVentas.ObtenerIdProducto(row.Cells["Nombre"].Value.ToString());
                    string nombreProducto = row.Cells["Nombre"].Value.ToString();
                    int cantidadComprada = int.Parse(row.Cells["Cantidad"].Value.ToString());
                    decimal precioVenta = decimal.Parse(row.Cells["Precio"].Value.ToString());

                    // Insertar el detalle de la venta
                    rVentas.InsertarDetalleVenta(idVenta, idProducto, cantidadComprada, precioVenta);

                    // Actualizar la cantidad del producto en la base de datos
                    rVentas.ActualizarCantidadProducto(nombreProducto, cantidadComprada);
                }
            }

            // Limpiar la tabla de productos agregados y actualizar los labels
            dgvProductosAgregados.Rows.Clear();
            lblArticulos.Text = "0";
            lblTotalProductos.Text = "0.00";

            MessageBox.Show("La compra se guardó con éxito!", "Compra guardada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres cancelar la compra?", "Cancelar compra", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Limpiar la tabla de productos agregados y actualizar los labels
                dgvProductosAgregados.Rows.Clear();
                lblArticulos.Text = "0";
                lblTotalProductos.Text = "0.00";
            }
        }

        private void btnEliminarProductoAgregado_Click(object sender, EventArgs e)
        {
            // Obtener la fila seleccionada
            DataGridViewRow selectedRow = dgvProductosAgregados.CurrentRow;
            if (selectedRow == null) return;

            // Obtener el nombre del producto a eliminar
            string nombreProducto = selectedRow.Cells["Nombre"].Value.ToString();

            // Mostrar un mensaje de confirmación
            DialogResult result = MessageBox.Show($"¿Está seguro que desea eliminar el producto '{nombreProducto}'?",
                                                  "Eliminar producto",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Eliminar el producto de la tabla y actualizar los totales
                dgvProductosAgregados.Rows.Remove(selectedRow);
                rVentas.ActualizarTotales(dgvProductosAgregados, lblTotalProductos, lblArticulos); 
            }
        }

        private void dgvProductosAgregados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCantidadProducto_KeyPress(object sender, KeyPressEventArgs e)
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


        private void btnBuscarProductoV_Click(object sender, EventArgs e)
        {
            BProductos bProductos = new BProductos();
            bProductos.ShowDialog();
        }


        public void ActualizarLabels()
        {
            int totalArticulos = dgvProductosAgregados.Rows.Count;
            decimal total = 0;

            // Recorrer las filas de dgvProductosAgregados para calcular el total
            foreach (DataGridViewRow row in dgvProductosAgregados.Rows)
            {
                decimal subtotal = Convert.ToDecimal(row.Cells[4].Value);
                total += subtotal;
            }

            // Actualizar los valores de los labels
            lblArticulos.Text = "Artículos: " + totalArticulos.ToString();
            lblTotalProductos.Text = "Total: " + total.ToString();
        }

        private void dgvProductosAgregados_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Verificar si hay al menos una fila en dgvProductosAgregados
            if (dgvProductosAgregados.Rows.Count > 0)
            {
                // Habilitar los botones
                btnEliminarProductoAgregado.Enabled = true;
                btnAgregarCompra.Enabled = true;
                btnCancelarCompra.Enabled = true;
            }
        }

        private void dgvProductosAgregados_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // Verificar si no quedan filas en dgvProductosAgregados
            if (dgvProductosAgregados.Rows.Count == 0)
            {
                // Deshabilitar los botones
                btnEliminarProductoAgregado.Enabled = false;
                btnAgregarCompra.Enabled = false;
                btnCancelarCompra.Enabled = false;
            }
        }
    }
}
