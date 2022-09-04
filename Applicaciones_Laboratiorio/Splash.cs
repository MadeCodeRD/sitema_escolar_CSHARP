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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int counter = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {

            counter += 5;
            label1.Text = counter.ToString();
            if(counter<100)
            {
                progressBar1.Value = counter;
            }
            else
            {
                timer1.Stop();
                this.Hide();
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.ShowDialog();
            }   
        }
    }
}
