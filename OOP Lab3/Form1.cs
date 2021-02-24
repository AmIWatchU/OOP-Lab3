using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            combo_b.Items.Add("1.1");
            combo_b.Items.Add("2.3");
            combo_b.Items.Add("4.5");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            double z = 0;
            double x = Convert.ToDouble(textBox_x.Text);
            double eva = Math.E;
            double a3 = 0;


            switch (combo_b.SelectedIndex)
            {
                case 0: b = 1.1; break;
                case 1: b = 2.3; break;
                case 2: b = 4.5; break;

            }

            if (a1.Checked)
                a = 0.8;
                a3 = Math.Pow(a, 3);
            if (a2.Checked)
                a = 1.2;
                a3 = Math.Pow(a, 3);
            if (a_3.Checked)
                a = 1.9;
                 a3 = Math.Pow(a, 3);

            if (z1.Checked == true)
            {
                z = Math.Pow(eva, x);
            }
            if (z2.Checked == true)
            {
                double x2 = Math.Pow(x, 2);
                z = Math.Pow(eva, x2);
            }
            if (z3.Checked == true)
            {
                z = Math.Pow(eva, 3);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void z3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
