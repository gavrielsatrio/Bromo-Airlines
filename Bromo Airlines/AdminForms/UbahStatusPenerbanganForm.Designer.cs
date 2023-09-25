namespace Bromo_Airlines.AdminForms
{
    partial class UbahStatusPenerbanganForm
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
            this.dgvPenerbangan = new System.Windows.Forms.DataGridView();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.txtPerkiraanDurasiDelay = new System.Windows.Forms.MaskedTextBox();
            this.lblPerkiraanDurasiDelay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenerbangan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubheader
            // 
            this.lblSubheader.AutoSize = true;
            this.lblSubheader.Location = new System.Drawing.Point(18, 46);
            this.lblSubheader.Margin = new System.Windows.Forms.Padding(5);
            this.lblSubheader.Name = "lblSubheader";
            this.lblSubheader.Size = new System.Drawing.Size(292, 14);
            this.lblSubheader.TabIndex = 6;
            this.lblSubheader.Text = "Anda bisa mengubah status jadwal penerbangan di sini";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(16, 16);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(280, 25);
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "Ubah Status Penerbangan";
            // 
            // dgvPenerbangan
            // 
            this.dgvPenerbangan.AllowUserToAddRows = false;
            this.dgvPenerbangan.AllowUserToDeleteRows = false;
            this.dgvPenerbangan.AllowUserToResizeRows = false;
            this.dgvPenerbangan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPenerbangan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPenerbangan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPenerbangan.BackgroundColor = System.Drawing.Color.White;
            this.dgvPenerbangan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPenerbangan.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPenerbangan.Location = new System.Drawing.Point(21, 74);
            this.dgvPenerbangan.Margin = new System.Windows.Forms.Padding(5);
            this.dgvPenerbangan.Name = "dgvPenerbangan";
            this.dgvPenerbangan.ReadOnly = true;
            this.dgvPenerbangan.RowHeadersVisible = false;
            this.dgvPenerbangan.Size = new System.Drawing.Size(642, 321);
            this.dgvPenerbangan.TabIndex = 0;
            this.dgvPenerbangan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPenerbangan_CellClick);
            // 
            // comboStatus
            // 
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(87, 415);
            this.comboStatus.Margin = new System.Windows.Forms.Padding(5);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(180, 22);
            this.comboStatus.TabIndex = 1;
            this.comboStatus.SelectedIndexChanged += new System.EventHandler(this.comboStatus_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(18, 418);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 14);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimpan.Location = new System.Drawing.Point(563, 455);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(5);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(100, 30);
            this.btnSimpan.TabIndex = 3;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatal.Location = new System.Drawing.Point(453, 455);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(5);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(100, 30);
            this.btnBatal.TabIndex = 4;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // txtPerkiraanDurasiDelay
            // 
            this.txtPerkiraanDurasiDelay.Location = new System.Drawing.Point(427, 415);
            this.txtPerkiraanDurasiDelay.Margin = new System.Windows.Forms.Padding(5);
            this.txtPerkiraanDurasiDelay.Mask = "00 j\\am 00 menit";
            this.txtPerkiraanDurasiDelay.Name = "txtPerkiraanDurasiDelay";
            this.txtPerkiraanDurasiDelay.Size = new System.Drawing.Size(236, 21);
            this.txtPerkiraanDurasiDelay.TabIndex = 2;
            // 
            // lblPerkiraanDurasiDelay
            // 
            this.lblPerkiraanDurasiDelay.AutoSize = true;
            this.lblPerkiraanDurasiDelay.Location = new System.Drawing.Point(296, 418);
            this.lblPerkiraanDurasiDelay.Margin = new System.Windows.Forms.Padding(5);
            this.lblPerkiraanDurasiDelay.Name = "lblPerkiraanDurasiDelay";
            this.lblPerkiraanDurasiDelay.Size = new System.Drawing.Size(123, 14);
            this.lblPerkiraanDurasiDelay.TabIndex = 12;
            this.lblPerkiraanDurasiDelay.Text = "Perkiraan Durasi Delay";
            // 
            // UbahStatusPenerbanganForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtPerkiraanDurasiDelay);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.lblPerkiraanDurasiDelay);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgvPenerbangan);
            this.Controls.Add(this.lblSubheader);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UbahStatusPenerbanganForm";
            this.Size = new System.Drawing.Size(684, 500);
            this.Load += new System.EventHandler(this.UbahStatusPenerbanganForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenerbangan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubheader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvPenerbangan;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.MaskedTextBox txtPerkiraanDurasiDelay;
        private System.Windows.Forms.Label lblPerkiraanDurasiDelay;
    }
}
