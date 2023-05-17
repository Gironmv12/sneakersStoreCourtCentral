namespace Presentacion.Formularios.Reporte
{
    partial class Reporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTextoReporte = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tcOpciones = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnDescargarReporte = new FontAwesome.Sharp.IconButton();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvVentasGenerales = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBuscarDetalleVenta = new FontAwesome.Sharp.IconButton();
            this.dtpFechaFinD = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaInicioD = new System.Windows.Forms.DateTimePicker();
            this.btnDescargarDetalle = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTextoReporte.SuspendLayout();
            this.tcOpciones.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasGenerales)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTextoReporte
            // 
            this.panelTextoReporte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTextoReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.panelTextoReporte.Controls.Add(this.label1);
            this.panelTextoReporte.Location = new System.Drawing.Point(0, 0);
            this.panelTextoReporte.Name = "panelTextoReporte";
            this.panelTextoReporte.Size = new System.Drawing.Size(1070, 53);
            this.panelTextoReporte.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(493, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "REPORTES";
            // 
            // tcOpciones
            // 
            this.tcOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcOpciones.Controls.Add(this.tabPage1);
            this.tcOpciones.Controls.Add(this.tabPage2);
            this.tcOpciones.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcOpciones.ItemSize = new System.Drawing.Size(150, 30);
            this.tcOpciones.Location = new System.Drawing.Point(0, 53);
            this.tcOpciones.Name = "tcOpciones";
            this.tcOpciones.SelectedIndex = 0;
            this.tcOpciones.Size = new System.Drawing.Size(1070, 617);
            this.tcOpciones.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1062, 579);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ventas Generales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.dtpFechaFin);
            this.panel1.Controls.Add(this.lblFechaFin);
            this.panel1.Controls.Add(this.dtpFechaInicio);
            this.panel1.Controls.Add(this.btnDescargarReporte);
            this.panel1.Controls.Add(this.lblFechaInicio);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(3, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 521);
            this.panel1.TabIndex = 11;
            // 
            // btnBuscar
            // 
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 28;
            this.btnBuscar.Location = new System.Drawing.Point(824, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(183, 40);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(578, 28);
            this.dtpFechaFin.MaximumSize = new System.Drawing.Size(200, 40);
            this.dtpFechaFin.MinimumSize = new System.Drawing.Size(200, 30);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 30);
            this.dtpFechaFin.TabIndex = 14;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.ForeColor = System.Drawing.Color.Black;
            this.lblFechaFin.Location = new System.Drawing.Point(470, 35);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(78, 21);
            this.lblFechaFin.TabIndex = 13;
            this.lblFechaFin.Text = "Fecha fin";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(184, 26);
            this.dtpFechaInicio.MinimumSize = new System.Drawing.Size(200, 30);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 30);
            this.dtpFechaInicio.TabIndex = 12;
            // 
            // btnDescargarReporte
            // 
            this.btnDescargarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnDescargarReporte.ForeColor = System.Drawing.Color.White;
            this.btnDescargarReporte.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnDescargarReporte.IconColor = System.Drawing.Color.White;
            this.btnDescargarReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescargarReporte.IconSize = 28;
            this.btnDescargarReporte.Location = new System.Drawing.Point(33, 100);
            this.btnDescargarReporte.Name = "btnDescargarReporte";
            this.btnDescargarReporte.Size = new System.Drawing.Size(183, 48);
            this.btnDescargarReporte.TabIndex = 16;
            this.btnDescargarReporte.Text = "Descargar";
            this.btnDescargarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescargarReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescargarReporte.UseVisualStyleBackColor = false;
            this.btnDescargarReporte.Click += new System.EventHandler(this.btnDescargarReporte_Click);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ForeColor = System.Drawing.Color.Black;
            this.lblFechaInicio.Location = new System.Drawing.Point(26, 33);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(121, 21);
            this.lblFechaInicio.TabIndex = 10;
            this.lblFechaInicio.Text = "Fecha de inicio";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dgvVentasGenerales);
            this.panel3.Location = new System.Drawing.Point(33, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(974, 335);
            this.panel3.TabIndex = 11;
            // 
            // dgvVentasGenerales
            // 
            this.dgvVentasGenerales.AllowUserToAddRows = false;
            this.dgvVentasGenerales.AllowUserToDeleteRows = false;
            this.dgvVentasGenerales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentasGenerales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentasGenerales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVentasGenerales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasGenerales.Location = new System.Drawing.Point(3, 3);
            this.dgvVentasGenerales.Name = "dgvVentasGenerales";
            this.dgvVentasGenerales.ReadOnly = true;
            this.dgvVentasGenerales.RowHeadersWidth = 51;
            this.dgvVentasGenerales.RowTemplate.Height = 24;
            this.dgvVentasGenerales.Size = new System.Drawing.Size(968, 329);
            this.dgvVentasGenerales.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 52);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(436, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "VENTAS GENERALES";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1062, 579);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle Venta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.btnBuscarDetalleVenta);
            this.panel5.Controls.Add(this.dtpFechaFinD);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.dtpFechaInicioD);
            this.panel5.Controls.Add(this.btnDescargarDetalle);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1056, 521);
            this.panel5.TabIndex = 12;
            // 
            // btnBuscarDetalleVenta
            // 
            this.btnBuscarDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarDetalleVenta.IconColor = System.Drawing.Color.Black;
            this.btnBuscarDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarDetalleVenta.IconSize = 28;
            this.btnBuscarDetalleVenta.Location = new System.Drawing.Point(824, 28);
            this.btnBuscarDetalleVenta.Name = "btnBuscarDetalleVenta";
            this.btnBuscarDetalleVenta.Size = new System.Drawing.Size(183, 40);
            this.btnBuscarDetalleVenta.TabIndex = 15;
            this.btnBuscarDetalleVenta.Text = "Buscar";
            this.btnBuscarDetalleVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarDetalleVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarDetalleVenta.UseVisualStyleBackColor = true;
            this.btnBuscarDetalleVenta.Click += new System.EventHandler(this.btnBuscarDetalleVenta_Click);
            // 
            // dtpFechaFinD
            // 
            this.dtpFechaFinD.Location = new System.Drawing.Point(203, 75);
            this.dtpFechaFinD.MaximumSize = new System.Drawing.Size(200, 40);
            this.dtpFechaFinD.MinimumSize = new System.Drawing.Size(200, 30);
            this.dtpFechaFinD.Name = "dtpFechaFinD";
            this.dtpFechaFinD.Size = new System.Drawing.Size(200, 30);
            this.dtpFechaFinD.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(34, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha fin";
            // 
            // dtpFechaInicioD
            // 
            this.dtpFechaInicioD.Location = new System.Drawing.Point(203, 26);
            this.dtpFechaInicioD.MinimumSize = new System.Drawing.Size(200, 30);
            this.dtpFechaInicioD.Name = "dtpFechaInicioD";
            this.dtpFechaInicioD.Size = new System.Drawing.Size(200, 30);
            this.dtpFechaInicioD.TabIndex = 12;
            // 
            // btnDescargarDetalle
            // 
            this.btnDescargarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnDescargarDetalle.ForeColor = System.Drawing.Color.White;
            this.btnDescargarDetalle.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnDescargarDetalle.IconColor = System.Drawing.Color.White;
            this.btnDescargarDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescargarDetalle.IconSize = 28;
            this.btnDescargarDetalle.Location = new System.Drawing.Point(824, 100);
            this.btnDescargarDetalle.Name = "btnDescargarDetalle";
            this.btnDescargarDetalle.Size = new System.Drawing.Size(183, 48);
            this.btnDescargarDetalle.TabIndex = 16;
            this.btnDescargarDetalle.Text = "Descargar";
            this.btnDescargarDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescargarDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescargarDetalle.UseVisualStyleBackColor = false;
            this.btnDescargarDetalle.Click += new System.EventHandler(this.btnDescargarDetalle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(34, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha de inicio";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.dgvDetalleVenta);
            this.panel6.Location = new System.Drawing.Point(33, 154);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(997, 335);
            this.panel6.TabIndex = 11;
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AllowUserToDeleteRows = false;
            this.dgvDetalleVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(3, 3);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            this.dgvDetalleVenta.RowHeadersWidth = 51;
            this.dgvDetalleVenta.RowTemplate.Height = 24;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(991, 329);
            this.dgvDetalleVenta.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.Color.Wheat;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1056, 52);
            this.panel4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(32, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "BUSQUEDA DE COMPRA";
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 670);
            this.Controls.Add(this.tcOpciones);
            this.Controls.Add(this.panelTextoReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.panelTextoReporte.ResumeLayout(false);
            this.panelTextoReporte.PerformLayout();
            this.tcOpciones.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasGenerales)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTextoReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcOpciones;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private FontAwesome.Sharp.IconButton btnDescargarReporte;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvVentasGenerales;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnBuscarDetalleVenta;
        private System.Windows.Forms.DateTimePicker dtpFechaFinD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioD;
        private FontAwesome.Sharp.IconButton btnDescargarDetalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
    }
}