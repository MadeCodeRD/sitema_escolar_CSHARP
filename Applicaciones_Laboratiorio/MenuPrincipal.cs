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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void sUMADORAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 sumadora = new Form1();
            sumadora.Show();
        }

        private void cASADECAMBIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 casaCambio = new Form3();
            casaCambio.Show();
        }

        private void nOMINASEMANALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 nomina = new Form2();
            nomina.Show();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opciones opciones = new Opciones();
            opciones.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void informacionDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda ayuda = new Ayuda();
            ayuda.Show();
        }

        private void apuntasNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notas notas = new Notas();
            notas.Show();
        }

        private void sUMADORAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 sumadora = new Form1();
            sumadora.Show();
        }

        private void cASADECAMBIOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 casaCambio = new Form3();
            casaCambio.Show();
        }

        private void nOMINASEMANALToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 nomina = new Form2();
            nomina.Show();
        }

        private void sALIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Esta seguro desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void oPCIONESDECONSULTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opciones opciones = new Opciones();
            opciones.Show();
        }

        private void uSUARIOSENAGENDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.Show();
        }
    }
}
