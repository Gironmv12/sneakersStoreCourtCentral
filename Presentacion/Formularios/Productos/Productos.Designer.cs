namespace Presentacion.Formularios.Productos
{
    partial class Productos
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditarProducto = new FontAwesome.Sharp.IconButton();
            this.btnEliminarProducto = new FontAwesome.Sharp.IconButton();
            this.btnNuevoProducto = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTablaProductos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "LISTA DE PRODUCTOS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 79);
            this.panel1.TabIndex = 9;
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarProducto.BackColor = System.Drawing.Color.White;
            this.btnEditarProducto.FlatAppearance.BorderSize = 0;
            this.btnEditarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditarProducto.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnEditarProducto.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEditarProducto.IconColor = System.Drawing.Color.Black;
            this.btnEditarProducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEditarProducto.IconSize = 40;
            this.btnEditarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarProducto.Location = new System.Drawing.Point(818, 159);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(217, 62);
            this.btnEditarProducto.TabIndex = 3;
            this.btnEditarProducto.Text = "Editar Producto";
            this.btnEditarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarProducto.UseVisualStyleBackColor = false;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarProducto.BackColor = System.Drawing.Color.White;
            this.btnEliminarProducto.FlatAppearance.BorderSize = 0;
            this.btnEliminarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminarProducto.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarProducto.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarProducto.IconColor = System.Drawing.Color.Black;
            this.btnEliminarProducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEliminarProducto.IconSize = 40;
            this.btnEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProducto.Location = new System.Drawing.Point(818, 243);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(217, 62);
            this.btnEliminarProducto.TabIndex = 6;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoProducto.BackColor = System.Drawing.Color.White;
            this.btnNuevoProducto.FlatAppearance.BorderSize = 0;
            this.btnNuevoProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNuevoProducto.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.ForeColor = System.Drawing.Color.Black;
            this.btnNuevoProducto.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnNuevoProducto.IconColor = System.Drawing.Color.Black;
            this.btnNuevoProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoProducto.Location = new System.Drawing.Point(818, 85);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(217, 62);
            this.btnNuevoProducto.TabIndex = 2;
            this.btnNuevoProducto.Text = "Nuevo producto";
            this.btnNuevoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoProducto.UseVisualStyleBackColor = false;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvTablaProductos);
            this.groupBox1.Location = new System.Drawing.Point(34, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 520);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // dgvTablaProductos
            // 
            this.dgvTablaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTablaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTablaProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaProductos.Location = new System.Drawing.Point(0, 10);
            this.dgvTablaProductos.Name = "dgvTablaProductos";
            this.dgvTablaProductos.RowHeadersWidth = 51;
            this.dgvTablaProductos.RowTemplate.Height = 24;
            this.dgvTablaProductos.Size = new System.Drawing.Size(735, 510);
            this.dgvTablaProductos.TabIndex = 0;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1070, 670);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnEditarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnEditarProducto;
        private FontAwesome.Sharp.IconButton btnEliminarProducto;
        private FontAwesome.Sharp.IconButton btnNuevoProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTablaProductos;
    }
}