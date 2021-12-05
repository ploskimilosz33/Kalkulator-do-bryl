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
        private double Ps(double r,double l,double h)
        {
            double Ps = Math.PI * r * r + Math.PI * r * l;
            return Ps;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double r, l, h;
            string s1 = textBox1.Text;
            r = double.Parse(s1);
            string s2 = textBox4.Text;
            l = double.Parse(s2);
            string s3 = textBox5.Text;
            h = double.Parse(s3);

            textBox2.Text = Ps(r,l,h).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private double Vs(double r, double h)
        {
            double Vs = (Math.PI * r * r * h)/3;
            return Vs;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            double r, h;

            string s1 = textBox1.Text;
            r = double.Parse(s1);
            string s3 = textBox5.Text;
            h = double.Parse(s3);
            objętość.Text = Vs(r,h).ToString();


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Close();
        }
    }
}
