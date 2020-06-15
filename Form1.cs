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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoing_Click(object sender, EventArgs e)
        {
            registro();
            txtContr.Text = "**";
        }
        public void registro()
        {
            SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=TallerMecanico;Integrated Security=True");
            conexion.Open();
            SqlCommand consulta = new SqlCommand("select * from EMPL where usuario='" + txtUsr.Text + "' and contraseña='" + txtContr.Text + "'", conexion);
            SqlDataReader eje = consulta.ExecuteReader();
            if (eje.Read() == true)
            {
                MessageBox.Show("Bienvedido" + txtUsr.Text);
                this.Hide();
                Programa abr = new Programa();
                abr.Show();
            }
            else
            {
                Datosmal.Text = "No exite la cuenta";
              //  MessageBox.Show("No existe la cuenta :( ");
                txtUsr.Clear();
                txtContr.Clear();
            }
        }
    }
}
