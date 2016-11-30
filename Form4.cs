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
            label7.Text = Form2.name;//รับค่า name จาก Form2 มาแสดงใน label7
            label8.Text = Form2.lname;//รับค่า lname จาก Form2 มาแสดงใน label8
            label9.Text = Form3.fi;//รับค่า fi จาก Form3 มาแสดงใน label9
            label10.Text = Form3.data;//รับค่า data จาก Form3 มาแสดงใน label10
            label11.Text = Form3.vala;//รับค่า vala จาก Form3 มาแสดงใน label11
            label12.Text = Convert.ToString(Form1.sum);//รับค่า sum จาก Form1 มาแสดงใน label12
            label14.Text = Form3.tn;//รับค่า tn จาก Form3 มาแสดงใน label14
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
