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
        public static string name;//ประกาศ name เป็น attribute
        public static string lname;//ประกาศ lname เป็น attribute
        public static string iden;//ประกาศ iden เป็น attribute
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
            name = textBox1.Text;//รับค่าจาก textBox1 มาใส่ใน name
            lname = textBox4.Text;//รับค่าจาก textBox4 มาใส่ใน lname
            iden = textBox3.Text;//รับค่าจาก textBox3 มาใส่ใน iiden
            Form1 show = new Form1();//ประกาศเรียกใช้ Form1
            show.Show();//โชว์ Form1
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
