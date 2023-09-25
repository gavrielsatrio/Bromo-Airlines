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
    public partial class MasterBandaraForm : UserControl
    {
        private ModelEntities db = new ModelEntities();
        private int selectedDataID = -1;

        public MasterBandaraForm()
        {
            InitializeComponent();
        }

        private void MasterBandaraForm_Load(object sender, EventArgs e)
        {
            LoadComboNegara();
            LoadData();
        }

        private void LoadComboNegara()
        {
            var query = db.Negaras.ToList();
            comboNegara.DataSource = query;
            comboNegara.ValueMember = "ID";
            comboNegara.DisplayMember = "Nama";
        }

        private void LoadData()
        {
            dgvBandara.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvBandara.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvBandara.Columns.Clear();

            var query = db.Bandaras.ToList();
            dgvBandara.DataSource = query.OrderBy(x => x.Nama).Select(x => new
            {
                x.ID,
                x.Nama,
                x.KodeIATA,
                x.Kota,
                x.NegaraID,
                Negara = x.Negara.Nama,
                x.JumlahTerminal,
                x.Alamat
            }).ToList().ToBindingList();

            dgvBandara.Columns["ID"].Visible = false;
            dgvBandara.Columns["NegaraID"].Visible = false;
            dgvBandara.Columns["Nama"].Width = 180;

            dgvBandara.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "Edit",
                Text = "Ubah",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            });

            dgvBandara.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "Delete",
                Text = "Hapus",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            });

            dgvBandara.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBandara.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(txtNama.Text == "" || txtKode.Text == "" || txtKota.Text == "" || txtAlamat.Text == "")
            {
                MessageBox.Show("Mohon isi semua data bandara ...");
                return;
            }

            var checkNama = db.Bandaras.ToList().Where(x => x.Nama.ToLower() == txtNama.Text.ToLower()).ToList();
            if (checkNama.Count > 0)
            {
                MessageBox.Show("Nama bandara telah digunakan ...");
                return;
            }


            if(txtKode.Text.Length != 3 || !txtKode.Text.All(char.IsLetter))
            {
                MessageBox.Show("Kode IATA harus berupa 3 huruf ...");
                return;
            }

            var checkKodeIATA = db.Bandaras.Where(x => x.KodeIATA == txtKode.Text).ToList();
            if(checkKodeIATA.Count > 0)
            {
                MessageBox.Show("Kode IATA telah digunakan ...");
                return;
            }

            if(txtJumlahTerminal.Text == "")
            {
                MessageBox.Show("Mohon isi jumlah terminal ...");
                return;
            }

            if(selectedDataID == -1)
            {
                db.Bandaras.Add(new Bandara
                {
                    Nama = txtNama.Text,
                    KodeIATA = txtKode.Text,
                    Kota = txtKota.Text,
                    NegaraID = int.Parse(comboNegara.SelectedValue.ToString()),
                    JumlahTerminal = (int)txtJumlahTerminal.Value,
                    Alamat = txtAlamat.Text
                });
                db.SaveChanges();
            }
            else
            {
                var query = db.Bandaras.Find(selectedDataID);
                query.Nama = txtNama.Text;
                query.KodeIATA = txtKode.Text;
                query.Kota = txtKota.Text;
                query.NegaraID = int.Parse(comboNegara.SelectedValue.ToString());
                query.JumlahTerminal = (int)txtJumlahTerminal.Value;
                query.Alamat = txtAlamat.Text;
                
                db.SaveChanges();
            }

            ClearFields();
            LoadData();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            selectedDataID = -1;
            foreach (var control in Controls)
            {
                if(control is TextBox txt)
                {
                    txt.Text = "";
                }
            }
            txtJumlahTerminal.Value = 1;
        }

        private void dgvBandara_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(e.ColumnIndex == dgvBandara.Columns["Edit"].Index)
                {
                    selectedDataID = int.Parse(dgvBandara["ID", e.RowIndex].Value.ToString());

                    txtNama.Text = dgvBandara["Nama", e.RowIndex].Value.ToString();
                    txtKode.Text = dgvBandara["KodeIATA", e.RowIndex].Value.ToString();
                    txtKota.Text = dgvBandara["Kota", e.RowIndex].Value.ToString();
                    comboNegara.SelectedValue = int.Parse(dgvBandara["NegaraID", e.RowIndex].Value.ToString());
                    txtJumlahTerminal.Value = int.Parse(dgvBandara["JumlahTerminal", e.RowIndex].Value.ToString());
                    txtAlamat.Text = dgvBandara["Alamat", e.RowIndex].Value.ToString();
                }
                else if (e.ColumnIndex == dgvBandara.Columns["Delete"].Index)
                {
                    var dialog = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(dialog == DialogResult.Yes)
                    {
                        selectedDataID = int.Parse(dgvBandara["ID", e.RowIndex].Value.ToString());

                        var query = db.Bandaras.Find(selectedDataID);
                        db.Bandaras.Remove(query);
                        db.SaveChanges();

                        ClearFields();
                        LoadData();
                    }
                }
            }
        }
    }
}
