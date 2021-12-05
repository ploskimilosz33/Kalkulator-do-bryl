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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kolorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void białyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void czerwonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void zielonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void instrukcjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Przykro mi musisz sobie radzić.");
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public static int interwal = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 openForm = new Form3();
            openForm.Show();
            //otwarcie nowego formularza po kliknięciu przycisku
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 openForm = new Form4();
            openForm.Show();
            //otwarcie nowego formularza po kliknięciu przycisku
        }

        private void informacjeOAutorzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anonimowy");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 openForm = new Form5();

            openForm.Show();

        }

        private void ankietaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ankietaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
            //otwarcie nowego formularza po kliknięciu przycisku
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 openForm = new Form6();
            openForm.Show();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = openFileDialog1.FileName;

            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Zwiń_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed) splitContainer1.Panel1Collapsed = false;
            else splitContainer1.Panel1Collapsed = true;
        }
    }
}
