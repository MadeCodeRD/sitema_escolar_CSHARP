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
    public partial class Consultas : Form
    {
        Cls_Datos datos = new Cls_Datos();
        public Consultas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;

            dataGridView1.DataSource = datos.ConsultasDatos("Codigo,Nombre,Apellido,Telefono","agenda", "Nombre= '" + txtBuscar.Text + "' OR Apellido = '" + txtBuscar.Text + "'");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
