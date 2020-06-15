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
    public partial class Agregar_cliente : Form
    {
        public Agregar_cliente()
        {
            InitializeComponent();
        }

        private void eMPLBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eMPLBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataEmpl);

        }

        private void Agregar_cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataClient.Cliet' Puede moverla o quitarla según sea necesario.
            this.clietTableAdapter.Fill(this.dataClient.Cliet);
            // TODO: esta línea de código carga datos en la tabla 'dataEmpl.EMPL' Puede moverla o quitarla según sea necesario.
            this.eMPLTableAdapter.Fill(this.dataEmpl.EMPL);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clietTableAdapter.InsertClient(rFCTextBox.Text, nombreTextBox.Text, domiciloTextBox.Text, telefonoTextBox.Text, correoTextBox.Text);
            clietTableAdapter.Fill(dataClient.Cliet);
        }

        private void button2_Click(object sender, EventArgs e)
        {

           // clietTableAdapter.ModifClient(rFCTextBox.Text, nombreTextBox.Text, domiciloTextBox.Text, telefonoTextBox.Text, correoTextBox.Text,rFCTextBox.Text,nombreTextBox.Text,);
            //clietTableAdapter.Fill(dataClient.Cliet);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            clietTableAdapter.DeleteClient(rFCTextBox.Text, nombreTextBox.Text, domiciloTextBox.Text, telefonoTextBox.Text, correoTextBox.Text);
            clietTableAdapter.Fill(dataClient.Cliet);
        }
    }
}
