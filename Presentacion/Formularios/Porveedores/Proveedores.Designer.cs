namespace Presentacion.Formularios.Porveedores
{
    partial class Proveedores
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
            this.titulo_proveedores = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEliminarProveedor = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProveedoresAlta = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAñadirProveedores = new FontAwesome.Sharp.IconButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.lblEmailProveedor = new System.Windows.Forms.Label();
            this.lblTelefonoProveedor = new System.Windows.Forms.Label();
            this.lblDireccionProveedor = new System.Windows.Forms.Label();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.tcAlta = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGuardarPedido = new FontAwesome.Sharp.IconButton();
            this.nudCantidadPedir = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.titulo_proveedores.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedoresAlta)).BeginInit();
            this.panel1.SuspendLayout();
            this.tcAlta.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPedir)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo_proveedores
            // 
            this.titulo_proveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.titulo_proveedores.Controls.Add(this.label1);
            this.titulo_proveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.titulo_proveedores.Location = new System.Drawing.Point(0, 0);
            this.titulo_proveedores.Name = "titulo_proveedores";
            this.titulo_proveedores.Size = new System.Drawing.Size(1070, 55);
            this.titulo_proveedores.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(626, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proveedores";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1062, 584);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alta proveedores";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEliminarProveedor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 514);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1056, 67);
            this.panel3.TabIndex = 2;
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEliminarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProveedor.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnEliminarProveedor.IconColor = System.Drawing.Color.White;
            this.btnEliminarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarProveedor.IconSize = 40;
            this.btnEliminarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProveedor.Location = new System.Drawing.Point(52, 0);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(308, 52);
            this.btnEliminarProveedor.TabIndex = 3;
            this.btnEliminarProveedor.Text = "Eliminar Proveedor";
            this.btnEliminarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarProveedor.UseVisualStyleBackColor = false;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvProveedoresAlta);
            this.panel2.Location = new System.Drawing.Point(3, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1059, 314);
            this.panel2.TabIndex = 1;
            // 
            // dgvProveedoresAlta
            // 
            this.dgvProveedoresAlta.AllowUserToAddRows = false;
            this.dgvProveedoresAlta.AllowUserToDeleteRows = false;
            this.dgvProveedoresAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProveedoresAlta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedoresAlta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProveedoresAlta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.dgvProveedoresAlta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedoresAlta.Location = new System.Drawing.Point(52, 23);
            this.dgvProveedoresAlta.Name = "dgvProveedoresAlta";
            this.dgvProveedoresAlta.ReadOnly = true;
            this.dgvProveedoresAlta.RowHeadersWidth = 51;
            this.dgvProveedoresAlta.RowTemplate.Height = 24;
            this.dgvProveedoresAlta.Size = new System.Drawing.Size(953, 276);
            this.dgvProveedoresAlta.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAñadirProveedores);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtNombreProveedor);
            this.panel1.Controls.Add(this.lblEmailProveedor);
            this.panel1.Controls.Add(this.lblTelefonoProveedor);
            this.panel1.Controls.Add(this.lblDireccionProveedor);
            this.panel1.Controls.Add(this.lblNombreProveedor);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 185);
            this.panel1.TabIndex = 0;
            // 
            // btnAñadirProveedores
            // 
            this.btnAñadirProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAñadirProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.btnAñadirProveedores.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirProveedores.ForeColor = System.Drawing.Color.White;
            this.btnAñadirProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnAñadirProveedores.IconColor = System.Drawing.Color.White;
            this.btnAñadirProveedores.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAñadirProveedores.IconSize = 40;
            this.btnAñadirProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadirProveedores.Location = new System.Drawing.Point(675, 27);
            this.btnAñadirProveedores.Margin = new System.Windows.Forms.Padding(0);
            this.btnAñadirProveedores.Name = "btnAñadirProveedores";
            this.btnAñadirProveedores.Size = new System.Drawing.Size(160, 52);
            this.btnAñadirProveedores.TabIndex = 10;
            this.btnAñadirProveedores.Text = "Añadir";
            this.btnAñadirProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadirProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAñadirProveedores.UseVisualStyleBackColor = false;
            this.btnAñadirProveedores.Click += new System.EventHandler(this.btnAñadirProveedores_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(246, 117);
            this.txtEmail.MaximumSize = new System.Drawing.Size(333, 25);
            this.txtEmail.MinimumSize = new System.Drawing.Size(333, 25);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(333, 23);
            this.txtEmail.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.Location = new System.Drawing.Point(246, 86);
            this.txtTelefono.MaximumSize = new System.Drawing.Size(333, 25);
            this.txtTelefono.MinimumSize = new System.Drawing.Size(333, 25);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(333, 23);
            this.txtTelefono.TabIndex = 8;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Location = new System.Drawing.Point(246, 55);
            this.txtDireccion.MaximumSize = new System.Drawing.Size(333, 25);
            this.txtDireccion.MinimumSize = new System.Drawing.Size(333, 25);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(333, 23);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreProveedor.Location = new System.Drawing.Point(246, 24);
            this.txtNombreProveedor.MaximumSize = new System.Drawing.Size(333, 25);
            this.txtNombreProveedor.MinimumSize = new System.Drawing.Size(333, 25);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(333, 23);
            this.txtNombreProveedor.TabIndex = 6;
            // 
            // lblEmailProveedor
            // 
            this.lblEmailProveedor.AutoSize = true;
            this.lblEmailProveedor.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailProveedor.Location = new System.Drawing.Point(49, 120);
            this.lblEmailProveedor.Name = "lblEmailProveedor";
            this.lblEmailProveedor.Size = new System.Drawing.Size(45, 18);
            this.lblEmailProveedor.TabIndex = 4;
            this.lblEmailProveedor.Text = "Email";
            // 
            // lblTelefonoProveedor
            // 
            this.lblTelefonoProveedor.AutoSize = true;
            this.lblTelefonoProveedor.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoProveedor.Location = new System.Drawing.Point(49, 89);
            this.lblTelefonoProveedor.Name = "lblTelefonoProveedor";
            this.lblTelefonoProveedor.Size = new System.Drawing.Size(62, 18);
            this.lblTelefonoProveedor.TabIndex = 3;
            this.lblTelefonoProveedor.Text = "Telefono";
            // 
            // lblDireccionProveedor
            // 
            this.lblDireccionProveedor.AutoSize = true;
            this.lblDireccionProveedor.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionProveedor.Location = new System.Drawing.Point(49, 58);
            this.lblDireccionProveedor.Name = "lblDireccionProveedor";
            this.lblDireccionProveedor.Size = new System.Drawing.Size(69, 18);
            this.lblDireccionProveedor.TabIndex = 2;
            this.lblDireccionProveedor.Text = "Direccion";
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProveedor.Location = new System.Drawing.Point(49, 27);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(63, 18);
            this.lblNombreProveedor.TabIndex = 1;
            this.lblNombreProveedor.Text = "Nombre";
            // 
            // tcAlta
            // 
            this.tcAlta.Controls.Add(this.tabPage1);
            this.tcAlta.Controls.Add(this.tabPage2);
            this.tcAlta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAlta.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcAlta.Location = new System.Drawing.Point(0, 55);
            this.tcAlta.Name = "tcAlta";
            this.tcAlta.SelectedIndex = 0;
            this.tcAlta.Size = new System.Drawing.Size(1070, 615);
            this.tcAlta.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1062, 584);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pedido a Proveedores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.dgvPedidos);
            this.panel5.Location = new System.Drawing.Point(3, 207);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1056, 374);
            this.panel5.TabIndex = 1;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(33, 28);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.RowTemplate.Height = 24;
            this.dgvPedidos.Size = new System.Drawing.Size(991, 319);
            this.dgvPedidos.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnGuardarPedido);
            this.panel4.Controls.Add(this.nudCantidadPedir);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.cbProducto);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cbProveedor);
            this.panel4.Controls.Add(this.dtpFechaPedido);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1056, 188);
            this.panel4.TabIndex = 0;
            // 
            // btnGuardarPedido
            // 
            this.btnGuardarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.btnGuardarPedido.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPedido.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.btnGuardarPedido.IconColor = System.Drawing.Color.White;
            this.btnGuardarPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarPedido.Location = new System.Drawing.Point(42, 113);
            this.btnGuardarPedido.Name = "btnGuardarPedido";
            this.btnGuardarPedido.Size = new System.Drawing.Size(273, 72);
            this.btnGuardarPedido.TabIndex = 8;
            this.btnGuardarPedido.Text = "Guardar pedido";
            this.btnGuardarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarPedido.UseVisualStyleBackColor = false;
            this.btnGuardarPedido.Click += new System.EventHandler(this.btnGuardarPedido_Click);
            // 
            // nudCantidadPedir
            // 
            this.nudCantidadPedir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCantidadPedir.Location = new System.Drawing.Point(219, 70);
            this.nudCantidadPedir.Name = "nudCantidadPedir";
            this.nudCantidadPedir.Size = new System.Drawing.Size(200, 23);
            this.nudCantidadPedir.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cantidad a pedir";
            // 
            // cbProducto
            // 
            this.cbProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(871, 34);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(138, 26);
            this.cbProducto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(769, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Proveedor";
            // 
            // cbProveedor
            // 
            this.cbProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(591, 36);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(138, 26);
            this.cbProveedor.TabIndex = 2;
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaPedido.Location = new System.Drawing.Point(219, 31);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaPedido.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de pedido";
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 670);
            this.Controls.Add(this.tcAlta);
            this.Controls.Add(this.titulo_proveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            this.titulo_proveedores.ResumeLayout(false);
            this.titulo_proveedores.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedoresAlta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tcAlta.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPedir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titulo_proveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProveedoresAlta;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAñadirProveedores;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label lblEmailProveedor;
        private System.Windows.Forms.Label lblTelefonoProveedor;
        private System.Windows.Forms.Label lblDireccionProveedor;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.TabControl tcAlta;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnEliminarProveedor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnGuardarPedido;
        private System.Windows.Forms.NumericUpDown nudCantidadPedir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvPedidos;
    }
}