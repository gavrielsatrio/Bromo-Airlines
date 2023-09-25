namespace Bromo_Airlines.AdminForms
{
    partial class MasterJadwalPenerbanganForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSubheader = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgvJadwal = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.comboBandaraDari = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBandaraKe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMaskapai = new System.Windows.Forms.ComboBox();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWaktu = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKodePenerbangan = new System.Windows.Forms.MaskedTextBox();
            this.txtDurasiPenerbangan = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHarga)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubheader
            // 
            this.lblSubheader.AutoSize = true;
            this.lblSubheader.Location = new System.Drawing.Point(18, 46);
            this.lblSubheader.Margin = new System.Windows.Forms.Padding(5);
            this.lblSubheader.Name = "lblSubheader";
            this.lblSubheader.Size = new System.Drawing.Size(250, 14);
            this.lblSubheader.TabIndex = 6;
            this.lblSubheader.Text = "Semua jadwal penerbangan akan muncul di sini";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(16, 16);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(306, 25);
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "Master Jadwal Penerbangan";
            // 
            // dgvJadwal
            // 
            this.dgvJadwal.AllowUserToAddRows = false;
            this.dgvJadwal.AllowUserToDeleteRows = false;
            this.dgvJadwal.AllowUserToResizeRows = false;
            this.dgvJadwal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJadwal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJadwal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvJadwal.BackgroundColor = System.Drawing.Color.White;
            this.dgvJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJadwal.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJadwal.Location = new System.Drawing.Point(21, 75);
            this.dgvJadwal.Margin = new System.Windows.Forms.Padding(5);
            this.dgvJadwal.Name = "dgvJadwal";
            this.dgvJadwal.ReadOnly = true;
            this.dgvJadwal.RowHeadersVisible = false;
            this.dgvJadwal.Size = new System.Drawing.Size(642, 218);
            this.dgvJadwal.TabIndex = 0;
            this.dgvJadwal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJadwal_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 342);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dari";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(563, 455);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(5);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(100, 30);
            this.btnSimpan.TabIndex = 9;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(453, 455);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(5);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(100, 30);
            this.btnBatal.TabIndex = 10;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // comboBandaraDari
            // 
            this.comboBandaraDari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBandaraDari.FormattingEnabled = true;
            this.comboBandaraDari.Location = new System.Drawing.Point(132, 344);
            this.comboBandaraDari.Margin = new System.Windows.Forms.Padding(5);
            this.comboBandaraDari.Name = "comboBandaraDari";
            this.comboBandaraDari.Size = new System.Drawing.Size(169, 22);
            this.comboBandaraDari.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 374);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ke";
            // 
            // comboBandaraKe
            // 
            this.comboBandaraKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBandaraKe.FormattingEnabled = true;
            this.comboBandaraKe.Location = new System.Drawing.Point(132, 376);
            this.comboBandaraKe.Margin = new System.Windows.Forms.Padding(5);
            this.comboBandaraKe.Name = "comboBandaraKe";
            this.comboBandaraKe.Size = new System.Drawing.Size(169, 22);
            this.comboBandaraKe.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 406);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Maskapai";
            // 
            // comboMaskapai
            // 
            this.comboMaskapai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMaskapai.FormattingEnabled = true;
            this.comboMaskapai.Location = new System.Drawing.Point(132, 408);
            this.comboMaskapai.Margin = new System.Windows.Forms.Padding(5);
            this.comboMaskapai.Name = "comboMaskapai";
            this.comboMaskapai.Size = new System.Drawing.Size(169, 22);
            this.comboMaskapai.TabIndex = 4;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dddd, dd MMMM yyyy";
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(448, 313);
            this.dtpTanggal.Margin = new System.Windows.Forms.Padding(5);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(215, 21);
            this.dtpTanggal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tanggal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 347);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Waktu Keberangkatan";
            // 
            // txtWaktu
            // 
            this.txtWaktu.Location = new System.Drawing.Point(448, 344);
            this.txtWaktu.Margin = new System.Windows.Forms.Padding(5);
            this.txtWaktu.Mask = "90:00";
            this.txtWaktu.Name = "txtWaktu";
            this.txtWaktu.RejectInputOnFirstFailure = true;
            this.txtWaktu.Size = new System.Drawing.Size(215, 21);
            this.txtWaktu.TabIndex = 6;
            this.txtWaktu.Text = "0000";
            this.txtWaktu.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 411);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Harga per Tiket";
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(448, 409);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(5);
            this.txtHarga.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtHarga.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(215, 21);
            this.txtHarga.TabIndex = 8;
            this.txtHarga.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 316);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "Kode Penerbangan";
            // 
            // txtKodePenerbangan
            // 
            this.txtKodePenerbangan.Location = new System.Drawing.Point(132, 313);
            this.txtKodePenerbangan.Margin = new System.Windows.Forms.Padding(5);
            this.txtKodePenerbangan.Mask = "LL-0000";
            this.txtKodePenerbangan.Name = "txtKodePenerbangan";
            this.txtKodePenerbangan.RejectInputOnFirstFailure = true;
            this.txtKodePenerbangan.Size = new System.Drawing.Size(169, 21);
            this.txtKodePenerbangan.TabIndex = 1;
            this.txtKodePenerbangan.ValidatingType = typeof(System.DateTime);
            // 
            // txtDurasiPenerbangan
            // 
            this.txtDurasiPenerbangan.Location = new System.Drawing.Point(448, 376);
            this.txtDurasiPenerbangan.Margin = new System.Windows.Forms.Padding(5);
            this.txtDurasiPenerbangan.Mask = "00 j\\am 00 menit";
            this.txtDurasiPenerbangan.Name = "txtDurasiPenerbangan";
            this.txtDurasiPenerbangan.Size = new System.Drawing.Size(215, 21);
            this.txtDurasiPenerbangan.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 379);
            this.label8.Margin = new System.Windows.Forms.Padding(5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 14);
            this.label8.TabIndex = 10;
            this.label8.Text = "Durasi Penerbangan";
            // 
            // MasterJadwalPenerbanganForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtDurasiPenerbangan);
            this.Controls.Add(this.txtKodePenerbangan);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtWaktu);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.comboMaskapai);
            this.Controls.Add(this.comboBandaraKe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBandaraDari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvJadwal);
            this.Controls.Add(this.lblSubheader);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MasterJadwalPenerbanganForm";
            this.Size = new System.Drawing.Size(684, 500);
            this.Load += new System.EventHandler(this.MasterJadwalPenerbanganForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubheader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvJadwal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.ComboBox comboBandaraDari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBandaraKe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMaskapai;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtWaktu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtHarga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtKodePenerbangan;
        private System.Windows.Forms.MaskedTextBox txtDurasiPenerbangan;
        private System.Windows.Forms.Label label8;
    }
}
