using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace BDMiTalller
{
    public partial class Agregar_Usuario : Form
    {
        public Agregar_Usuario()
        {
            InitializeComponent();
        }

        private void eMPLBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eMPLBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataEmpl);

        }

        private void Agregar_Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataEmpl.EMPL' Puede moverla o quitarla según sea necesario.
            this.eMPLTableAdapter.Fill(this.dataEmpl.EMPL);

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            eMPLTableAdapter.AñadirUsr(iDTextBox.Text,usuarioTextBox.Text,contraseñaTextBox.Text);
            eMPLTableAdapter.Fill(dataEmpl.EMPL);
        }

        private void btnModf_Click(object sender, EventArgs e)
        {
            eMPLTableAdapter.ModifUsr(iDTextBox.Text, usuarioTextBox.Text, contraseñaTextBox.Text,iDTextBox.Text,usuarioTextBox.Text,contraseñaTextBox.Text);
            eMPLTableAdapter.Fill(dataEmpl.EMPL);
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
           
            eMPLTableAdapter.Delete(iDTextBox.Text, usuarioTextBox.Text, contraseñaTextBox.Text);
            eMPLTableAdapter.Fill(dataEmpl.EMPL);
        }
    }
}
