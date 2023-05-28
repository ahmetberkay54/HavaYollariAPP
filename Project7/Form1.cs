using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Nereden : " + comboBox1.Text + " Nereye : " + comboBox2.Text + " Tarih : " + dateTimePicker1.Text + " Saat : " + maskedTextBox1.Text + " Yolcu Adı ve Soyad : " + textBox1.Text + " TCKN : " + maskedTextBox2.Text + " Telefon Numarası : " + maskedTextBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string X;
            X = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = X;

            int a, b;
            a = 7; b = 3;
            MessageBox.Show(a / b);





        }
    }
}
