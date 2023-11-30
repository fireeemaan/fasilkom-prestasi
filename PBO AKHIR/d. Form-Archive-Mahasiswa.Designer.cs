namespace fasilkom_prestasi
{
    partial class FormArchiveMahasiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArchiveMahasiswa));
            tbxNamaLomba = new TextBox();
            panel1 = new Panel();
            tbxSertifikat = new TextBox();
            cbxRegion = new ComboBox();
            cbxBidang = new ComboBox();
            cbxTahapan = new ComboBox();
            cbxDosen = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbxNamaLomba
            // 
            tbxNamaLomba.BorderStyle = BorderStyle.None;
            tbxNamaLomba.Location = new Point(404, 296);
            tbxNamaLomba.Name = "tbxNamaLomba";
            tbxNamaLomba.Size = new Size(483, 20);
            tbxNamaLomba.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(cbxDosen);
            panel1.Controls.Add(cbxTahapan);
            panel1.Controls.Add(cbxBidang);
            panel1.Controls.Add(cbxRegion);
            panel1.Controls.Add(tbxSertifikat);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1582, 853);
            panel1.TabIndex = 4;
            // 
            // tbxSertifikat
            // 
            tbxSertifikat.BorderStyle = BorderStyle.None;
            tbxSertifikat.Location = new Point(959, 490);
            tbxSertifikat.Name = "tbxSertifikat";
            tbxSertifikat.Size = new Size(483, 20);
            tbxSertifikat.TabIndex = 5;
            // 
            // cbxRegion
            // 
            cbxRegion.FlatStyle = FlatStyle.Flat;
            cbxRegion.FormattingEnabled = true;
            cbxRegion.Location = new Point(404, 390);
            cbxRegion.Name = "cbxRegion";
            cbxRegion.Size = new Size(483, 28);
            cbxRegion.TabIndex = 6;
            // 
            // cbxBidang
            // 
            cbxBidang.FlatStyle = FlatStyle.Flat;
            cbxBidang.FormattingEnabled = true;
            cbxBidang.Location = new Point(959, 293);
            cbxBidang.Name = "cbxBidang";
            cbxBidang.Size = new Size(483, 28);
            cbxBidang.TabIndex = 7;
            // 
            // cbxTahapan
            // 
            cbxTahapan.FlatStyle = FlatStyle.Flat;
            cbxTahapan.FormattingEnabled = true;
            cbxTahapan.Location = new Point(959, 390);
            cbxTahapan.Name = "cbxTahapan";
            cbxTahapan.Size = new Size(483, 28);
            cbxTahapan.TabIndex = 8;
            // 
            // cbxDosen
            // 
            cbxDosen.FlatStyle = FlatStyle.Flat;
            cbxDosen.FormattingEnabled = true;
            cbxDosen.Location = new Point(404, 487);
            cbxDosen.Name = "cbxDosen";
            cbxDosen.Size = new Size(483, 28);
            cbxDosen.TabIndex = 9;
            // 
            // FormArchiveMahasiswa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(tbxNamaLomba);
            Controls.Add(panel1);
            Name = "FormArchiveMahasiswa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormArchiveMahasiswa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxNamaLomba;
        private Panel panel1;
        private TextBox tbxSertifikat;
        private ComboBox cbxDosen;
        private ComboBox cbxTahapan;
        private ComboBox cbxBidang;
        private ComboBox cbxRegion;
    }
}