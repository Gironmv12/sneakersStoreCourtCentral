using Dominio.metodos;
using Presentacion.Formularios.Porveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Crud.Order.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Presentacion.Formularios.Cliente
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // Obtener los proveedores existentes de la base de datos
            DataTable clientes = aClientes.ObtenerClientes();

            // Asignar los proveedores al DataGridView
            dgvClientesAñadidos.DataSource = clientes;
        }

        private void btnAñadirCliente_Click(object sender, EventArgs e)
        {
            try
            {
                //Validar que los campos no esten vacios
                if (string.IsNullOrWhiteSpace(txtNombreCliente.Text) ||
                    string.IsNullOrWhiteSpace(txtCURPCliente.Text) ||
                    string.IsNullOrWhiteSpace(txtRFC.Text) ||
                    string.IsNullOrWhiteSpace(txtDireccion.Text) || 
                    string.IsNullOrWhiteSpace(txtTelefono.Text) || 
                    string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    throw new Exception("Por favor rellene todo los campos");
                }

                //Obtner los valores del textbox
                string Nombre = txtNombreCliente.Text;
                string CURP = txtCURPCliente.Text;
                string RFC = txtRFC.Text;
                string Direccion = txtDireccion.Text;
                string Telefono = txtTelefono.Text;
                string Email = txtEmail.Text;
                int ClienteDescuento = Convert.ToInt32(nudDescuento.Value);

                //Validar que el nombre no tenga numeros
                if (Nombre.Any(char.IsDigit))
                {
                    throw new Exception("El nombre no debe contener numeros");
                }

                //Validar que el curp no contenga simbolos
                if (!CURP.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
                {
                    throw new Exception("La CURP no debe tener caracteres especiales mas que letras y numeros");
                }

                if (!RFC.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
                {
                    throw new Exception("El RFC no debe tener caracteres especiales mas que letras y numeros");
                }

                if (!Direccion.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
                {
                    throw new Exception("La dirección no debe contener caracteres especiales");
                }

                // Validar que el teléfono contenga solo números
                if (!Telefono.All(char.IsDigit))
                {
                    throw new Exception("El teléfono debe contener solo números");
                }

                // Validar que el email contenga un solo @
                int count = Email.Count(f => f == '@');
                if (count != 1)
                {
                    throw new Exception("El email debe contener un solo @");
                }

                //crear un objeto de la clase clientes
                ClientesA clientesA = new ClientesA(Nombre, RFC, CURP, Telefono, Email, Direccion, ClienteDescuento);

                // Llamar al método AgregarProveedor de la clase aProveedores
                aClientes.AgregarCliente(clientesA);

                // Mostrar el mensaje de que el proveedor ha sido agregado
                MessageBox.Show("¡El cliente ha sido agregado correctamente!", "Cliente agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar el DataGridView con los datos de los proveedores
                DataTable cliente = aClientes.ObtenerClientes();
                dgvClientesAñadidos.DataSource = cliente;

                // Limpiar los campos de texto
                txtNombreCliente.Text = "";
                txtCURPCliente.Text = "";
                txtRFC.Text = "";
                txtTelefono.Text = "";
                txtDireccion.Text = "";
                txtEmail.Text = "";
                nudDescuento.Value = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarCLiente_Click(object sender, EventArgs e)
        {
            if (dgvClientesAñadidos.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int idCliente = Convert.ToInt32(dgvClientesAñadidos.SelectedRows[0].Cells["id_Clientes"].Value);

                    //ELIMINAR EL CLIENTE DE LA BASE DE DATOS
                    aClientes.EliminarCliente(idCliente);

                    // Eliminar la fila correspondiente en el DataGridView
                    dgvClientesAñadidos.Rows.Remove(dgvClientesAñadidos.SelectedRows[0]);
                    // Mostrar MessageBox indicando que se eliminó correctamente
                    MessageBox.Show("El cliente se ha eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
