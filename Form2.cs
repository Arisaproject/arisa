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
    public partial class Form2 : Form
    {
        public static string name;
        public static string lname;
        public static string iden;
        public Form2()
        {
            InitializeComponent();
        }

        private void โปรดเข้าสู่ระบบ_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            lname = textBox4.Text;
            iden = textBox3.Text;
            Form1 show = new Form1();
            show.Show();
           
        }
    }
}
