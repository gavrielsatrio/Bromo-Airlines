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

namespace Bromo_Airlines.CustomerForms
{
    public partial class TiketSayaForm : CoreForm
    {
        private ModelEntities db = new ModelEntities();

        public TiketSayaForm()
        {
            InitializeComponent();
        }

        private void TiketSayaForm_Load(object sender, EventArgs e)
        {
            dgvTiket.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvTiket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            var query = db.TransaksiHeaders.ToList().Where(x => x.JadwalPenerbangan.TanggalWaktuKeberangkatan >= DateTime.Now && x.AkunID == GlobalData.Akun.ID).ToList();
            dgvTiket.DataSource = query.Select(x => new
            {
                x.JadwalPenerbangan.KodePenerbangan,
                Maskapai = x.JadwalPenerbangan.Maskapai.Nama,
                BandaraKeberangkatan = x.JadwalPenerbangan.Bandara.Nama,
                BandaraTujuan = x.JadwalPenerbangan.Bandara1.Nama,
                TanggalKeberangkatan = x.JadwalPenerbangan.TanggalWaktuKeberangkatan.ToString("dd-MM-yyyy"),
                WaktuPenerbangan = x.JadwalPenerbangan.TanggalWaktuKeberangkatan.ToString("HH:mm") + " - " + x.JadwalPenerbangan.TanggalWaktuKeberangkatan.AddMinutes(x.JadwalPenerbangan.DurasiPenerbangan).ToString("HH:mm"),
                StatusTerakhir = x.JadwalPenerbangan.PerubahanStatusJadwalPenerbangans.Count > 0 ? (x.JadwalPenerbangan.PerubahanStatusJadwalPenerbangans.OrderByDescending(y => y.WaktuPerubahanTerjadi).ToList().FirstOrDefault().StatusPenerbangan.Nama + (x.JadwalPenerbangan.PerubahanStatusJadwalPenerbangans.OrderByDescending(y => y.WaktuPerubahanTerjadi).ToList().FirstOrDefault().StatusPenerbanganID == 3 ? $" (selama ±{x.JadwalPenerbangan.PerubahanStatusJadwalPenerbangans.OrderByDescending(y => y.WaktuPerubahanTerjadi).ToList().FirstOrDefault().PerkiraanDurasiDelay.Value.ToJamMenitFormat()})" : "")) : "Sesuai Jadwal"
            }).ToList().ToBindingList();

            dgvTiket.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTiket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void picBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CustomerMainForm().Show();
        }

        private void TiketSayaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new CustomerMainForm().Show();
        }
    }
}
