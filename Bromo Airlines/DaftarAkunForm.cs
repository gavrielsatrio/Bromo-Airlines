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
    public partial class DaftarAkunForm : CoreForm
    {
        private ModelEntities db = new ModelEntities();
        public DaftarAkunForm()
        {
            InitializeComponent();
        }

        private void DaftarAkunForm_Load(object sender, EventArgs e)
        {
            dtpTanggalLahir.MaxDate = DateTime.Now;
        }

        private void DaftarAkunForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" || txtNama.Text == "" || txtNomorTelepon.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Mohon isi semua data diri Anda ...");
                return;
            }

            var checkUsername = db.Akuns.Where(x => x.Username == txtUsername.Text).ToList();
            if(checkUsername.Count > 0)
            {
                MessageBox.Show("Username telah dipakai. Silahkan gunakan username lain ...");
                return;
            }

            if(txtNomorTelepon.Text.Length < 10 || txtNomorTelepon.Text.Length > 15 || !txtNomorTelepon.Text.All(char.IsDigit))
            {
                MessageBox.Show("Nomor telepon harus diisi dengan angka dengan panjang 10 - 15 digit ...");
                return;
            }

            if(txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password minimal 8 karakter ...");
                return;
            }

            db.Akuns.Add(new Akun
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Nama = txtNama.Text,
                NomorTelepon = txtNomorTelepon.Text,
                TanggalLahir = dtpTanggalLahir.Value.Date,
                MerupakanAdmin = false
            });
            db.SaveChanges();

            var currentUser = db.Akuns.ToList().LastOrDefault();

            this.Hide();
            GlobalData.Akun = currentUser;
            new CustomerMainForm().Show();
        }
    }
}
