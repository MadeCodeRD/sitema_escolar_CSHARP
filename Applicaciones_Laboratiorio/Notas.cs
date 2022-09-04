using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Applicaciones_Laboratiorio
{
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Documento de texto |*.txt";
            save.Title = "Guardar Notas...";
            save.FileName = "Guarda Nota Personal 1";

            var notas = save.ShowDialog();

            if(notas == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(save.FileName);

                foreach (object item in richTextBox1.Lines)
                {
                    streamWriter.WriteLine(item);
                }

                streamWriter.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Documento de texto | *.txt";
            openFile.Title = "Abrir Notas...";
            openFile.FileName = "Abrir Nota Personal...";

            var abrir = openFile.ShowDialog();

            if(abrir == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFile.FileName);
                richTextBox1.Text=streamReader.ReadToEnd();
                streamReader.Close();
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
