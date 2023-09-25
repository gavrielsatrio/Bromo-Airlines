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
    public partial class BeliTiketForm : CoreForm
    {
        public JadwalPenerbangan selectedFlightSchedule;
        public int passengerCount;

        private ModelEntities db = new ModelEntities();
        private int? selectedKodePromoID = null;

        public BeliTiketForm()
        {
            InitializeComponent();
        }

        private void BeliTiketForm_Load(object sender, EventArgs e)
        {
            lblBandaraKeberangkatan.Text = $"{selectedFlightSchedule.Bandara.Nama} ({selectedFlightSchedule.Bandara.KodeIATA})";
            lblBandaraTujuan.Text = $"{selectedFlightSchedule.Bandara1.Nama} ({selectedFlightSchedule.Bandara1.KodeIATA})";
            lblMaskapai.Text = selectedFlightSchedule.Maskapai.Nama;
            lblTanggalKeberangkatan.Text = selectedFlightSchedule.TanggalWaktuKeberangkatan.ToString("dddd, dd MMMM yyyy");
            lblWaktuPenerbangan.Text = $"{selectedFlightSchedule.TanggalWaktuKeberangkatan.ToString("HH:mm")} - {selectedFlightSchedule.TanggalWaktuKeberangkatan.AddMinutes(selectedFlightSchedule.DurasiPenerbangan).ToString("HH:mm")}";
            lblJumlahPenumpang.Text = $"{passengerCount} penumpang";
            lblTotalPembayaran.Text = $"IDR {(selectedFlightSchedule.HargaPerTiket * passengerCount).ToString("N0")}";

            for (int i = 0; i < passengerCount; i++)
            {
                var passengerDetail = new DetailPenumpangLayout()
                {
                    nomorPenumpang = i + 1,
                    Dock = DockStyle.Top
                };

                panelListPenumpang.Controls.Add(passengerDetail);
                passengerDetail.BringToFront();
            }
        }

        private void BeliTiketForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new ListPenerbanganForm()
            {
                departureAirport = selectedFlightSchedule.Bandara,
                destinationAirport = selectedFlightSchedule.Bandara1,
                departureDate = selectedFlightSchedule.TanggalWaktuKeberangkatan,
                passengerCount = passengerCount
            }.Show();
        }

        private void picBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ListPenerbanganForm()
            {
                departureAirport = selectedFlightSchedule.Bandara,
                destinationAirport = selectedFlightSchedule.Bandara1,
                departureDate = selectedFlightSchedule.TanggalWaktuKeberangkatan,
                passengerCount = passengerCount
            }.Show();
        }

        private void btnPakaiKodePromo_Click(object sender, EventArgs e)
        {
            var totalPrice = selectedFlightSchedule.HargaPerTiket * passengerCount;

            var checkPromoCode = db.KodePromoes.ToList().Where(x => x.Kode == txtKodePromo.Text && x.BerlakuSampai.Date >= DateTime.Now.Date).FirstOrDefault();
            if(checkPromoCode == null)
            {
                selectedKodePromoID = null;

                lblTotalPembayaran.Text = $"IDR {totalPrice.ToString("N0")}";

                MessageBox.Show("Kode promo tidak valid ...");
                return;
            }

            var discountPercentage = checkPromoCode.PersentaseDiskon;
            var maxDiscount = checkPromoCode.MaksimumDiskon;

            var discountValue = (totalPrice * discountPercentage / 100) > maxDiscount ? maxDiscount : (totalPrice * discountPercentage / 100);
            lblTotalPembayaran.Text = $"IDR {(totalPrice - discountValue).ToString("N0")}";

            selectedKodePromoID = checkPromoCode.ID;
            MessageBox.Show($"Kode promo berhasil dipakai ...\nAnda menghemat: IDR {(discountValue).ToString("N0")}");
        }

        private void btnKonfirmasiPembayaran_Click(object sender, EventArgs e)
        {
            List<TransaksiDetail> listPenumpang = new List<TransaksiDetail>();

            foreach (var control in panelListPenumpang.Controls)
            {
                if(control is DetailPenumpangLayout detailPenumpang)
                {
                    if(detailPenumpang.GetTitel() == "- Pilih Titel -" || detailPenumpang.GetNamaLengkap() == "")
                    {
                        MessageBox.Show("Mohon isi semua data penumpang dengan lengkap ...");
                        return;
                    }

                    listPenumpang.Insert(0, new TransaksiDetail
                    {
                        TransaksiHeaderID = -1,
                        TitelPenumpang = detailPenumpang.GetTitel(),
                        NamaLengkapPenumpang = detailPenumpang.GetNamaLengkap()
                    });
                }
            }

            var totalPembayaran = selectedFlightSchedule.HargaPerTiket * passengerCount;

            db.TransaksiHeaders.Add(new TransaksiHeader
            {
                AkunID = GlobalData.Akun.ID,
                TanggalTransaksi = DateTime.Now,
                JadwalPenerbanganID = selectedFlightSchedule.ID,
                JumlahPenumpang = passengerCount,
                TotalHarga = totalPembayaran,
                KodePromoID = selectedKodePromoID
            });
            db.SaveChanges();

            var transaksiBarusan = db.TransaksiHeaders.ToList().LastOrDefault();
            for (int i = 0; i < listPenumpang.Count; i++)
            {
                listPenumpang[i].TransaksiHeaderID = transaksiBarusan.ID;
            }

            db.TransaksiDetails.AddRange(listPenumpang);
            db.SaveChanges();

            MessageBox.Show("Sukses membeli tiket!");

            this.Hide();
            new CustomerMainForm().Show();
        }
    }
}
