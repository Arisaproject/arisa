using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace พี่โค้ด
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            label7.Text = Form2.name;
            label8.Text = Form2.lname;
            label9.Text = Form3.fi;
            label10.Text = Form3.data;
            label11.Text = Form3.vala;
            label12.Text = Convert.ToString(Form1.sum);
            label14.Text = Form3.tn;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
