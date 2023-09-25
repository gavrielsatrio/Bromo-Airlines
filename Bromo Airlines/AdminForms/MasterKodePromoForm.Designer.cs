namespace Bromo_Airlines.AdminForms
{
    partial class MasterKodePromoForm
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
            this.dgvKodePromo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKodePromo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBerlakuSampai = new System.Windows.Forms.DateTimePicker();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersentaseDiskon = new System.Windows.Forms.NumericUpDown();
            this.txtMaksimumDiskon = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKodePromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersentaseDiskon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaksimumDiskon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubheader
            // 
            this.lblSubheader.AutoSize = true;
            this.lblSubheader.Location = new System.Drawing.Point(18, 46);
            this.lblSubheader.Margin = new System.Windows.Forms.Padding(5);
            this.lblSubheader.Name = "lblSubheader";
            this.lblSubheader.Size = new System.Drawing.Size(286, 14);
            this.lblSubheader.TabIndex = 4;
            this.lblSubheader.Text = "Semua kode promo yang terdaftar akan muncul di sini";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(16, 16);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(214, 25);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Master Kode Promo";
            // 
            // dgvKodePromo
            // 
            this.dgvKodePromo.AllowUserToAddRows = false;
            this.dgvKodePromo.AllowUserToDeleteRows = false;
            this.dgvKodePromo.AllowUserToResizeRows = false;
            this.dgvKodePromo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKodePromo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKodePromo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKodePromo.BackgroundColor = System.Drawing.Color.White;
            this.dgvKodePromo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKodePromo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKodePromo.Location = new System.Drawing.Point(21, 76);
            this.dgvKodePromo.Margin = new System.Windows.Forms.Padding(5);
            this.dgvKodePromo.Name = "dgvKodePromo";
            this.dgvKodePromo.ReadOnly = true;
            this.dgvKodePromo.RowHeadersVisible = false;
            this.dgvKodePromo.Size = new System.Drawing.Size(642, 224);
            this.dgvKodePromo.TabIndex = 0;
            this.dgvKodePromo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKodePromo_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 354);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "Berlaku Sampai";
            // 
            // txtKodePromo
            // 
            this.txtKodePromo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKodePromo.Location = new System.Drawing.Point(131, 320);
            this.txtKodePromo.Margin = new System.Windows.Forms.Padding(5);
            this.txtKodePromo.Name = "txtKodePromo";
            this.txtKodePromo.Size = new System.Drawing.Size(180, 21);
            this.txtKodePromo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 323);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kode Promo";
            // 
            // dtpBerlakuSampai
            // 
            this.dtpBerlakuSampai.CustomFormat = "dd-MM-yyyy";
            this.dtpBerlakuSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBerlakuSampai.Location = new System.Drawing.Point(131, 351);
            this.dtpBerlakuSampai.Margin = new System.Windows.Forms.Padding(5);
            this.dtpBerlakuSampai.Name = "dtpBerlakuSampai";
            this.dtpBerlakuSampai.Size = new System.Drawing.Size(180, 21);
            this.dtpBerlakuSampai.TabIndex = 2;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(563, 455);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(5);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(100, 30);
            this.btnSimpan.TabIndex = 6;
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
            this.btnBatal.TabIndex = 7;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Location = new System.Drawing.Point(406, 320);
            this.txtDeskripsi.Margin = new System.Windows.Forms.Padding(5);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(257, 52);
            this.txtDeskripsi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 323);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 17;
            this.label5.Text = "Deskripsi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 385);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Persentase Diskon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 416);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "Maksimum Diskon";
            // 
            // txtPersentaseDiskon
            // 
            this.txtPersentaseDiskon.Location = new System.Drawing.Point(131, 382);
            this.txtPersentaseDiskon.Margin = new System.Windows.Forms.Padding(5);
            this.txtPersentaseDiskon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPersentaseDiskon.Name = "txtPersentaseDiskon";
            this.txtPersentaseDiskon.Size = new System.Drawing.Size(180, 21);
            this.txtPersentaseDiskon.TabIndex = 3;
            this.txtPersentaseDiskon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMaksimumDiskon
            // 
            this.txtMaksimumDiskon.Location = new System.Drawing.Point(131, 414);
            this.txtMaksimumDiskon.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaksimumDiskon.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtMaksimumDiskon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMaksimumDiskon.Name = "txtMaksimumDiskon";
            this.txtMaksimumDiskon.Size = new System.Drawing.Size(180, 21);
            this.txtMaksimumDiskon.TabIndex = 4;
            this.txtMaksimumDiskon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MasterKodePromoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtMaksimumDiskon);
            this.Controls.Add(this.txtPersentaseDiskon);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.dtpBerlakuSampai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKodePromo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvKodePromo);
            this.Controls.Add(this.lblSubheader);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MasterKodePromoForm";
            this.Size = new System.Drawing.Size(684, 500);
            this.Load += new System.EventHandler(this.MasterKodePromoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKodePromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersentaseDiskon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaksimumDiskon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubheader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvKodePromo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKodePromo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBerlakuSampai;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtPersentaseDiskon;
        private System.Windows.Forms.NumericUpDown txtMaksimumDiskon;
    }
}
