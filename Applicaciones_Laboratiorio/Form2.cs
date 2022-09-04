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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int L, Ma, Mi, J, V, S, D, Cant, HE, TotalG;
            L = Ma = Mi = J = V = S = D = 0;
            bool valorIncorrecto = false;
           int[] indexSemanas = { L, Ma, Mi, J, V, S, D };
           TextBox[] diasSemanas = { txtLunes, txtMartes,txtMiercoles,txtJueves,txtViernes,txtSabados,txtDomingos };
            for (int i = 0; i < diasSemanas.Length; i++)
            {
                    if (!(int.TryParse(diasSemanas[i].Text, out indexSemanas[i])))
                    {
                        MessageBox.Show("PAGO DEBE SER NUMERICO", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        valorIncorrecto = true;
                        diasSemanas[i].Clear();
                        
                    }
            }


            if(valorIncorrecto)
            {
                txtSalarioFinal.Text = "DATOS INTRODUCIDOS INCORRECTOS!";
            }
            else
            {
                Cant = indexSemanas.Sum();

                if (Cant > 40)
                {
                    HE = Cant - 40;
                    TotalG = (40 * 220) + (HE * 300);
                }
                else
                {
                    TotalG = Cant * 220;
                }

                txtSalarioFinal.Text =TotalG.ToString("C");
            }


            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtLunes.Text = string.Empty;
            txtMartes.Text = string.Empty;
            txtMiercoles.Text = string.Empty;
            txtJueves.Text = string.Empty;
            txtViernes.Text = string.Empty;
            txtSabados.Text = string.Empty;
            txtDomingos.Text = string.Empty;
            Close();

        }
    }
}
