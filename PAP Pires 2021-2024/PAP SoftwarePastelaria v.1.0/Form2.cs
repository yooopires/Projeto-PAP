using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAP_SoftwarePastelaria_v._1._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin Flog = new FormLogin();
            this.Close();
            Flog.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você já está na Página Inicial.","Informação");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Close();
            f3.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Close();
            f4.ShowDialog();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
