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
using OfficeOpenXml;
using System.IO;
using LicenseContext = OfficeOpenXml.LicenseContext;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using System.Drawing.Printing;


namespace Presentacion.Formularios.Reporte
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Establecer el contexto de licencia
        }


        //======= INICIO DE LA PRIMERA SECCION DE VENTAS GENERALES
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener la fecha de inicio y fin
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFin = dtpFechaFin.Value.Date.AddDays(1); // Agregar un día a la fecha final para incluir la venta del mismo día

            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                connection.Open();

                // Obtener todas las ventas en el rango de fechas especificado
                var command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = @"
            SELECT Ventas.id_Venta, Ventas.Fecha_venta, Ventas.Precio_venta, Clientes.Nombre
            FROM Ventas
            JOIN Clientes ON Ventas.Clientes_id_Clientes = Clientes.id_Clientes
            WHERE Ventas.Fecha_venta >= @fechaInicio AND Ventas.Fecha_venta < @fechaFin";
                command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                command.Parameters.AddWithValue("@fechaFin", fechaFin);

                var ventas = new List<dynamic>();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var venta = new
                    {
                        id_Venta = reader.GetInt32("id_Venta"),
                        Fecha_venta = reader.GetDateTime("Fecha_venta"),
                        Precio_venta = reader.GetDecimal("Precio_venta"),
                        Nombre_cliente = reader.GetString("Nombre")
                    };
                    ventas.Add(venta);
                }
                reader.Close();

                if (ventas.Count > 0)
                {
                    // Mostrar los resultados en el DataGridView
                    dgvVentasGenerales.DataSource = ventas;
                    dgvVentasGenerales.Columns["id_Venta"].HeaderText = "ID Venta";
                    dgvVentasGenerales.Columns["Fecha_venta"].HeaderText = "Fecha de venta";
                    dgvVentasGenerales.Columns["Precio_venta"].HeaderText = "Precio de venta";
                    dgvVentasGenerales.Columns["Nombre_cliente"].HeaderText = "Nombre del cliente";
                }
                else
                {
                    MessageBox.Show("No hay ventas registradas en la fecha especificada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvVentasGenerales.Columns.Clear();
                    dgvVentasGenerales.Rows.Clear();
                }
            }
        }

        private void btnDescargarReporte_Click(object sender, EventArgs e)
        {

            // Verificar que hayan datos en el DataGridView
            if (dgvVentasGenerales.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Crear un nuevo objeto PrintDocument
            PrintDocument pd = new PrintDocument();

            // Configurar el evento PrintPage para agregar el contenido del DataGridView al documento
            pd.PrintPage += new PrintPageEventHandler((s, ev) =>
            {
                // Crear un objeto Graphics para dibujar el contenido del documento
                Graphics g = ev.Graphics;

                // Definir las fuentes que se usarán para el título y los datos
                Font titleFont = new Font("Arial", 16, FontStyle.Bold);
                Font dataFont = new Font("Arial", 10);

                // Definir las coordenadas de la primera fila del DataGridView
                int x = ev.MarginBounds.Left;
                int y = ev.MarginBounds.Top;

                // Agregar el título al documento
                g.DrawString("Reporte de Ventas", titleFont, Brushes.Black, x, y);
                y += titleFont.Height + 20;

                // Agregar los encabezados de columna al documento
                for (int i = 0; i < dgvVentasGenerales.Columns.Count; i++)
                {
                    g.DrawString(dgvVentasGenerales.Columns[i].HeaderText, dataFont, Brushes.Black, x, y);
                    x += dgvVentasGenerales.Columns[i].Width;
                }
                y += dataFont.Height;

                // Agregar los datos de las ventas al documento
                for (int i = 0; i < dgvVentasGenerales.Rows.Count; i++)
                {
                    x = ev.MarginBounds.Left;
                    for (int j = 0; j < dgvVentasGenerales.Columns.Count; j++)
                    {
                        g.DrawString(dgvVentasGenerales.Rows[i].Cells[j].FormattedValue.ToString(), dataFont, Brushes.Black, x, y);
                        x += dgvVentasGenerales.Columns[j].Width;
                    }
                    y += dataFont.Height;
                }
            });

            // Mostrar el cuadro de diálogo de impresión
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        // ========= FIN DE LA SECCION DE VENTAS GENERALES ==========

        // ========= INICIO DE LA SECCION DE DETALLE DE VENTAS ==========
        private void btnBuscarDetalleVenta_Click(object sender, EventArgs e)
        {
            // Obtener la fecha de inicio y fin
            DateTime fechaInicioD = dtpFechaInicioD.Value.Date;
            DateTime fechaFinD = dtpFechaFinD.Value.Date.AddDays(1); // Agregar un día a la fecha final para incluir la venta del mismo día

            coneccionPublica conexion = new coneccionPublica();
            using (var connection = conexion.GetConnection())
            {
                connection.Open();

                // Obtener todas las ventas en el rango de fechas especificado
                var command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT PrecioProducto, Fecha, Cantidad, PRODUCTOS_id_productos, Ventas_id_Venta FROM DetalleVenta WHERE Fecha >= @fechaInicioD AND Fecha < @fechaFinD";
                command.Parameters.AddWithValue("@fechaInicioD", fechaInicioD);
                command.Parameters.AddWithValue("@fechaFinD", fechaFinD);
                var reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    MessageBox.Show("No hay ventas registradas en la fecha especificada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Muestra los detalles de venta en el DataGridView
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvDetalleVenta.DataSource = dt;
                }
            }
        }

        private void btnDescargarDetalle_Click(object sender, EventArgs e)
        {
            // Verificar que hayan datos en el DataGridView
            if (dgvDetalleVenta.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Crear un nuevo archivo Excel
            var fileName = $"Detalles_Ventas_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.xlsx";
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), fileName);

            using (var package = new ExcelPackage())
            {
                // Crear una nueva hoja de cálculo
                var worksheet = package.Workbook.Worksheets.Add("DetalleVentas");

                // Agregar los encabezados de columna
                var headers = new[] { "Precio del Producto", "Fecha", "Cantidad", "ID del producto", "ID de venta" };
                for (var i = 0; i < headers.Length; i++)
                {
                    worksheet.Cells[1, i + 1].Value = headers[i];
                    worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                }

                // Agregar los datos de las ventas
                for (var i = 0; i < dgvDetalleVenta.Rows.Count; i++)
                {
                    var row = dgvDetalleVenta.Rows[i];
                    worksheet.Cells[i + 2, 1].Value = row.Cells["PrecioProducto"].Value;
                    worksheet.Cells[i + 2, 2].Value = row.Cells["Fecha"].Value;
                    worksheet.Cells[i + 2, 3].Value = row.Cells["Cantidad"].Value;
                    worksheet.Cells[i + 2, 4].Value = row.Cells["PRODUCTOS_id_productos"].Value;
                    worksheet.Cells[i + 2, 5].Value = row.Cells["Ventas_id_Venta"].Value;
                }

                // Autoajustar el ancho de las columnas
                worksheet.Cells.AutoFitColumns(0);

                // Guardar el archivo Excel
                File.WriteAllBytes(filePath, package.GetAsByteArray());
            }

            MessageBox.Show($"El reporte se ha guardado en: {filePath}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            // Establecer el formato corto para los controles DateTimePicker
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Format = DateTimePickerFormat.Short;
        }
    }
}
