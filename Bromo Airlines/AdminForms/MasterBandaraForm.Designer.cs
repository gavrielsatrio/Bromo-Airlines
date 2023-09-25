namespace Bromo_Airlines.AdminForms
{
    partial class MasterBandaraForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSubheader = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJumlahTerminal = new System.Windows.Forms.NumericUpDown();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboNegara = new System.Windows.Forms.ComboBox();
            this.dgvBandara = new System.Windows.Forms.DataGridView();
            this.txtKota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtJumlahTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBandara)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(16, 16);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(175, 25);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Master Bandara";
            // 
            // lblSubheader
            // 
            this.lblSubheader.AutoSize = true;
            this.lblSubheader.Location = new System.Drawing.Point(18, 46);
            this.lblSubheader.Margin = new System.Windows.Forms.Padding(5);
            this.lblSubheader.Name = "lblSubheader";
            this.lblSubheader.Size = new System.Drawing.Size(264, 14);
            this.lblSubheader.TabIndex = 2;
            this.lblSubheader.Text = "Semua bandara yang terdaftar akan muncul di sini";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nama";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(107, 311);
            this.txtNama.Margin = new System.Windows.Forms.Padding(5);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(193, 21);
            this.txtNama.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 345);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kode IATA";
            // 
            // txtKode
            // 
            this.txtKode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKode.Location = new System.Drawing.Point(107, 342);
            this.txtKode.Margin = new System.Windows.Forms.Padding(5);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(193, 21);
            this.txtKode.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 345);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Alamat";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(422, 342);
            this.txtAlamat.Margin = new System.Windows.Forms.Padding(5);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(241, 84);
            this.txtAlamat.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 314);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Jumlah Terminal";
            // 
            // txtJumlahTerminal
            // 
            this.txtJumlahTerminal.Location = new System.Drawing.Point(422, 311);
            this.txtJumlahTerminal.Margin = new System.Windows.Forms.Padding(5);
            this.txtJumlahTerminal.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtJumlahTerminal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtJumlahTerminal.Name = "txtJumlahTerminal";
            this.txtJumlahTerminal.Size = new System.Drawing.Size(241, 21);
            this.txtJumlahTerminal.TabIndex = 5;
            this.txtJumlahTerminal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(453, 455);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(5);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(100, 30);
            this.btnBatal.TabIndex = 8;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(563, 455);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(5);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(100, 30);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 376);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kota";
            // 
            // comboNegara
            // 
            this.comboNegara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNegara.FormattingEnabled = true;
            this.comboNegara.Location = new System.Drawing.Point(107, 404);
            this.comboNegara.Margin = new System.Windows.Forms.Padding(5);
            this.comboNegara.Name = "comboNegara";
            this.comboNegara.Size = new System.Drawing.Size(193, 22);
            this.comboNegara.TabIndex = 4;
            // 
            // dgvBandara
            // 
            this.dgvBandara.AllowUserToAddRows = false;
            this.dgvBandara.AllowUserToDeleteRows = false;
            this.dgvBandara.AllowUserToResizeRows = false;
            this.dgvBandara.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBandara.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBandara.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBandara.BackgroundColor = System.Drawing.Color.White;
            this.dgvBandara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBandara.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBandara.Location = new System.Drawing.Point(21, 75);
            this.dgvBandara.Margin = new System.Windows.Forms.Padding(5);
            this.dgvBandara.Name = "dgvBandara";
            this.dgvBandara.ReadOnly = true;
            this.dgvBandara.RowHeadersVisible = false;
            this.dgvBandara.Size = new System.Drawing.Size(642, 216);
            this.dgvBandara.TabIndex = 0;
            this.dgvBandara.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBandara_CellClick);
            // 
            // txtKota
            // 
            this.txtKota.Location = new System.Drawing.Point(107, 373);
            this.txtKota.Margin = new System.Windows.Forms.Padding(5);
            this.txtKota.Name = "txtKota";
            this.txtKota.Size = new System.Drawing.Size(193, 21);
            this.txtKota.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 407);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Negara";
            // 
            // MasterBandaraForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboNegara);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.txtJumlahTerminal);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKota);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBandara);
            this.Controls.Add(this.lblSubheader);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MasterBandaraForm";
            this.Size = new System.Drawing.Size(684, 500);
            this.Load += new System.EventHandler(this.MasterBandaraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtJumlahTerminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBandara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSubheader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtJumlahTerminal;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboNegara;
        private System.Windows.Forms.DataGridView dgvBandara;
        private System.Windows.Forms.TextBox txtKota;
        private System.Windows.Forms.Label label2;
    }
}
