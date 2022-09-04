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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            double rd, result;
            const double us = 58.25;
            if (!(double.TryParse(txtcantidad.Text,out rd)))
            {
                MessageBox.Show("CANTIDAD DEBE SER NUMERICA", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                result = rd * us;
                txtResultado.Visible = true;
                txtResultado.Text = result.ToString("C");
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            double rd, result;
            const double euro = 69.69;
            if (!(double.TryParse(txtcantidad.Text, out rd)))
            {
                MessageBox.Show("CANTIDAD DEBE SER NUMERICA", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                result = rd * euro;
                txtResultado.Visible = true;
                txtResultado.Text = result.ToString("C");
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            double rd, result;
            const double us = 58.25;
            if (!(double.TryParse(txtcantidad.Text, out rd)))
            {
                MessageBox.Show("CANTIDAD DEBE SER NUMERICA", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                result = rd / us;
                txtResultado.Visible = true;
                txtResultado.Text = string.Format("${0:n3}", result);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtcantidad.Text = string.Empty;
            txtResultado.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
