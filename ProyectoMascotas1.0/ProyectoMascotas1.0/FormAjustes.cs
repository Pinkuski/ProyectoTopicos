using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Importamos la libreria SQLSERVER
using System.Data.SqlClient;


namespace ProyectoMascotas1._0
{
    public partial class FormAjustes : Form
    {
        public FormAjustes()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-SOU1PGP;Initial Catalog=ProyectoFinal;Integrated Security=TrueL");
       

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox2.Clear();
            textBox3.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
