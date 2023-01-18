using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {


        public Form1()
        {

            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
          

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 af = new Form2();
            af.Owner = this;
            af.Show();
        }

        private void клиентToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 af = new Form3();
            af.Owner = this;
            af.Show();
        }

        private void валютаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 af = new Form4();
            af.Owner = this;
            af.Show();
        }

        private void валютаКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 af = new Form5();
            af.Owner = this;
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 af = new Form6();
            af.Owner = this;
            af.Show();
        }
    }
}
