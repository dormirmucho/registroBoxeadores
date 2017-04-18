using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 ventanaMenu = new Form3();
            ventanaMenu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            Conexion.crearBoxeador(nombre);
        }
    }
}
