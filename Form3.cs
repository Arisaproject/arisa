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
    public partial class Form3 : Form
    {
        public static string data;//ประกาศ data เป็น attribute
        public static string vala;//ประกาศ vala เป็น attribute
        public static string fi;//ประกาศ fi เป็น attribute
        public static string tn;//ประกาศ tn เป็น attribute
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTimePicker time = dateTimePicker1;
            data = "วัน " + time.Value.Day + " เดือน " + time.Value.Month + " ปี " + time.Value.Year;//data = วัน + เดือน + ปี
            vala = comboBox2.SelectedItem.ToString();//เลือก vala จาก comboBox2
            fi = comboBox1.SelectedItem.ToString();//เลือก fi จาก comboBox1
            CheckBox[] cb = {checkBox1,checkBox2,checkBox3,checkBox4,checkBox5,checkBox6,checkBox7,checkBox8,checkBox9,checkBox10 };//ให้ checkBox1,2,3,..,10 เป้น array ชื่อว่า cb

            for (int i = 0; i < cb.Length; i++)//วนลูป
            {
                if (cb[i].Checked)//เช็คเงื่อนไข CheckBox
                {
                    tn = tn + "คุณเลือกที่นั่งที่ "+i + "\n";//tn + "คุณเลือกที่นั่งที่ "+i + เว้นบรรทัด
                }
            }
            Form4 sh4 = new Form4();//ประกาศเรียกใช้ Form4
            sh4.Show();//โชว์ Form4
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการย้อนกลับหรือไม่?", "!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)//ถ้าตรงกับเงื่อนไข "คุณต้องการย้อนกลับหรือไม่?", "!!!!", MessageBoxButtons.OKCancel ให้ออกจากหน้านี้
            {
                this.Close();//ปิดหน้านี้
                Form1 sh1 = new Form1();//ประกาศเรียกใช้ Form1
                sh1.Show(); //โชว์ Form1
            }
        }
    }
}
