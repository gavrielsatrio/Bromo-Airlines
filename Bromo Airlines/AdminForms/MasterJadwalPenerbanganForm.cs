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
    public partial class MasterJadwalPenerbanganForm : UserControl
    {
        private ModelEntities db = new ModelEntities();
        private int selectedDataID = -1;

        public MasterJadwalPenerbanganForm()
        {
            InitializeComponent();
        }

        private void MasterJadwalPenerbanganForm_Load(object sender, EventArgs e)
        {
            LoadComboDari();
            LoadComboKe();
            LoadComboMaskapai();
            LoadData();
        }

        private void LoadComboDari()
        {
            var query = db.Bandaras.OrderBy(x => x.Nama).ToList();
            comboBandaraDari.DataSource = query;
            comboBandaraDari.ValueMember = "ID";
            comboBandaraDari.DisplayMember = "Nama";
        }

        private void LoadComboKe()
        {
            var query = db.Bandaras.OrderBy(x => x.Nama).ToList();
            comboBandaraKe.DataSource = query;
            comboBandaraKe.ValueMember = "ID";
            comboBandaraKe.DisplayMember = "Nama";
        }

        private void LoadComboMaskapai()
        {
            var query = db.Maskapais.OrderBy(x => x.Nama).ToList();
            comboMaskapai.DataSource = query;
            comboMaskapai.ValueMember = "ID";
            comboMaskapai.DisplayMember = "Nama";
        }

        private void LoadData()
        {
            dgvJadwal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvJadwal.Columns.Clear();

            var query = db.JadwalPenerbangans.ToList();
            dgvJadwal.DataSource = query.OrderByDescending(x => x.TanggalWaktuKeberangkatan).Select(x => new
            {
                x.ID,
                x.KodePenerbangan,
                x.BandaraKeberangkatanID,
                BandaraKeberangkatan = x.Bandara.Nama,
                x.BandaraTujuanID,
                BandaraTujuan = x.Bandara1.Nama,
                x.MaskapaiID,
                Maskapai = x.Maskapai.Nama,
                x.TanggalWaktuKeberangkatan,
                TanggalKeberangkatan = x.TanggalWaktuKeberangkatan.ToString("dd-MM-yyyy"),
                WaktuKeberangkatan = x.TanggalWaktuKeberangkatan.ToString("HH:mm"),
                DurasiPenerbangan = x.DurasiPenerbangan.ToJamMenitFormat(),
                x.HargaPerTiket
            }).ToList().ToBindingList();

            dgvJadwal.Columns["ID"].Visible = false;
            dgvJadwal.Columns["BandaraKeberangkatanID"].Visible = false;
            dgvJadwal.Columns["BandaraTujuanID"].Visible = false;
            dgvJadwal.Columns["MaskapaiID"].Visible = false;
            dgvJadwal.Columns["TanggalWaktuKeberangkatan"].Visible = false;

            dgvJadwal.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "Edit",
                Text = "Ubah",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            });

            dgvJadwal.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "Delete",
                Text = "Hapus",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            });

            dgvJadwal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            txtKodePenerbangan.Text = "";
            txtWaktu.Text = "0000";
            txtDurasiPenerbangan.Text = "";
            txtHarga.Value = 1;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(txtKodePenerbangan.Text.Length != 7 || txtKodePenerbangan.Text.Contains(" "))
            {
                MessageBox.Show("Mohon isi kode penerbangan dengan lengkap ...");
                return;
            }

            if(comboBandaraDari.SelectedValue.ToString() == comboBandaraKe.SelectedValue.ToString())
            {
                MessageBox.Show("Bandara keberangkatan dan bandara tujuan tidak bisa sama ...");
                return;
            }

            if (txtWaktu.Text.Length != 5 || txtWaktu.Text.Contains(" "))
            {
                MessageBox.Show("Mohon isi waktu keberangkatan dengan lengkap ...");
                return;
            }

            var jamBerangkat = int.Parse(txtWaktu.Text.Split(':')[0]);
            var menitBerangkat = int.Parse(txtWaktu.Text.Split(':')[1]);

            if(jamBerangkat > 23 || jamBerangkat < 0 || menitBerangkat > 59 || menitBerangkat < 0)
            {
                MessageBox.Show("Waktu keberangkatan tidak valid ...");
                return;
            }

            if (txtDurasiPenerbangan.Text.Where(x => x.ToString() == " ").Count() > 3)
            {
                MessageBox.Show("Mohon isi durasi penerbangan dengan lengkap ...");
                return;
            }

            var durasiPenerbanganMenit = int.Parse(txtDurasiPenerbangan.Text.Split(' ')[2]);
            if(durasiPenerbanganMenit > 59)
            {
                MessageBox.Show("Menit durasi penerbangan tidak valid ...");
                return;
            }

            if (txtHarga.Text == "")
            {
                MessageBox.Show("Mohon isi harga per tiket ...");
                return;
            }

            if(selectedDataID == -1)
            {
                db.JadwalPenerbangans.Add(new JadwalPenerbangan()
                {
                    KodePenerbangan = txtKodePenerbangan.Text.ToUpper(),
                    BandaraKeberangkatanID = int.Parse(comboBandaraDari.SelectedValue.ToString()),
                    BandaraTujuanID = int.Parse(comboBandaraKe.SelectedValue.ToString()),
                    MaskapaiID = int.Parse(comboMaskapai.SelectedValue.ToString()),
                    TanggalWaktuKeberangkatan = new DateTime(dtpTanggal.Value.Year, dtpTanggal.Value.Month, dtpTanggal.Value.Day, int.Parse(txtWaktu.Text.Split(':')[0]), int.Parse(txtWaktu.Text.Split(':')[1]), 0),
                    DurasiPenerbangan = txtDurasiPenerbangan.Text.ToTotalMenitFormat(),
                    HargaPerTiket = (double)txtHarga.Value
                });
                db.SaveChanges();
            }
            else
            {
                var query = db.JadwalPenerbangans.Find(selectedDataID);
                query.KodePenerbangan = txtKodePenerbangan.Text;
                query.BandaraKeberangkatanID = int.Parse(comboBandaraDari.SelectedValue.ToString());
                query.BandaraTujuanID = int.Parse(comboBandaraKe.SelectedValue.ToString());
                query.MaskapaiID = int.Parse(comboMaskapai.SelectedValue.ToString());
                query.TanggalWaktuKeberangkatan = new DateTime(dtpTanggal.Value.Year, dtpTanggal.Value.Month, dtpTanggal.Value.Day, int.Parse(txtWaktu.Text.Split(':')[0]), int.Parse(txtWaktu.Text.Split(':')[1]), 0);
                query.DurasiPenerbangan = txtDurasiPenerbangan.Text.ToTotalMenitFormat();
                query.HargaPerTiket = (double)txtHarga.Value;
                
                db.SaveChanges();
            }

            ClearFields();
            LoadData();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvJadwal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(e.ColumnIndex == dgvJadwal.Columns["Edit"].Index)
                {
                    selectedDataID = int.Parse(dgvJadwal["ID", e.RowIndex].Value.ToString());

                    txtKodePenerbangan.Text = dgvJadwal["KodePenerbangan", e.RowIndex].Value.ToString();
                    comboBandaraDari.SelectedValue = int.Parse(dgvJadwal["BandaraKeberangkatanID", e.RowIndex].Value.ToString());
                    comboBandaraKe.SelectedValue = int.Parse(dgvJadwal["BandaraTujuanID", e.RowIndex].Value.ToString());
                    comboMaskapai.SelectedValue = int.Parse(dgvJadwal["MaskapaiID", e.RowIndex].Value.ToString());
                    dtpTanggal.Value = DateTime.Parse(dgvJadwal["TanggalKeberangkatan", e.RowIndex].Value.ToString());
                    txtWaktu.Text = dgvJadwal["WaktuKeberangkatan", e.RowIndex].Value.ToString();
                    txtDurasiPenerbangan.Text = dgvJadwal["DurasiPenerbangan", e.RowIndex].Value.ToString();
                    txtHarga.Value = int.Parse(dgvJadwal["HargaPerTiket", e.RowIndex].Value.ToString());
                }
                else if(e.ColumnIndex == dgvJadwal.Columns["Delete"].Index)
                {
                    var dialog = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.Yes)
                    {
                        selectedDataID = int.Parse(dgvJadwal["ID", e.RowIndex].Value.ToString());

                        var query = db.JadwalPenerbangans.Find(selectedDataID);
                        db.JadwalPenerbangans.Remove(query);
                        db.SaveChanges();

                        ClearFields();
                        LoadData();
                    }
                }
            }
        }
    }
}
