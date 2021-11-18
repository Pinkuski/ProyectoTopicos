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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-SOU1PGP;Initial Catalog=ProyectoFinal;Integrated Security=TrueL");
        private void button1_Click(object sender, EventArgs e)
        {
            
            if ((textBox1.Text == "root" && textBox2.Text == "123"))
            {
                int op = 0;
                Form2 Ingreso = new Form2(op);
                this.Hide();
                Ingreso.Show();
            }
            else
            {
                MessageBox.Show("Los datos ingresados no son correctos", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            int op = 1;
            Form2 Ingreso = new Form2(op);
            this.Hide();
            Ingreso.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
