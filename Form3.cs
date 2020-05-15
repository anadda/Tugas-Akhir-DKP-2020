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
    public partial class Form3 : Form
    {
        private string user, pass;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "Admin" && password.Text == "12345")
            {
                Depan frm = new Depan();
                frm.Show();
                this.Hide();
            }
            else MessageBox.Show("Username atau Password Salah");


        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
