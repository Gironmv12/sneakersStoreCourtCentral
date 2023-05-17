using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using comun.Cache;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;



namespace Presentacion
{
    public partial class MenuPrincipal : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        private Point currentPosition = new Point(285, 75);
        private Size currentSize = new Size(1280, 740);


        //multipoles formularios
        private Form formActual;
        public MenuPrincipal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(8, 45);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        private struct coloresrgb
        {
            public static Color color1 = Color.FromArgb(172,126,241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
        }


        //metodos
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //panel izquierdo

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //cambiar iconos
                IconoPrincipal.IconChar = currentBtn.IconChar;
                IconoPrincipal.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void abrirFormularios(Form formularioAbrir)
        {
            if (formActual != null)
            {
                //abrir el nuevo formulario
                formActual.Close();
            }

            formActual = formularioAbrir;
            formularioAbrir.TopLevel = false;
            formularioAbrir.FormBorderStyle = FormBorderStyle.None;
            formularioAbrir.MinimumSize = new Size(1070, 670); // Cambia los valores según tus necesidades
            formularioAbrir.AutoScaleMode = AutoScaleMode.Dpi;


            panelDesktop.Controls.Add(formularioAbrir);
            panelDesktop.Tag = formularioAbrir;
            formularioAbrir.BringToFront();
            formularioAbrir.Show();
            lblTituloPrincipal.Text = formularioAbrir.Text;
        }

        private void btnProductos_Click(object sender, EventArgs e)//boton de productos
        {
            ActivateButton(sender, coloresrgb.color1);
            abrirFormularios(new Formularios.Productos.Productos());
        }

        private void btnProveedores_Click(object sender, EventArgs e)//boton de porveedores
        {
            ActivateButton(sender, coloresrgb.color3);
            abrirFormularios(new Formularios.Porveedores.Proveedores());
        }

        private void btnVentas_Click(object sender, EventArgs e)//boton de ventas
        {
            ActivateButton(sender, coloresrgb.color2);
            abrirFormularios(new Formularios.Ventas.Ventas());
        }

        private void btnReportes_Click(object sender, EventArgs e)//boton de reportes
        {
            ActivateButton(sender, coloresrgb.color2);
            abrirFormularios(new Formularios.Reporte.Reporte());

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            formActual.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

            IconoPrincipal.IconChar = IconChar.Home;
            IconoPrincipal.IconColor = Color.Black;
            lblTituloPrincipal.Text = "Inicio";
        }

        //biblioteca de DLL
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnSalirSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está usted seguro que quiere cerrar la sesión?", "Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)this.Close();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
            // Establecer los valores iniciales de la posición y el tamaño de la ventana
            this.Location = new Point(285, 75);
            this.Size = new Size(1280, 740);

            // Establecer el rectángulo de maximización (dejar un margen de 10 píxeles)
            Rectangle workingArea = Screen.GetWorkingArea(this);
            int margin = 0;
            Rectangle maxBounds = new Rectangle(workingArea.X + margin, workingArea.Y + margin,
                                                 workingArea.Width - 2 * margin, workingArea.Height - 2 * margin);
            this.MaximizedBounds = maxBounds;


            panelDesktop.Size = new Size(995, 665);
        }
        private void CargarDatosUsuario()
        {
            lblBUsuario.Text = CacheLoginUser.NombreUsuario;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, coloresrgb.color2);
            abrirFormularios(new Formularios.Cliente.Clientes());
        }

    }
}
