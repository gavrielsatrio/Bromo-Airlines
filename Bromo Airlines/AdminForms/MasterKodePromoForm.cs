using Bromo_Airlines.HelperAndExtension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromo_Airlines.AdminForms
{
    public partial class MasterKodePromoForm : UserControl
    {
        private ModelEntities db = new ModelEntities();
        private int selectedDataID = -1;

        public MasterKodePromoForm()
        {
            InitializeComponent();
        }

        private void MasterKodePromoForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvKodePromo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvKodePromo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvKodePromo.Columns.Clear();

            var query = db.KodePromoes.ToList();
            dgvKodePromo.DataSource = query.Select(x => new
            {
                x.ID,
                x.Kode,
                x.PersentaseDiskon,
                x.MaksimumDiskon,
                BerlakuSampai = x.BerlakuSampai.ToString("dd-MM-yyyy"),
                x.Deskripsi
            }).ToList().ToBindingList();

            dgvKodePromo.Columns["ID"].Visible = false;

            dgvKodePromo.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "Edit",
                Text = "Ubah",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            });

            dgvKodePromo.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "Delete",
                Text = "Hapus",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            });

            dgvKodePromo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKodePromo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ClearFields()
        {
            selectedDataID = -1;
            foreach (var control in Controls)
            {
                if (control is TextBox txt)
                {
                    txt.Text = "";
                }
            }
            txtPersentaseDiskon.Value = 1;
            txtMaksimumDiskon.Value = 1;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(txtKodePromo.Text == "" || txtDeskripsi.Text == "")
            {
                MessageBox.Show("Mohon isi semua data kode promo ...");
                return;
            }

            var checkKodePromo = db.KodePromoes.Where(x => x.Kode == txtKodePromo.Text).ToList();
            if(checkKodePromo.Count > 0)
            {
                MessageBox.Show("Kode promo sudah dipakai sebelumnya ...");
                return;
            }

            if(selectedDataID == -1)
            {
                db.KodePromoes.Add(new KodePromo
                {
                    Kode = txtKodePromo.Text,
                    PersentaseDiskon = (double)txtPersentaseDiskon.Value,
                    MaksimumDiskon = (double)txtMaksimumDiskon.Value,
                    BerlakuSampai = dtpBerlakuSampai.Value.Date,
                    Deskripsi = txtDeskripsi.Text
                });
                db.SaveChanges();
            }
            else
            {
                var query = db.KodePromoes.Find(selectedDataID);
                query.Kode = txtKodePromo.Text;
                query.PersentaseDiskon = (double)txtPersentaseDiskon.Value;
                query.MaksimumDiskon = (double)txtMaksimumDiskon.Value;
                query.BerlakuSampai = dtpBerlakuSampai.Value.Date;
                query.Deskripsi = txtDeskripsi.Text;
                
                db.SaveChanges();
            }

            ClearFields();
            LoadData();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvKodePromo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvKodePromo.Columns["Edit"].Index)
                {
                    selectedDataID = int.Parse(dgvKodePromo["ID", e.RowIndex].Value.ToString());

                    txtKodePromo.Text = dgvKodePromo["Kode", e.RowIndex].Value.ToString();
                    dtpBerlakuSampai.Value = DateTime.Parse(dgvKodePromo["BerlakuSampai", e.RowIndex].Value.ToString());
                    txtPersentaseDiskon.Value = int.Parse(dgvKodePromo["PersentaseDiskon", e.RowIndex].Value.ToString());
                    txtMaksimumDiskon.Value = int.Parse(dgvKodePromo["MaksimumDiskon", e.RowIndex].Value.ToString());
                    txtDeskripsi.Text = dgvKodePromo["Deskripsi", e.RowIndex].Value.ToString();
                }
                else if (e.ColumnIndex == dgvKodePromo.Columns["Delete"].Index)
                {
                    var dialog = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.Yes)
                    {
                        selectedDataID = int.Parse(dgvKodePromo["ID", e.RowIndex].Value.ToString());

                        var query = db.KodePromoes.Find(selectedDataID);
                        db.KodePromoes.Remove(query);
                        db.SaveChanges();

                        ClearFields();
                        LoadData();
                    }
                }
            }
        }
    }
}
