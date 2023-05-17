using AcessoDatos;
using Dominio.metodos;
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

namespace Presentacion.Formularios.Ventas
{
    public partial class BProductos : Form
    {
        public BProductos()
        {
            InitializeComponent();
        }


        private void txtBProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela la pulsación de tecla si no es una letra, control o espacio en blanco.
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                string input = txtBProductos.Text.Trim();
                if (input != "")
                {
                    string query = "SELECT p.id_productos AS ID, p.Nombre_del_producto AS Producto, p.Talla, p.Precio_del_producto AS Precio, p.Cantidad, pr.Nombre AS Proveedor " +
                                   "FROM productos p " +
                                   "JOIN proveedores pr ON p.proveedor_id = pr.id_Proveedor " +
                                   "WHERE p.Nombre_del_producto LIKE '%" + input + "%'";

                    coneccionPublica conexion = new coneccionPublica();
                    using (var connection = conexion.GetConnection())
                    {
                        connection.Open();

                        MySqlCommand command = new MySqlCommand(query, connection);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dgvRBProductos.DataSource = table;

                        // Cambiar los encabezados de columna
                        dgvRBProductos.Columns["ID"].HeaderText = "ID";
                        dgvRBProductos.Columns["Producto"].HeaderText = "Producto";
                        dgvRBProductos.Columns["Talla"].HeaderText = "Talla";
                        dgvRBProductos.Columns["Precio"].HeaderText = "Precio";
                        dgvRBProductos.Columns["Cantidad"].HeaderText = "Cantidad";
                        dgvRBProductos.Columns["Proveedor"].HeaderText = "Proveedor";
                    }
                }
            }
        }

        private void btnAñadirP_Click(object sender, EventArgs e)
        {
            if (dgvRBProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvRBProductos.SelectedRows[0];

                Ventas ventasForm = Application.OpenForms.OfType<Ventas>().FirstOrDefault();

                if (ventasForm != null)
                {
                    DataGridView dgvProductosAgregados = ventasForm.ProductosAgregadosTable;

                    // Verificar si hay al menos una fila en dgvProductosAgregados
                    if (dgvProductosAgregados.RowCount > 0)
                    {
                        DataGridViewRow newRow = (DataGridViewRow)dgvProductosAgregados.Rows[0].Clone();
                        newRow.Cells[0].Value = selectedRow.Cells["ID"].Value;
                        newRow.Cells[1].Value = selectedRow.Cells["Producto"].Value;
                        newRow.Cells[2].Value = selectedRow.Cells["Precio"].Value;

                        // Solicitar la cantidad a agregar mediante un cuadro de diálogo
                        int cantidad;
                        if (int.TryParse(DialogBox("Cantidad a agregar:", "Agregar producto"), out cantidad))
                        {
                            newRow.Cells[3].Value = cantidad;

                            // Calcular el total en función de la cantidad y el precio
                            decimal precio = Convert.ToDecimal(newRow.Cells[2].Value);
                            decimal total = cantidad * precio;
                            newRow.Cells[4].Value = total;

                            dgvProductosAgregados.Rows.Add(newRow);
                        }
                        else
                        {
                            MessageBox.Show("La cantidad ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Crear una nueva fila desde cero
                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.CreateCells(dgvProductosAgregados);
                        newRow.Cells[0].Value = selectedRow.Cells["ID"].Value;
                        newRow.Cells[1].Value = selectedRow.Cells["Producto"].Value;
                        newRow.Cells[2].Value = selectedRow.Cells["Precio"].Value;

                        // Solicitar la cantidad a agregar mediante un cuadro de diálogo
                        int cantidad;
                        if (int.TryParse(DialogBox("Cantidad a agregar:", "Agregar producto"), out cantidad))
                        {
                            newRow.Cells[3].Value = cantidad;

                            // Calcular el total en función de la cantidad y el precio
                            decimal precio = Convert.ToDecimal(newRow.Cells[2].Value);
                            decimal total = cantidad * precio;
                            newRow.Cells[4].Value = total;

                            dgvProductosAgregados.Rows.Add(newRow);
                        }
                        else
                        {
                            MessageBox.Show("La cantidad ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                ventasForm.ActualizarLabels();
                Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para agregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string DialogBox(string message, string title)
        {
            Form dialogForm = new Form();
            dialogForm.Text = title;
            dialogForm.StartPosition = FormStartPosition.CenterParent;

            Label label = new Label();
            label.Text = message;
            label.Location = new Point(10, 10);
            label.AutoSize = true;

            TextBox textBox = new TextBox();
            textBox.Location = new Point(10, 40);
            textBox.Size = new Size(200, 20);

            Button buttonOk = new Button();
            buttonOk.Text = "OK";
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(10, 70);
            buttonOk.Size = new Size(75, 23);

            Button buttonCancel = new Button();
            buttonCancel.Text = "Cancel";
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(90, 70);
            buttonCancel.Size = new Size(75, 23);

            // Establecer estilos visuales
            dialogForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialogForm.MaximizeBox = false;
            dialogForm.MinimizeBox = false;
            dialogForm.StartPosition = FormStartPosition.CenterScreen;
            dialogForm.AcceptButton = buttonOk;
            dialogForm.CancelButton = buttonCancel;

            // Diseño del cuadro de diálogo
            dialogForm.ClientSize = new Size(220, 110);
            dialogForm.Controls.Add(label);
            dialogForm.Controls.Add(textBox);
            dialogForm.Controls.Add(buttonOk);
            dialogForm.Controls.Add(buttonCancel);

            string input = "";

            if (dialogForm.ShowDialog() == DialogResult.OK)
            {
                input = textBox.Text;
            }

            return input;
        }
    }
}
