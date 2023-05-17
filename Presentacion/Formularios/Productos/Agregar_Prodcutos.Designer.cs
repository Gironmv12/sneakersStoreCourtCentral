namespace Presentacion.Formularios.Productos
{
    partial class Agregar_Prodcutos
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
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblTalla = new System.Windows.Forms.Label();
            this.nudTalla = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnCerrarP = new FontAwesome.Sharp.IconButton();
            this.btnGuardarP = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProveedoresP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTalla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.ForeColor = System.Drawing.Color.White;
            this.lblNombreProducto.Location = new System.Drawing.Point(33, 55);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(150, 18);
            this.lblNombreProducto.TabIndex = 12;
            this.lblNombreProducto.Text = "Nombre del producto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(36, 81);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(367, 22);
            this.txtNombreProducto.TabIndex = 13;
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTalla.ForeColor = System.Drawing.Color.White;
            this.lblTalla.Location = new System.Drawing.Point(33, 114);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(40, 18);
            this.lblTalla.TabIndex = 14;
            this.lblTalla.Text = "Talla";
            // 
            // nudTalla
            // 
            this.nudTalla.Location = new System.Drawing.Point(36, 141);
            this.nudTalla.Name = "nudTalla";
            this.nudTalla.Size = new System.Drawing.Size(367, 22);
            this.nudTalla.TabIndex = 15;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(33, 174);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 18);
            this.lblPrecio.TabIndex = 16;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(36, 200);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(367, 22);
            this.txtPrecio.TabIndex = 17;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(36, 262);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(367, 22);
            this.nudCantidad.TabIndex = 19;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(33, 234);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(69, 18);
            this.lblCantidad.TabIndex = 18;
            this.lblCantidad.Text = "Cantidad";
            // 
            // btnCerrarP
            // 
            this.btnCerrarP.BackColor = System.Drawing.Color.White;
            this.btnCerrarP.FlatAppearance.BorderSize = 0;
            this.btnCerrarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCerrarP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarP.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarP.IconChar = FontAwesome.Sharp.IconChar.CircleChevronLeft;
            this.btnCerrarP.IconColor = System.Drawing.Color.Black;
            this.btnCerrarP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarP.Location = new System.Drawing.Point(61, 485);
            this.btnCerrarP.Name = "btnCerrarP";
            this.btnCerrarP.Size = new System.Drawing.Size(305, 60);
            this.btnCerrarP.TabIndex = 11;
            this.btnCerrarP.Text = "Salir";
            this.btnCerrarP.UseVisualStyleBackColor = false;
            this.btnCerrarP.Click += new System.EventHandler(this.btnCerrarP_Click);
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.BackColor = System.Drawing.Color.White;
            this.btnGuardarP.FlatAppearance.BorderSize = 0;
            this.btnGuardarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnGuardarP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarP.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarP.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardarP.IconColor = System.Drawing.Color.Black;
            this.btnGuardarP.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnGuardarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarP.Location = new System.Drawing.Point(61, 406);
            this.btnGuardarP.Name = "btnGuardarP";
            this.btnGuardarP.Size = new System.Drawing.Size(305, 60);
            this.btnGuardarP.TabIndex = 10;
            this.btnGuardarP.Text = "Guardar";
            this.btnGuardarP.UseVisualStyleBackColor = false;
            this.btnGuardarP.Click += new System.EventHandler(this.btnGuardarP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Proveedor";
            // 
            // cbProveedoresP
            // 
            this.cbProveedoresP.FormattingEnabled = true;
            this.cbProveedoresP.Location = new System.Drawing.Point(36, 323);
            this.cbProveedoresP.Name = "cbProveedoresP";
            this.cbProveedoresP.Size = new System.Drawing.Size(367, 24);
            this.cbProveedoresP.TabIndex = 21;
            // 
            // Agregar_Prodcutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(449, 666);
            this.ControlBox = false;
            this.Controls.Add(this.cbProveedoresP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.nudTalla);
            this.Controls.Add(this.lblTalla);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.btnCerrarP);
            this.Controls.Add(this.btnGuardarP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Agregar_Prodcutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Productos";
            this.Load += new System.EventHandler(this.Agregar_Prodcutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTalla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnGuardarP;
        private FontAwesome.Sharp.IconButton btnCerrarP;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.NumericUpDown nudTalla;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProveedoresP;
    }
}