using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucak_rezervasyon
{
    public partial class Form1 : Form
        
    {
     

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("SEFERİ: " + comboBox1.Text + " - " + comboBox2.Text +  "   TARİHİ: " + dateTimePicker1.Text +  "   SAATİ: " + maskedTextBox1.Text);
            listBox1.Items.Add("YOLCU ADI: " + textBox1.Text + "  T.C: " + maskedTextBox1.Text + "  TELEFON: " + maskedTextBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = label9.Text;
         
        }
    }
}
