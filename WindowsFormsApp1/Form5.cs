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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Close();
        }
        private double pw(double r,double h)
        {
            double pole = 2 * Math.PI * r * r + 2 * Math.PI * r * h;
            return pole;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double r, h;

            string s1 = textBox1.Text;
            r = double.Parse(s1);
            string s2 = textBox5.Text;
            h = double.Parse(s2);
            textBox2.Text = pw(r, h).ToString();
        }
        private double vw(double r, double h)
        {
            double V = Math.PI * r * r * h;
            return V;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double r, h;

            string s1 = textBox1.Text;
            r = double.Parse(s1);
            string s2 = textBox5.Text;
            h = double.Parse(s2);
            textBox3.Text = vw(r,h).ToString();
        }
    }
}
