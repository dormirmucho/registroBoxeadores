using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Introduce datos");
            }
            string tb1 = textBox1.Text, tb2 = textBox2.Text;

            if (ControlUsuario.Instance.Comprobasion(tb1,tb2))
            {
                this.Hide();
                Form3 ventana2 = new Form3();
                ventana2.Show();
            }
            else
            {
                MessageBox.Show("login incorrecto");
            }
        }


    }
}
