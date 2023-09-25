using Bromo_Airlines.CustomerForms;
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

namespace Bromo_Airlines
{
    public partial class CustomerMainForm : CoreForm
    {
        private ModelEntities db = new ModelEntities();

        public CustomerMainForm()
        {
            InitializeComponent();
        }

        private void CustomerMainForm_Load(object sender, EventArgs e)
        {
            dtpTanggalBerangkat.MinDate = DateTime.Now;
            LoadAutoCompleteTxtBerangkat();
            LoadAutoCompleteTxtTujuan();

            lblMauTerbangKeMana.Text = $"Mau terbang ke mana hari ini, {GlobalData.Akun.Nama}?";
        }

        private void LoadAutoCompleteTxtBerangkat()
        {
            var query = db.Bandaras.ToList().OrderBy(x => x.Nama).Select(x => $"{x.Nama}, {x.Kota} ({x.KodeIATA})").ToArray();
            var autoCompleteSource = new AutoCompleteStringCollection();
            autoCompleteSource.AddRange(query);

            txtBerangkat.AutoCompleteCustomSource = autoCompleteSource;
        }

        private void LoadAutoCompleteTxtTujuan()
        {
            var query = db.Bandaras.ToList().OrderBy(x => x.Nama).Select(x => $"{x.Nama}, {x.Kota} ({x.KodeIATA})").ToArray();
            var autoCompleteSource = new AutoCompleteStringCollection();
            autoCompleteSource.AddRange(query);

            txtTujuan.AutoCompleteCustomSource = autoCompleteSource;
        }

        private void CustomerMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void picBoxMyTickets_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TiketSayaForm().Show();
        }

        private void picBoxLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void btnCariPenerbangan_Click(object sender, EventArgs e)
        {
            if(!txtBerangkat.Text.Contains(",") || !txtBerangkat.Text.Contains("(") || !txtBerangkat.Text.Contains(")"))
            {
                MessageBox.Show("Pilih bandara keberangkatan Anda ...");
                return;
            }

            if (!txtTujuan.Text.Contains(",") || !txtTujuan.Text.Contains("(") || !txtTujuan.Text.Contains(")"))
            {
                MessageBox.Show("Pilih bandara tujuan Anda ...");
                return;
            }

            var departureAirportIATACode = txtBerangkat.Text.Split('(')[1].Replace(")", "").ToUpper();
            var destinationAirportIATACode = txtTujuan.Text.Split('(')[1].Replace(")", "").ToUpper();

            if(departureAirportIATACode == destinationAirportIATACode)
            {
                MessageBox.Show("Bandara asal dan tujuan tidak bisa sama ...");
                return;
            }

            var selectedDepartureAirport = db.Bandaras.Where(x => x.KodeIATA == departureAirportIATACode).ToList().FirstOrDefault();
            var selectedDestinationAirport = db.Bandaras.Where(x => x.KodeIATA == destinationAirportIATACode).ToList().FirstOrDefault();

            this.Hide();
            new ListPenerbanganForm()
            {
                departureAirport = selectedDepartureAirport,
                destinationAirport = selectedDestinationAirport,
                departureDate = dtpTanggalBerangkat.Value.Date,
                passengerCount = (int)txtJumlahPenumpang.Value
            }.Show();
        }
    }
}
