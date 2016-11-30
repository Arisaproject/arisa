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
    public partial class Form1 : Form
    {
        public static double sum;
        String[] st = { "ประเทศบรูไน", "ดารุสซาลาม", "ประเทศกัมพูชา", "ประเทศอินโดนีเซีย", "ประเทศลาว", "ประเทศมาเลเซีย", "ประเทศเมียนมาร์", "ประเทศฟิลิปปินส์", "ประเทศสิงคโปร์", "ประเทศเวียดนาม", "ประเทศไทย" };
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการออกจากหน้านี้หรือไม่?", "!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
                Form3 sh3 = new Form3();
                sh3.Show();
            }
            string sum = textBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการจะเคลียร์ข้อมูลหรือไม่?", "!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                comboBox1.Text = "";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string str, str2;
                str = (String)comboBox1.SelectedItem;
                str2 = (String)comboBox2.SelectedItem;
                if (str.Equals(str2))
                {
                    comboBox2.SelectedIndex = -1;
                    comboBox1.SelectedIndex = -1;
                    return;
                }
                switch (str)
                {
                    case "ประเทศบรูไน ดารุสซาลาม":
                        textBox2.Text = "2000";
                        break;
                    case "ประเทศกัมพูชา":
                        textBox2.Text = "2500";
                        break;
                    case "ประเทศอินโดนีเซีย":
                        textBox2.Text = "1000";
                        break;
                    case "ประเทศลาว":
                        textBox2.Text = "1700";
                        break;
                    case "ประเทศมาเลเซีย":
                        textBox2.Text = "2300";
                        break;
                    case "ประเทศเมียนมาร์":
                        textBox2.Text = "1000";
                        break;
                    case "ประเทศฟิลิปปินส์":
                        textBox2.Text = "2700";
                        break;
                    case "ประเทศสิงคโปร์":
                        textBox2.Text = "1900";
                        break;
                    case "ประเทศเวียดนาม":
                        textBox2.Text = "2000";
                        break;
                    case "ประเทศไทย":
                        textBox2.Text = "3200";
                        break;

                }
            }
            catch (Exception ex) { MessageBox.Show("ข้อมูลซ้ากัน"); }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double t1, t2;
            t1 = double.Parse(textBox1.Text);
            t2 = double.Parse(textBox2.Text);
            sum = t1 * t2;
            textBox3.Text = Convert.ToString(sum);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
