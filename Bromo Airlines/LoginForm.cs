using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromo_Airlines
{
    public partial class LoginForm : CoreForm
    {
        private ModelEntities db = new ModelEntities();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Masukkan username dan password Anda ...");
                return;
            }

            var checkUser = db.Akuns.Where(x => x.Username == txtUsername.Text && x.Password == txtPassword.Text).ToList().FirstOrDefault();
            if(checkUser == null)
            {
                MessageBox.Show("Login invalid ...");
                return;
            }

            GlobalData.Akun = checkUser;
            this.Hide();

            if(checkUser.MerupakanAdmin)
            {
                new AdminMainForm().Show();
            }
            else
            {
                new CustomerMainForm().Show();
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkDaftarSekarang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new DaftarAkunForm().Show();
        }
    }
}
