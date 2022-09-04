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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int num1, num2 ,result;

            if(!(int.TryParse(txtnumero1.Text,out num1)) || !(int.TryParse(txtnumero2.Text, out num2)))
            {
                MessageBox.Show("ERROR, DATO DEBE SER NUMERICO", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtresultado.Text = "ERROR!";
            }
            else
            {
                result = num1 + num2;

                txtresultado.Text = result.ToString();
            }

        }

        private void btnResta_Click(object sender, EventArgs e)
        {

            int num1, num2, result;

            if (!(int.TryParse(txtnumero1.Text, out num1)) || !(int.TryParse(txtnumero2.Text, out num2)))
            {
                MessageBox.Show("ERROR, DATO DEBE SER NUMERICO", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtresultado.Text = "ERROR!";
            }
            else
            {
                result = num1 - num2;

                txtresultado.Text = result.ToString();
            }

        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            int num1, num2, result;

            if (!(int.TryParse(txtnumero1.Text, out num1)) || !(int.TryParse(txtnumero2.Text, out num2)))
            {
                MessageBox.Show("ERROR, DATO DEBE SER NUMERICO", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtresultado.Text = "ERROR!";
            }
            else
            {
                result = num1 * num2;

                txtresultado.Text = result.ToString();
            }

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double num1, num2, result;

            if (!(double.TryParse(txtnumero1.Text, out num1)) || !(double.TryParse(txtnumero2.Text, out num2)))
            {
                MessageBox.Show("ERROR, DATO DEBE SER NUMERICO", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtresultado.Text = "ERROR!";
            }

            else if(num2 ==0)
            {
                txtresultado.Text = "ERROR!";
                label4.Visible = true;
            }
            else
            {
                result = num1 / num2;
                txtresultado.Text = result.ToString();
                label4.Visible = false;
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            txtnumero1.Text = string.Empty;
            txtnumero2.Text = string.Empty;
            txtresultado.Text = string.Empty;
            label4.Visible = false;
            Close();

        }
    }
}
