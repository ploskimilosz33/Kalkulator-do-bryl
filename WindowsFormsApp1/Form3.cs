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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private double Kula(double r)
        {
            double Kula = 4 * Math.PI * r * r;
            return Kula;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double r;
            string s1 = textBox1.Text;
            r = double.Parse(s1);

            textBox2.Text = Kula(r).ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private double Vk(double r)
        {
            double Vk = 4 / 3 * Math.PI * r * r * r;
            return Vk;
        }
        private void button3_Click(object sender, EventArgs e)
        {

            double r;
            string s2 = textBox1.Text;
            r = double.Parse(s2);

            textBox3.Text = Vk(r).ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Close();
        }
    }
}
