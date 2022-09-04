using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicaciones_Laboratiorio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cls_Connection connection = new Cls_Connection();

            if(connection.Validar_Usuario(txtUsuario.Text,txtPassword.Text))
            {
                this.Hide();
                Splash form = new Splash();
                form.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña invalidos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtUsuario.Text = "";
                txtUsuario.Focus();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           if ((MessageBox.Show("Estas seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
