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
    public partial class Insertar : Form
    {
        Cls_Datos Datos_Class = new Cls_Datos();
        public Insertar()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtNombre.Focus();
                
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Datos_Class.InsertarDatos("agenda", "Nombre,Apellido,Telefono", "'" + txtNombre.Text + "'," + "'" + txtApellido.Text + "'," + "'"+ txtTelefono.Text + "'");
                Limpiar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void Salir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
