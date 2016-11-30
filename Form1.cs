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
        public static double sum;//ประกาศ sum เป็น attribute
        String[] st = { "ประเทศบรูไน", "ดารุสซาลาม", "ประเทศกัมพูชา", "ประเทศอินโดนีเซีย", "ประเทศลาว", "ประเทศมาเลเซีย", "ประเทศเมียนมาร์", "ประเทศฟิลิปปินส์", "ประเทศสิงคโปร์", "ประเทศเวียดนาม", "ประเทศไทย" };//ประกาศให้ประเทศต่าง ๆ เป็น array ชื่อว่า st
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการออกจากหน้านี้หรือไม่?", "!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)//ถ้าตรงกับเงื่อนไข "คุณต้องการออกจากหน้านี้หรือไม่?", "!!!!", MessageBoxButtons.OKCancel ให้ออกจากหน้านี้
            {
                this.Close();//ปิดหน้านี้
                Form3 sh3 = new Form3();//ประกาศเรียกใช้ Form3
                sh3.Show();//โชว์ Form3
            }
            string sum = textBox3.Text;//รับค่าจาก textBox3 มาใส่ใน sum
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการจะเคลียร์ข้อมูลหรือไม่?", "!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)//ถ้าตรงกับเงื่อนไข "คุณต้องการจะเคลียร์ข้อมูลหรือไม่?", "!!!!", MessageBoxButtons.OKCancel ให้เคลียร์ข้อมุล
            {
                comboBox1.Text = "";//เคลียร์ข้อความใน comboBox1
                comboBox2.Text = "";//เคลียร์ข้อความใน comboBox2
                textBox1.Clear();//เคลียร์ข้อความใน textBox1
                textBox2.Clear();//เคลียร์ข้อความใน textBox2
                textBox3.Clear();//เคลียร์ข้อความใน textBox3
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string str, str2;//ประกาศตัวแปรชื่อ str , str2
                str = (String)comboBox1.SelectedItem;//str = ข้อความใน comboBox1
                str2 = (String)comboBox2.SelectedItem;//str2 = ข้อความใน comboBox2
               if (str.Equals(str2))//เช็คเงื่อนไขว่าถ้า str = str2 จะให้ comboBox1 กับ comboBox2 มีค่า -1
                {
                    comboBox2.SelectedIndex = -1;// comboBox2 มีค่าเป็น -1
                    comboBox1.SelectedIndex = -1;// comboBox1 มีค่าเป็น -1
                    return;//จบไม่ทำต่อ
                }
                switch (str)//เช็คเงื่อนไขใน str
                {
                    case "ประเทศบรูไน ดารุสซาลาม"://ถ้าเลือก ประเทศบรูไน ดารุสซาลาม จะเซ็ตค่าใน textBox2 เป็น 2000
                        textBox2.Text = "2000";
                        break;//หยุด
                    case "ประเทศกัมพูชา"://ถ้าเลือก ประเทศกัมพูชา จะเซ็ตค่าใน textBox2 เป็น 2500
                        textBox2.Text = "2500";
                        break;//หยุด
                    case "ประเทศอินโดนีเซีย"://ถ้าเลือก ประเทศอินโดนีเซีย จะเซ็ตค่าใน textBox2 เป็น 1000
                        textBox2.Text = "1000";
                        break;//หยุด
                    case "ประเทศลาว"://ถ้าเลือก ประเทศลาว จะเซ็ตค่าใน textBox2 เป็น 1700
                        textBox2.Text = "1700";
                        break;//หยุด
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
            catch (Exception ex) { MessageBox.Show("ข้อมูลซ้ากัน"); }//บอกว่าข้อมูลซ้ำกัน
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
            double t1, t2;//รับค่า t1 t2
            t1 = double.Parse(textBox1.Text);//รับค่าจาก textBox1 มาใส่ใน t1
            t2 = double.Parse(textBox2.Text);//รับค่าจาก textBox2 มาใส่ใน t2
            sum = t1 * t2;//เก็บค่า t1 * t2 มาไว้ใน sum
            textBox3.Text = Convert.ToString(sum);//เอาค่าใน sum มาแปลงเป็นข้อความมาแสดงใน textBox3
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
