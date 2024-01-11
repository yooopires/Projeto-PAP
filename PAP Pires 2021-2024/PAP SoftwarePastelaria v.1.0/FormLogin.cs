using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PAP_SoftwarePastelaria_v._1._0
{
    public partial class FormLogin : Form
    {
        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var strConnect = "server=localhost;uid=root;database=pastelaria";
            var connect = new MySqlConnection(strConnect);
            connect.Open();
            var login = new MySqlCommand("SELECT * FROM login", connect);
            var reader = login.ExecuteReader();



            while (reader.Read())
            {
               var username = ($"{reader["username"]}");
               var password = ($"{reader["password"]}");
                
               if (textBox1.Text == username && textBox2.Text == password)
                {
                    
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
                if (textBox1.Text != username || textBox2.Text != password)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    MessageBox.Show("Username ou password inválido(s).", "Erro!");
                }
                
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    MessageBox.Show("Login Inválido. Preencha os campos necessários.", "Erro!");
                }
            }
           

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightSteelBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.ButtonFace;
        }
    }
}
