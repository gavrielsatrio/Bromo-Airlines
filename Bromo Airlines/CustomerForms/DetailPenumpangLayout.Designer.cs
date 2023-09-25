namespace Bromo_Airlines.CustomerForms
{
    partial class DetailPenumpangLayout
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
            this.lblNomorPenumpang = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboTitel = new System.Windows.Forms.ComboBox();
            this.txtNamaLengkap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomorPenumpang
            // 
            this.lblNomorPenumpang.AutoSize = true;
            this.lblNomorPenumpang.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomorPenumpang.Location = new System.Drawing.Point(4, 12);
            this.lblNomorPenumpang.Margin = new System.Windows.Forms.Padding(5);
            this.lblNomorPenumpang.Name = "lblNomorPenumpang";
            this.lblNomorPenumpang.Size = new System.Drawing.Size(100, 16);
            this.lblNomorPenumpang.TabIndex = 11;
            this.lblNomorPenumpang.Text = "Penumpang #1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 14);
            this.label7.TabIndex = 18;
            this.label7.Text = "Titel";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboTitel
            // 
            this.comboTitel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTitel.FormattingEnabled = true;
            this.comboTitel.Items.AddRange(new object[] {
            "- Pilih Titel -",
            "Tuan",
            "Nyonya"});
            this.comboTitel.Location = new System.Drawing.Point(98, 38);
            this.comboTitel.Margin = new System.Windows.Forms.Padding(5);
            this.comboTitel.Name = "comboTitel";
            this.comboTitel.Size = new System.Drawing.Size(113, 22);
            this.comboTitel.TabIndex = 19;
            // 
            // txtNamaLengkap
            // 
            this.txtNamaLengkap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamaLengkap.Location = new System.Drawing.Point(98, 70);
            this.txtNamaLengkap.Margin = new System.Windows.Forms.Padding(5);
            this.txtNamaLengkap.Name = "txtNamaLengkap";
            this.txtNamaLengkap.Size = new System.Drawing.Size(302, 21);
            this.txtNamaLengkap.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nama Lengkap";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(95, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "Isi sesuai KTP/Paspor/SIM (tanpa tanda baca dan gelar)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DetailPenumpangLayout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtNamaLengkap);
            this.Controls.Add(this.comboTitel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNomorPenumpang);
            this.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DetailPenumpangLayout";
            this.Size = new System.Drawing.Size(428, 130);
            this.Load += new System.EventHandler(this.DetailPenumpangLayout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomorPenumpang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboTitel;
        private System.Windows.Forms.TextBox txtNamaLengkap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
