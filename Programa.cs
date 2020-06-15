using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDMiTalller
{
    public partial class Programa : Form
    {
        public Programa()
        {
            InitializeComponent();
        }

        private void añadirNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Usuario abr = new Agregar_Usuario();
            abr.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_cliente abr = new Agregar_cliente();
            abr.Show();
        }

        private void refaccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Refacion abr = new Agregar_Refacion();
            abr.Show();
        }
    }
}
