namespace Bromo_Airlines.CustomerForms
{
    partial class TiketSayaForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiketSayaForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSubheader = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picBoxBack = new System.Windows.Forms.PictureBox();
            this.dgvTiket = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiket)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubheader
            // 
            this.lblSubheader.AutoSize = true;
            this.lblSubheader.Location = new System.Drawing.Point(46, 46);
            this.lblSubheader.Margin = new System.Windows.Forms.Padding(5);
            this.lblSubheader.Name = "lblSubheader";
            this.lblSubheader.Size = new System.Drawing.Size(252, 14);
            this.lblSubheader.TabIndex = 4;
            this.lblSubheader.Text = "Semua tiket Anda yang aktif akan muncul di sini";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(44, 17);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(106, 23);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Tiket Saya";
            // 
            // picBoxBack
            // 
            this.picBoxBack.Image = ((System.Drawing.Image)(resources.GetObject("picBoxBack.Image")));
            this.picBoxBack.Location = new System.Drawing.Point(14, 16);
            this.picBoxBack.Margin = new System.Windows.Forms.Padding(5);
            this.picBoxBack.Name = "picBoxBack";
            this.picBoxBack.Size = new System.Drawing.Size(25, 25);
            this.picBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxBack.TabIndex = 10;
            this.picBoxBack.TabStop = false;
            this.picBoxBack.Click += new System.EventHandler(this.picBoxBack_Click);
            // 
            // dgvTiket
            // 
            this.dgvTiket.AllowUserToAddRows = false;
            this.dgvTiket.AllowUserToDeleteRows = false;
            this.dgvTiket.AllowUserToResizeRows = false;
            this.dgvTiket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTiket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTiket.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTiket.BackgroundColor = System.Drawing.Color.White;
            this.dgvTiket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTiket.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTiket.Location = new System.Drawing.Point(14, 75);
            this.dgvTiket.Margin = new System.Windows.Forms.Padding(5);
            this.dgvTiket.Name = "dgvTiket";
            this.dgvTiket.ReadOnly = true;
            this.dgvTiket.RowHeadersVisible = false;
            this.dgvTiket.Size = new System.Drawing.Size(854, 272);
            this.dgvTiket.TabIndex = 11;
            // 
            // TiketSayaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.dgvTiket);
            this.Controls.Add(this.picBoxBack);
            this.Controls.Add(this.lblSubheader);
            this.Controls.Add(this.lblHeader);
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "TiketSayaForm";
            this.Text = "Bromo Airlines - Tiket Saya";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TiketSayaForm_FormClosed);
            this.Load += new System.EventHandler(this.TiketSayaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubheader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox picBoxBack;
        private System.Windows.Forms.DataGridView dgvTiket;
    }
}