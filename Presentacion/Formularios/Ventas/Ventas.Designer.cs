namespace Presentacion.Formularios.Ventas
{
    partial class Ventas
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuscarProductoV = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvProductosAgregados = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancelarCompra = new FontAwesome.Sharp.IconButton();
            this.btnAgregarCompra = new FontAwesome.Sharp.IconButton();
            this.btnEliminarProductoAgregado = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblArticulos = new System.Windows.Forms.Label();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAgregados)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, -9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 50);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(379, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registro de venta";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(101, 20);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 18);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBuscarProductoV);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbCliente);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 120);
            this.panel2.TabIndex = 8;
            // 
            // btnBuscarProductoV
            // 
            this.btnBuscarProductoV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(131)))), ((int)(((byte)(0)))));
            this.btnBuscarProductoV.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProductoV.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProductoV.IconColor = System.Drawing.Color.White;
            this.btnBuscarProductoV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProductoV.IconSize = 40;
            this.btnBuscarProductoV.Location = new System.Drawing.Point(50, 51);
            this.btnBuscarProductoV.Name = "btnBuscarProductoV";
            this.btnBuscarProductoV.Size = new System.Drawing.Size(333, 45);
            this.btnBuscarProductoV.TabIndex = 14;
            this.btnBuscarProductoV.Text = "Buscar producto";
            this.btnBuscarProductoV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProductoV.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarProductoV.UseVisualStyleBackColor = false;
            this.btnBuscarProductoV.Click += new System.EventHandler(this.btnBuscarProductoV_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cliente";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(488, 61);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(200, 26);
            this.cbCliente.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvProductosAgregados);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(699, 500);
            this.panel3.TabIndex = 9;
            // 
            // dgvProductosAgregados
            // 
            this.dgvProductosAgregados.AllowUserToAddRows = false;
            this.dgvProductosAgregados.AllowUserToDeleteRows = false;
            this.dgvProductosAgregados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductosAgregados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosAgregados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductosAgregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosAgregados.Location = new System.Drawing.Point(50, 41);
            this.dgvProductosAgregados.Name = "dgvProductosAgregados";
            this.dgvProductosAgregados.ReadOnly = true;
            this.dgvProductosAgregados.RowHeadersWidth = 51;
            this.dgvProductosAgregados.RowTemplate.Height = 24;
            this.dgvProductosAgregados.Size = new System.Drawing.Size(609, 434);
            this.dgvProductosAgregados.TabIndex = 0;
            this.dgvProductosAgregados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosAgregados_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCancelarCompra);
            this.panel4.Controls.Add(this.btnAgregarCompra);
            this.panel4.Controls.Add(this.btnEliminarProductoAgregado);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lblTotalProductos);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lblArticulos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(699, 170);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(371, 500);
            this.panel4.TabIndex = 10;
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarCompra.BackColor = System.Drawing.Color.White;
            this.btnCancelarCompra.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarCompra.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnCancelarCompra.IconColor = System.Drawing.Color.Black;
            this.btnCancelarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarCompra.IconSize = 40;
            this.btnCancelarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCompra.Location = new System.Drawing.Point(88, 251);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(200, 50);
            this.btnCancelarCompra.TabIndex = 17;
            this.btnCancelarCompra.Text = "Cancelar venta";
            this.btnCancelarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarCompra.UseVisualStyleBackColor = false;
            this.btnCancelarCompra.Click += new System.EventHandler(this.btnCancelarCompra_Click);
            // 
            // btnAgregarCompra
            // 
            this.btnAgregarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCompra.BackColor = System.Drawing.Color.White;
            this.btnAgregarCompra.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarCompra.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnAgregarCompra.IconColor = System.Drawing.Color.Black;
            this.btnAgregarCompra.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAgregarCompra.IconSize = 40;
            this.btnAgregarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCompra.Location = new System.Drawing.Point(88, 184);
            this.btnAgregarCompra.Name = "btnAgregarCompra";
            this.btnAgregarCompra.Size = new System.Drawing.Size(200, 50);
            this.btnAgregarCompra.TabIndex = 16;
            this.btnAgregarCompra.Text = "Guardar Venta";
            this.btnAgregarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarCompra.UseVisualStyleBackColor = false;
            this.btnAgregarCompra.Click += new System.EventHandler(this.btnAgregarCompra_Click);
            // 
            // btnEliminarProductoAgregado
            // 
            this.btnEliminarProductoAgregado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarProductoAgregado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(47)))), ((int)(((byte)(6)))));
            this.btnEliminarProductoAgregado.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProductoAgregado.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminarProductoAgregado.IconColor = System.Drawing.Color.White;
            this.btnEliminarProductoAgregado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarProductoAgregado.IconSize = 40;
            this.btnEliminarProductoAgregado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProductoAgregado.Location = new System.Drawing.Point(88, 119);
            this.btnEliminarProductoAgregado.Name = "btnEliminarProductoAgregado";
            this.btnEliminarProductoAgregado.Size = new System.Drawing.Size(200, 50);
            this.btnEliminarProductoAgregado.TabIndex = 10;
            this.btnEliminarProductoAgregado.Text = "Eliminar Producto";
            this.btnEliminarProductoAgregado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProductoAgregado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarProductoAgregado.UseVisualStyleBackColor = false;
            this.btnEliminarProductoAgregado.Click += new System.EventHandler(this.btnEliminarProductoAgregado_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(170, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 14;
            // 
            // lblTotalProductos
            // 
            this.lblTotalProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalProductos.AutoSize = true;
            this.lblTotalProductos.Location = new System.Drawing.Point(85, 74);
            this.lblTotalProductos.Name = "lblTotalProductos";
            this.lblTotalProductos.Size = new System.Drawing.Size(41, 18);
            this.lblTotalProductos.TabIndex = 13;
            this.lblTotalProductos.Text = "Total:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(170, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 11;
            // 
            // lblArticulos
            // 
            this.lblArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArticulos.AutoSize = true;
            this.lblArticulos.Location = new System.Drawing.Point(85, 41);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(66, 18);
            this.lblArticulos.TabIndex = 10;
            this.lblArticulos.Text = "Articulos:";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1070, 670);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAgregados)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvProductosAgregados;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnCancelarCompra;
        private FontAwesome.Sharp.IconButton btnAgregarCompra;
        private FontAwesome.Sharp.IconButton btnEliminarProductoAgregado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalProductos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblArticulos;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCliente;
        private FontAwesome.Sharp.IconButton btnBuscarProductoV;
    }
}