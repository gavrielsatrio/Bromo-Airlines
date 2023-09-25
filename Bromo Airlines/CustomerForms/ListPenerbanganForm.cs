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
    public partial class ListPenerbanganForm : CoreForm
    {
        public Bandara departureAirport;
        public Bandara destinationAirport;
        public DateTime departureDate;
        public int passengerCount;

        private ModelEntities db = new ModelEntities();
        public ListPenerbanganForm()
        {
            InitializeComponent();
        }

        private void CariPenerbanganForm_Load(object sender, EventArgs e)
        {
            lblBandaraKeberangkatan.Text = $"{departureAirport.Nama} ({departureAirport.KodeIATA})";
            lblBandaraTujuan.Text = $"{destinationAirport.Nama} ({destinationAirport.KodeIATA})";
            lblTanggalKeberangkatan.Text = departureDate.ToString("ddd, dd MMM yyyy");
            lblTotalPenumpang.Text = $"{passengerCount} Penumpang";

            comboUrutkanBerdasarkan.Text = comboUrutkanBerdasarkan.Items[0].ToString();

            LoadData();
        }

        private void LoadData()
        {
            dgvListPenerbangan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvListPenerbangan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvListPenerbangan.Columns.Clear();

            var query = db.JadwalPenerbangans.ToList().Where(x => x.BandaraKeberangkatanID == departureAirport.ID && x.BandaraTujuanID == destinationAirport.ID && x.TanggalWaktuKeberangkatan.Date == departureDate.Date).ToList();
            List<JadwalPenerbangan> queryFinal = new List<JadwalPenerbangan>();

            if(checkWaktu1.Checked || checkWaktu2.Checked || checkWaktu3.Checked || checkWaktu4.Checked)
            {
                var dateTimeCheck = new DateTime(departureDate.Year, departureDate.Month, departureDate.Day, 0, 0, 0);

                if (checkWaktu1.Checked)
                {
                    queryFinal.AddRange(query.Where(x => x.TanggalWaktuKeberangkatan >= dateTimeCheck && x.TanggalWaktuKeberangkatan <= dateTimeCheck.AddHours(6)).ToList());
                }

                if (checkWaktu2.Checked)
                {
                    queryFinal.AddRange(query.Where(x => x.TanggalWaktuKeberangkatan >= dateTimeCheck.AddHours(6) && x.TanggalWaktuKeberangkatan <= dateTimeCheck.AddHours(12)).ToList());
                }

                if (checkWaktu3.Checked)
                {
                    queryFinal.AddRange(query.Where(x => x.TanggalWaktuKeberangkatan >= dateTimeCheck.AddHours(12) && x.TanggalWaktuKeberangkatan <= dateTimeCheck.AddHours(18)).ToList());
                }

                if (checkWaktu4.Checked)
                {
                    queryFinal.AddRange(query.Where(x => x.TanggalWaktuKeberangkatan >= dateTimeCheck.AddHours(18) && x.TanggalWaktuKeberangkatan <= dateTimeCheck.AddHours(24)).ToList());
                }
            }
            else
            {
                queryFinal = query;
            }

            if (comboUrutkanBerdasarkan.Text == "Harga Terendah")
            {
                queryFinal = queryFinal.OrderBy(x => x.HargaPerTiket).ToList();
            }
            else if (comboUrutkanBerdasarkan.Text == "Keberangkatan Paling Awal")
            {
                queryFinal = queryFinal.OrderBy(x => x.TanggalWaktuKeberangkatan).ToList();
            }
            else if (comboUrutkanBerdasarkan.Text == "Keberangkatan Paling Akhir")
            {
                queryFinal = queryFinal.OrderByDescending(x => x.TanggalWaktuKeberangkatan).ToList();
            }
            else if (comboUrutkanBerdasarkan.Text == "Kedatangan Paling Awal")
            {
                queryFinal = queryFinal.OrderBy(x => x.TanggalWaktuKeberangkatan.AddMinutes(x.DurasiPenerbangan)).ToList();
            }
            else if (comboUrutkanBerdasarkan.Text == "Kedatangan Paling Akhir")
            {
                queryFinal = queryFinal.OrderByDescending(x => x.TanggalWaktuKeberangkatan.AddMinutes(x.DurasiPenerbangan)).ToList();
            }
            else
            {
                queryFinal = queryFinal.OrderBy(x => x.DurasiPenerbangan).ToList();
            }

            dgvListPenerbangan.DataSource = queryFinal.Select(x => new
            {
                x.ID,
                x.KodePenerbangan,
                Maskapai = x.Maskapai.Nama,
                BandaraKeberangkatan = x.Bandara.Nama,
                BandaraTujuan = x.Bandara1.Nama,
                x.HargaPerTiket,
                TanggalKeberangkatan = x.TanggalWaktuKeberangkatan.ToString("dd-MM-yyyy"),
                WaktuPenerbangan = x.TanggalWaktuKeberangkatan.ToString("HH:mm") + " - " + x.TanggalWaktuKeberangkatan.AddMinutes(x.DurasiPenerbangan).ToString("HH:mm")
            }).ToList().ToBindingList();

            dgvListPenerbangan.Columns["ID"].Visible = false;

            dgvListPenerbangan.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "Beli",
                Text = "Beli Tiket",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            });

            dgvListPenerbangan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListPenerbangan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CariPenerbanganForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new CustomerMainForm().Show();
        }

        private void picBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CustomerMainForm().Show();
        }

        private void btnTerapkanFilter_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvListPenerbangan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(e.ColumnIndex == dgvListPenerbangan.Columns["Beli"].Index)
                {
                    this.Hide();
                    new BeliTiketForm()
                    {
                        selectedFlightSchedule = db.JadwalPenerbangans.Find(int.Parse(dgvListPenerbangan["ID", e.RowIndex].Value.ToString())),
                        passengerCount = passengerCount
                    }.Show();
                }
            }
        }
    }
}
