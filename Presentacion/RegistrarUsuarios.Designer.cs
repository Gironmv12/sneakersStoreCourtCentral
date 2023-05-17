namespace Presentacion
{
    partial class RegistrarUsuarios
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnRegistar = new FontAwesome.Sharp.IconButton();
            this.txtRContraseña = new System.Windows.Forms.TextBox();
            this.lblRContraseña = new System.Windows.Forms.Label();
            this.txtRUsuario = new System.Windows.Forms.TextBox();
            this.lblRUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 453);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Court_Central_Logo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(650, 358);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(246, 16);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Ya estas registrado? Inicia Sesíon aqui";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // btnRegistar
            // 
            this.btnRegistar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(62)))), ((int)(((byte)(255)))));
            this.btnRegistar.ForeColor = System.Drawing.Color.White;
            this.btnRegistar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnRegistar.IconColor = System.Drawing.Color.White;
            this.btnRegistar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistar.Location = new System.Drawing.Point(653, 276);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(342, 60);
            this.btnRegistar.TabIndex = 20;
            this.btnRegistar.Text = "Registrar";
            this.btnRegistar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistar.UseVisualStyleBackColor = false;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // txtRContraseña
            // 
            this.txtRContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRContraseña.Location = new System.Drawing.Point(652, 221);
            this.txtRContraseña.Multiline = true;
            this.txtRContraseña.Name = "txtRContraseña";
            this.txtRContraseña.PasswordChar = '•';
            this.txtRContraseña.Size = new System.Drawing.Size(343, 32);
            this.txtRContraseña.TabIndex = 19;
            // 
            // lblRContraseña
            // 
            this.lblRContraseña.AutoSize = true;
            this.lblRContraseña.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(62)))), ((int)(((byte)(116)))));
            this.lblRContraseña.Location = new System.Drawing.Point(649, 193);
            this.lblRContraseña.Name = "lblRContraseña";
            this.lblRContraseña.Size = new System.Drawing.Size(109, 24);
            this.lblRContraseña.TabIndex = 18;
            this.lblRContraseña.Text = "Contraseña";
            // 
            // txtRUsuario
            // 
            this.txtRUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUsuario.Location = new System.Drawing.Point(651, 140);
            this.txtRUsuario.Multiline = true;
            this.txtRUsuario.Name = "txtRUsuario";
            this.txtRUsuario.Size = new System.Drawing.Size(343, 31);
            this.txtRUsuario.TabIndex = 17;
            // 
            // lblRUsuario
            // 
            this.lblRUsuario.AutoSize = true;
            this.lblRUsuario.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(62)))), ((int)(((byte)(116)))));
            this.lblRUsuario.Location = new System.Drawing.Point(648, 113);
            this.lblRUsuario.Name = "lblRUsuario";
            this.lblRUsuario.Size = new System.Drawing.Size(77, 24);
            this.lblRUsuario.TabIndex = 16;
            this.lblRUsuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(62)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(759, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Registrarse";
            // 
            // RegistrarUsuarios
            // 
            this.AcceptButton = this.btnRegistar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1062, 453);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.txtRContraseña);
            this.Controls.Add(this.lblRContraseña);
            this.Controls.Add(this.txtRUsuario);
            this.Controls.Add(this.lblRUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegistrarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private FontAwesome.Sharp.IconButton btnRegistar;
        private System.Windows.Forms.TextBox txtRContraseña;
        private System.Windows.Forms.Label lblRContraseña;
        private System.Windows.Forms.TextBox txtRUsuario;
        private System.Windows.Forms.Label lblRUsuario;
        private System.Windows.Forms.Label label1;
    }
}