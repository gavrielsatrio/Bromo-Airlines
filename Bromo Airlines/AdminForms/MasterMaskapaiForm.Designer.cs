namespace Bromo_Airlines.AdminForms
{
    partial class MasterMaskapaiForm
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
            this.dgvMaskapai = new System.Windows.Forms.DataGridView();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPerusahaan = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJumlahKru = new System.Windows.Forms.NumericUpDown();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaskapai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJumlahKru)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubheader
            // 
            this.lblSubheader.AutoSize = true;
            this.lblSubheader.Location = new System.Drawing.Point(18, 46);
            this.lblSubheader.Margin = new System.Windows.Forms.Padding(5);
            this.lblSubheader.Name = "lblSubheader";
            this.lblSubheader.Size = new System.Drawing.Size(272, 14);
            this.lblSubheader.TabIndex = 4;
            this.lblSubheader.Text = "Semua maskapai yang terdaftar akan muncul di sini";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(16, 16);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(188, 25);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Master Maskapai";
            // 
            // dgvMaskapai
            // 
            this.dgvMaskapai.AllowUserToAddRows = false;
            this.dgvMaskapai.AllowUserToDeleteRows = false;
            this.dgvMaskapai.AllowUserToResizeRows = false;
            this.dgvMaskapai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaskapai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaskapai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMaskapai.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaskapai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaskapai.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaskapai.Location = new System.Drawing.Point(21, 75);
            this.dgvMaskapai.Margin = new System.Windows.Forms.Padding(5);
            this.dgvMaskapai.Name = "dgvMaskapai";
            this.dgvMaskapai.ReadOnly = true;
            this.dgvMaskapai.RowHeadersVisible = false;
            this.dgvMaskapai.Size = new System.Drawing.Size(642, 252);
            this.dgvMaskapai.TabIndex = 0;
            this.dgvMaskapai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaskapai_CellClick);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(96, 347);
            this.txtNama.Margin = new System.Windows.Forms.Padding(5);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(180, 21);
            this.txtNama.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 350);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 381);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Perusahaan";
            // 
            // txtPerusahaan
            // 
            this.txtPerusahaan.Location = new System.Drawing.Point(96, 378);
            this.txtPerusahaan.Margin = new System.Windows.Forms.Padding(5);
            this.txtPerusahaan.Name = "txtPerusahaan";
            this.txtPerusahaan.Size = new System.Drawing.Size(180, 21);
            this.txtPerusahaan.TabIndex = 2;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(563, 455);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(5);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(100, 30);
            this.btnSimpan.TabIndex = 5;
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
            this.btnBatal.TabIndex = 6;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 411);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Jumlah Kru";
            // 
            // txtJumlahKru
            // 
            this.txtJumlahKru.Location = new System.Drawing.Point(96, 409);
            this.txtJumlahKru.Margin = new System.Windows.Forms.Padding(5);
            this.txtJumlahKru.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtJumlahKru.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtJumlahKru.Name = "txtJumlahKru";
            this.txtJumlahKru.Size = new System.Drawing.Size(180, 21);
            this.txtJumlahKru.TabIndex = 3;
            this.txtJumlahKru.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Location = new System.Drawing.Point(406, 347);
            this.txtDeskripsi.Margin = new System.Windows.Forms.Padding(5);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(257, 83);
            this.txtDeskripsi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 19;
            this.label5.Text = "Deskripsi";
            // 
            // MasterMaskapaiForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtJumlahKru);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPerusahaan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMaskapai);
            this.Controls.Add(this.lblSubheader);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MasterMaskapaiForm";
            this.Size = new System.Drawing.Size(684, 500);
            this.Load += new System.EventHandler(this.MasterMaskapaiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaskapai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJumlahKru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubheader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvMaskapai;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPerusahaan;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtJumlahKru;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Label label5;
    }
}
