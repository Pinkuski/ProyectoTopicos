using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMascotas1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if ((textBox1.Text == "root" && textBox2.Text == "123"))
            {
                Form2 Ingreso = new Form2();
                this.Hide();
                Ingreso.Show();
            }
            else
            {
                MessageBox.Show("Los datos ingresados no son correctos", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
