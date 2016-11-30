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
        public static string data;
        public static string vala;
        public static string fi;
        public static string tn;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTimePicker time = dateTimePicker1;
            data = "วัน " + time.Value.Day + " เดือน " + time.Value.Month + " ปี " + time.Value.Year;
            vala = comboBox2.SelectedItem.ToString();
            fi = comboBox1.SelectedItem.ToString();
            CheckBox[] cb = {checkBox1,checkBox2,checkBox3,checkBox4,checkBox5,checkBox6,checkBox7,checkBox8,checkBox9,checkBox10 };

            for (int i = 0; i < cb.Length; i++)
            {
                if (cb[i].Checked)
                {
                    tn = tn + "คุณเลือกที่นั่งที่ "+i + "\n";
                }
            }
            Form4 sh4 = new Form4();
            sh4.Show();
        }
    }
}
