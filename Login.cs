using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientReservasi_20190140089
{
    public partial class Login : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsrnm.Text;
            string password = textBoxPassword.Text;

            string kategori = service.Login(username, password);

            if (kategori == "Admin")
            {
                Register fr = new Register();
                this.Hide();
                fr.Show();
            }
            else if (kategori == "Resepsionis")
            {
                Form1 f1 = new Form1();
                this.Hide();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Username dan Password Invalid");
                textBoxUsrnm.Clear();
                textBoxPassword.Clear();
            }

        }
    }
}
