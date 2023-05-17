namespace Presentacion.Formularios.Productos
{
    partial class EditarProductos
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
            this.nudEditarCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtEditarPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nudEditarTalla = new System.Windows.Forms.NumericUpDown();
            this.lblTalla = new System.Windows.Forms.Label();
            this.txtEditarNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.btnCerrarP = new FontAwesome.Sharp.IconButton();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProveedoresE = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditarCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditarTalla)).BeginInit();
            this.SuspendLayout();
            // 
            // nudEditarCantidad
            // 
            this.nudEditarCantidad.Location = new System.Drawing.Point(36, 266);
            this.nudEditarCantidad.Name = "nudEditarCantidad";
            this.nudEditarCantidad.Size = new System.Drawing.Size(363, 22);
            this.nudEditarCantidad.TabIndex = 30;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(33, 242);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 16);
            this.lblCantidad.TabIndex = 29;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtEditarPrecio
            // 
            this.txtEditarPrecio.Location = new System.Drawing.Point(36, 197);
            this.txtEditarPrecio.Name = "txtEditarPrecio";
            this.txtEditarPrecio.Size = new System.Drawing.Size(363, 22);
            this.txtEditarPrecio.TabIndex = 28;
            this.txtEditarPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEditarPrecio_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(33, 173);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 27;
            this.lblPrecio.Text = "Precio";
            // 
            // nudEditarTalla
            // 
            this.nudEditarTalla.Location = new System.Drawing.Point(36, 132);
            this.nudEditarTalla.Name = "nudEditarTalla";
            this.nudEditarTalla.Size = new System.Drawing.Size(363, 22);
            this.nudEditarTalla.TabIndex = 26;
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.ForeColor = System.Drawing.Color.White;
            this.lblTalla.Location = new System.Drawing.Point(33, 108);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(38, 16);
            this.lblTalla.TabIndex = 25;
            this.lblTalla.Text = "Talla";
            // 
            // txtEditarNombreProducto
            // 
            this.txtEditarNombreProducto.Location = new System.Drawing.Point(36, 69);
            this.txtEditarNombreProducto.Name = "txtEditarNombreProducto";
            this.txtEditarNombreProducto.Size = new System.Drawing.Size(363, 22);
            this.txtEditarNombreProducto.TabIndex = 24;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.ForeColor = System.Drawing.Color.White;
            this.lblNombreProducto.Location = new System.Drawing.Point(33, 45);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(134, 16);
            this.lblNombreProducto.TabIndex = 23;
            this.lblNombreProducto.Text = "Nombre del producto";
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
            this.btnCerrarP.Location = new System.Drawing.Point(65, 480);
            this.btnCerrarP.Name = "btnCerrarP";
            this.btnCerrarP.Size = new System.Drawing.Size(305, 60);
            this.btnCerrarP.TabIndex = 22;
            this.btnCerrarP.Text = "Salir";
            this.btnCerrarP.UseVisualStyleBackColor = false;
            this.btnCerrarP.Click += new System.EventHandler(this.btnCerrarP_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.White;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnActualizar.IconColor = System.Drawing.Color.Black;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(65, 401);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(305, 60);
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.Text = "Actualizar Producto";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Proveedor";
            // 
            // cbProveedoresE
            // 
            this.cbProveedoresE.FormattingEnabled = true;
            this.cbProveedoresE.Location = new System.Drawing.Point(36, 335);
            this.cbProveedoresE.Name = "cbProveedoresE";
            this.cbProveedoresE.Size = new System.Drawing.Size(363, 24);
            this.cbProveedoresE.TabIndex = 32;
            // 
            // EditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(449, 666);
            this.ControlBox = false;
            this.Controls.Add(this.cbProveedoresE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudEditarCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtEditarPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.nudEditarTalla);
            this.Controls.Add(this.lblTalla);
            this.Controls.Add(this.txtEditarNombreProducto);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.btnCerrarP);
            this.Controls.Add(this.btnActualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarProductos";
            this.Load += new System.EventHandler(this.EditarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudEditarCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditarTalla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudEditarCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtEditarPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown nudEditarTalla;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.TextBox txtEditarNombreProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private FontAwesome.Sharp.IconButton btnCerrarP;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProveedoresE;
    }
}