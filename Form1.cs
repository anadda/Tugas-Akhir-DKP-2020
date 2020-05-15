using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Depan : Form
    {
        private string garansi,harga,hp;
        public Depan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                garansi = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                garansi = radioButton2.Text;
            }
            MessageBox.Show("hp yang ingin anda beli adalah hp "+hp+" "+garansi+" dengan harga "+harga);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hp = comboBox1.Text;
            if (comboBox1.Text == "Asus")
            {
                harga = "Rp.4.000.000";
            } else if (comboBox1.Text == "Samsung")
            {
                harga = "Rp.3.500.000";
            } else if (comboBox1.Text == "Iphone")
            {
                harga = "Rp.5.000.000";
            } else if (comboBox1.Text == "Oppo")
            {
                harga = "Rp.3.000.000";
            } else if (comboBox1.Text == "Vivo")
            {
                harga = "Rp.3.500.000"; 
            }
            textBox1.Text = harga;
        }

    }
} 
