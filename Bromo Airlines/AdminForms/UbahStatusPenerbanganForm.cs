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
    public partial class UbahStatusPenerbanganForm : UserControl
    {
        private ModelEntities db = new ModelEntities();
        private int selectedDataID = -1;

        public UbahStatusPenerbanganForm()
        {
            InitializeComponent();
        }

        private void UbahStatusPenerbanganForm_Load(object sender, EventArgs e)
        {
            LoadComboStatus();
            LoadData();
            HideEditControls();
        }

        private void LoadData()
        {
            dgvPenerbangan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvPenerbangan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvPenerbangan.Columns.Clear();

            var query = db.JadwalPenerbangans.OrderBy(x => x.TanggalWaktuKeberangkatan).ToList();
            dgvPenerbangan.DataSource = query.Select(x => new
            {
                x.ID,
                x.KodePenerbangan,
                Maskapai = x.Maskapai.Nama,
                BandaraKeberangkatan = x.Bandara.Nama,
                BandaraTujuan = x.Bandara1.Nama,
                TanggalKeberangkatan = x.TanggalWaktuKeberangkatan.ToString("dd-MM-yyyy"),
                WaktuKeberangkatan = x.TanggalWaktuKeberangkatan.ToString("HH:mm"),
                DurasiPenerbangan = x.DurasiPenerbangan.ToJamMenitFormat(),
                StatusTerakhir = x.PerubahanStatusJadwalPenerbangans.Count > 0 ? (x.PerubahanStatusJadwalPenerbangans.ToList().OrderByDescending(y => y.WaktuPerubahanTerjadi).FirstOrDefault().StatusPenerbanganID == 3 ?  $"{x.PerubahanStatusJadwalPenerbangans.ToList().OrderByDescending(y => y.WaktuPerubahanTerjadi).FirstOrDefault().StatusPenerbangan.Nama} (selama ±{x.PerubahanStatusJadwalPenerbangans.ToList().OrderByDescending(y => y.WaktuPerubahanTerjadi).FirstOrDefault().PerkiraanDurasiDelay.Value.ToJamMenitFormat()})" : x.PerubahanStatusJadwalPenerbangans.ToList().OrderByDescending(y => y.WaktuPerubahanTerjadi).FirstOrDefault().StatusPenerbangan.Nama) : "Sesuai Jadwal",
                TerakhirDiubah = x.PerubahanStatusJadwalPenerbangans.Count > 0 ? x.PerubahanStatusJadwalPenerbangans.ToList().OrderByDescending(y => y.WaktuPerubahanTerjadi).FirstOrDefault().WaktuPerubahanTerjadi.ToString("dd-MM-yyyy HH:mm:ss") : "-",
            }).ToList().ToBindingList();

            dgvPenerbangan.Columns["ID"].Visible = false;

            dgvPenerbangan.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "Ubah",
                Text = "Ubah",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            });

            dgvPenerbangan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPenerbangan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadComboStatus()
        {
            var query = db.StatusPenerbangans.ToList();
            comboStatus.DataSource = query;
            comboStatus.ValueMember = "ID";
            comboStatus.DisplayMember = "Nama";
        }

        private void ClearFields()
        {
            selectedDataID = -1;
            txtPerkiraanDurasiDelay.Text = "";
        }

        private void ShowEditControls()
        {
            lblStatus.Visible = true;
            comboStatus.Visible = true;
            btnSimpan.Visible = true;
            btnBatal.Visible = true;
        }

        private void HideEditControls()
        {
            lblStatus.Visible = false;
            comboStatus.Visible = false;
            btnSimpan.Visible = false;
            btnBatal.Visible = false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(selectedDataID == -1)
            {
                MessageBox.Show("Pilih data yang ingin diubah status penerbangannya ...");
                return;
            }

            int? totalMenitDelay = null;

            if(comboStatus.SelectedValue.ToString() == "3")
            {
                if(txtPerkiraanDurasiDelay.Text.Where(x => x == ' ').Count() != 3)
                {
                    MessageBox.Show("Mohon isi perkiraan durasi delay dengan lengkap ...");
                    return;
                }

                totalMenitDelay = txtPerkiraanDurasiDelay.Text.ToTotalMenitFormat();
            }

            db.PerubahanStatusJadwalPenerbangans.Add(new PerubahanStatusJadwalPenerbangan
            {
                JadwalPenerbanganID = selectedDataID,
                StatusPenerbanganID = int.Parse(comboStatus.SelectedValue.ToString()),
                WaktuPerubahanTerjadi = DateTime.Now,
                PerkiraanDurasiDelay = totalMenitDelay
            });
            db.SaveChanges();

            LoadData();
            ClearFields();
            HideEditControls();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            ClearFields();
            HideEditControls();
        }

        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            var statusID = comboStatus.SelectedValue.ToString();

            // If status == delay, show delay time fields, otherwise don't show
            txtPerkiraanDurasiDelay.Visible = statusID == "3";
            lblPerkiraanDurasiDelay.Visible = statusID == "3";
        }

        private void dgvPenerbangan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(e.ColumnIndex == dgvPenerbangan.Columns["Ubah"].Index)
                {
                    selectedDataID = int.Parse(dgvPenerbangan["ID", e.RowIndex].Value.ToString());

                    var query = db.JadwalPenerbangans.ToList().FirstOrDefault(x => x.ID == selectedDataID);
                    if(query.PerubahanStatusJadwalPenerbangans.Count > 0)
                    {
                        var latestFlightStatus = query.PerubahanStatusJadwalPenerbangans.ToList().OrderByDescending(x => x.WaktuPerubahanTerjadi).FirstOrDefault();
                        comboStatus.SelectedValue = latestFlightStatus.StatusPenerbanganID;

                        if(comboStatus.SelectedValue.ToString() == "3")
                        {
                            // Delay
                            txtPerkiraanDurasiDelay.Text = latestFlightStatus.PerkiraanDurasiDelay.Value.ToJamMenitFormat();
                        }
                    }
                    else
                    {
                        comboStatus.SelectedValue = 1;
                    }

                    ShowEditControls();
                }
            }
        }
    }
}
