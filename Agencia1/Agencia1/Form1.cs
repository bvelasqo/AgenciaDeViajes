using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Reservas R = new Reservas();

        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            R.MdiParent = this;
            R.Show();
        }
        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Datos D = new Datos(R);
            D.MdiParent = this;
            D.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            R.archivo.Close();
        }
    }
}
