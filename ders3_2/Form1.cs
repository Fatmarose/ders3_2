using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders3_2
{
    public partial class Form1 : Form
    {
        double sayı1;
        double sayı2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() == "" || 
                textBox2.Text.Trim() == "")
            {
                MessageBox.Show("sayıları boş girmeyiniz.");

                return;
            }
            String sayı = textBox1.Text;
            this.sayı1 = Convert.ToDouble(sayı);

            sayı = textBox2.Text;
            this.sayı2 = double.Parse(sayı);

            double sonuc = 0;
            if (checkBox1.Checked == true)
            {
                sonuc = sayı1 + sayı2;
                MessageBox.Show("toplam =" + sonuc);
            }
            if (checkBox2.Checked == true)
            {
                sonuc = sayı1 - sayı2;
                MessageBox.Show("fark =" + sonuc);
            }
            if (checkBox3.Checked == true)
            {
                sonuc = sayı1 * sayı2;
                MessageBox.Show("çarpım =" + sonuc);
            }
            if (checkBox4.Checked == true)
            {
                sonuc = sayı1 / sayı2;
                MessageBox.Show("bölüm =" + sonuc);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox3.Text;
            textBox3.Clear();
            listBox1.Items.Add(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int indeks = listBox1.SelectedIndex;
            if (indeks != -1)
            {
                listBox1.Items.RemoveAt(indeks);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String sayı = textBox1.Text;
            this.sayı1 = Convert.ToDouble(sayı);

            sayı = textBox2.Text;
            this.sayı2 = double.Parse(sayı);

            string islem = listBox1.SelectedItem.ToString();
            double sonuc = 0;

            switch (islem)
            {

                case "topla":
                    sonuc = sayı1 + sayı2;
                    break;


                case "çıkar":
                    sonuc = sayı1 - sayı2;
                    break;


                case "çarp":
                    sonuc = sayı1 * sayı2;
                    break;


                case "böl":
                    sonuc = sayı1 / sayı2;
                    break;

                default:
                    break;

            }
            label5.Text = "sonuc = " + sonuc;
        }
    }
}
