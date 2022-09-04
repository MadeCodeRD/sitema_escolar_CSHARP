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
    public partial class Actualizar : Form
    {
        Cls_Datos datos = new Cls_Datos();
        public Actualizar()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataTable dataTable = datos.ConsultasDatos("*", "agenda", "Codigo = '" + txtCodigo.Text + "'");

            if(dataTable.Rows.Count !=0)
            {
                txtNombre.Text = dataTable.Rows[0]["Nombre"].ToString();
                txtApellido.Text = dataTable.Rows[0]["Apellido"].ToString();
                txtTelefono.Text = dataTable.Rows[0]["Telefono"].ToString();
            }

            linkLabel1.Enabled = false;
            txtCodigo.Enabled = false;

        }

        public void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCodigo.Text = "";
            txtTelefono.Text = "";

            linkLabel1.Enabled = true;
            txtCodigo.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            datos.ActualizarDatos("agenda", "Nombre= '" + txtNombre.Text + "',Apellido= '" + txtApellido.Text + "',Telefono= '" + txtTelefono.Text + "'", "Codigo= '" + txtCodigo.Text + "'");
            Limpiar();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
