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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            decimal a = dl_bokua.Value;//Długość boku a trójkąta
            decimal b = dl_bokub.Value;//Długość boku b trójkąta
            decimal c = dl_bokuc.Value;//Długość boku c trójkąta

            decimal obwod = (a + b + c); //obwód trójkąta
            decimal pole = ((a * b) / 2);//pole trójkąta
            if (a > 0 && b > 0 && c > 0 && (a * a + b * b == c * c))
            {

                MessageBox.Show("Obwód tego trójkąta wynosi: " + obwod + " ,a jego pole jest równe: " + pole);
            }//wyświetla wynik

            else
            {
                MessageBox.Show("Podane przez Ciebie długości nie tworzą trójkąta prostokątnego!");
            }

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://pl.wikipedia.org/wiki/Trójkąt_prostokątny");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Close();
        }
    }
}
