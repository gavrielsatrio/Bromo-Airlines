using Bromo_Airlines.HelperAndExtension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromo_Airlines.AdminForms
{
    public partial class MasterMaskapaiForm : UserControl
    {
        private ModelEntities db = new ModelEntities();
        private int selectedDataID = -1;

        public MasterMaskapaiForm()
        {
            InitializeComponent();
        }

        private void MasterMaskapaiForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvMaskapai.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvMaskapai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvMaskapai.Columns.Clear();

            var query = db.Maskapais.ToList();
            dgvMaskapai.DataSource = query.OrderBy(x => x.Nama).Select(x => new
            {
                x.ID,
                x.Nama,
                x.Perusahaan,
                x.JumlahKru,
                x.Deskripsi
            }).ToList().ToBindingList();

            dgvMaskapai.Columns["ID"].Visible = false;

            dgvMaskapai.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "Edit",
                Text = "Ubah",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            });

            dgvMaskapai.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "Delete",
                Text = "Hapus",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            });

            dgvMaskapai.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMaskapai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            txtJumlahKru.Value = 1;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(txtNama.Text == "" || txtPerusahaan.Text == "" || txtDeskripsi.Text == "")
            {
                MessageBox.Show("Mohon isi semua data maskapai ...");
                return;
            }

            if(selectedDataID == -1)
            {
                db.Maskapais.Add(new Maskapai
                {
                    Nama = txtNama.Text,
                    Deskripsi = txtDeskripsi.Text,
                    JumlahKru = (int)txtJumlahKru.Value,
                    Perusahaan = txtPerusahaan.Text
                });
                db.SaveChanges();
            }
            else
            {
                var query = db.Maskapais.Find(selectedDataID);
                query.Nama = txtNama.Text;
                query.Deskripsi = txtDeskripsi.Text;
                query.JumlahKru = (int)txtJumlahKru.Value;
                query.Perusahaan = txtPerusahaan.Text;
                
                db.SaveChanges();

            }

            ClearFields();
            LoadData();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvMaskapai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvMaskapai.Columns["Edit"].Index)
                {
                    selectedDataID = int.Parse(dgvMaskapai["ID", e.RowIndex].Value.ToString());

                    txtNama.Text = dgvMaskapai["Nama", e.RowIndex].Value.ToString();
                    txtPerusahaan.Text = dgvMaskapai["Perusahaan", e.RowIndex].Value.ToString();
                    txtJumlahKru.Value = int.Parse(dgvMaskapai["JumlahKru", e.RowIndex].Value.ToString());
                    txtDeskripsi.Text = dgvMaskapai["Deskripsi", e.RowIndex].Value.ToString();
                }
                else if (e.ColumnIndex == dgvMaskapai.Columns["Delete"].Index)
                {
                    var dialog = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.Yes)
                    {
                        selectedDataID = int.Parse(dgvMaskapai["ID", e.RowIndex].Value.ToString());

                        var query = db.Maskapais.Find(selectedDataID);
                        db.Maskapais.Remove(query);
                        db.SaveChanges();

                        ClearFields();
                        LoadData();
                    }
                }
            }
        }
    }
}
