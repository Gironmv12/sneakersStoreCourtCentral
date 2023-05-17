namespace Presentacion.Formularios.Ventas
{
    partial class BProductos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAñadirP = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBProductos = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvRBProductos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRBProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAñadirP);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 120);
            this.panel1.TabIndex = 0;
            // 
            // btnAñadirP
            // 
            this.btnAñadirP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.btnAñadirP.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnAñadirP.IconColor = System.Drawing.Color.White;
            this.btnAñadirP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAñadirP.IconSize = 40;
            this.btnAñadirP.Location = new System.Drawing.Point(502, 47);
            this.btnAñadirP.Name = "btnAñadirP";
            this.btnAñadirP.Size = new System.Drawing.Size(95, 46);
            this.btnAñadirP.TabIndex = 1;
            this.btnAñadirP.UseVisualStyleBackColor = false;
            this.btnAñadirP.Click += new System.EventHandler(this.btnAñadirP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBProductos);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(50, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar producto";
            // 
            // txtBProductos
            // 
            this.txtBProductos.Location = new System.Drawing.Point(6, 43);
            this.txtBProductos.MaximumSize = new System.Drawing.Size(400, 30);
            this.txtBProductos.MinimumSize = new System.Drawing.Size(400, 30);
            this.txtBProductos.Name = "txtBProductos";
            this.txtBProductos.Size = new System.Drawing.Size(400, 26);
            this.txtBProductos.TabIndex = 0;
            this.txtBProductos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBProductos_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvRBProductos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 471);
            this.panel3.TabIndex = 10;
            // 
            // dgvRBProductos
            // 
            this.dgvRBProductos.AllowUserToAddRows = false;
            this.dgvRBProductos.AllowUserToDeleteRows = false;
            this.dgvRBProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRBProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRBProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRBProductos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRBProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRBProductos.Location = new System.Drawing.Point(50, 41);
            this.dgvRBProductos.Name = "dgvRBProductos";
            this.dgvRBProductos.ReadOnly = true;
            this.dgvRBProductos.RowHeadersWidth = 51;
            this.dgvRBProductos.RowTemplate.Height = 24;
            this.dgvRBProductos.Size = new System.Drawing.Size(910, 405);
            this.dgvRBProductos.TabIndex = 0;
            // 
            // BProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(101)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1000, 591);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de producto";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRBProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAñadirP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBProductos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvRBProductos;
    }
}