namespace fasilkom_prestasi
{
    partial class EditAchievement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAchievement));
            panel1 = new Panel();
            panel2 = new Panel();
            tbxSertifikat = new TextBox();
            cbxRegion = new ComboBox();
            cbxDosen = new ComboBox();
            cbxTahapan = new ComboBox();
            cbxBidang = new ComboBox();
            tbxNamaLomba = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1578, 844);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(tbxSertifikat);
            panel2.Controls.Add(tbxNamaLomba);
            panel2.Controls.Add(cbxRegion);
            panel2.Controls.Add(cbxBidang);
            panel2.Controls.Add(cbxDosen);
            panel2.Controls.Add(cbxTahapan);
            panel2.Location = new Point(337, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(1170, 672);
            panel2.TabIndex = 0;
            // 
            // tbxSertifikat
            // 
            tbxSertifikat.BorderStyle = BorderStyle.None;
            tbxSertifikat.Font = new Font("Poppins Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tbxSertifikat.Location = new Point(653, 337);
            tbxSertifikat.Name = "tbxSertifikat";
            tbxSertifikat.Size = new Size(441, 30);
            tbxSertifikat.TabIndex = 31;
            // 
            // cbxRegion
            // 
            cbxRegion.FlatStyle = FlatStyle.Flat;
            cbxRegion.FormattingEnabled = true;
            cbxRegion.Location = new Point(653, 235);
            cbxRegion.Name = "cbxRegion";
            cbxRegion.Size = new Size(441, 33);
            cbxRegion.TabIndex = 30;
            // 
            // cbxDosen
            // 
            cbxDosen.FlatStyle = FlatStyle.Flat;
            cbxDosen.FormattingEnabled = true;
            cbxDosen.Location = new Point(71, 436);
            cbxDosen.Name = "cbxDosen";
            cbxDosen.Size = new Size(475, 33);
            cbxDosen.TabIndex = 29;
            // 
            // cbxTahapan
            // 
            cbxTahapan.FlatStyle = FlatStyle.Flat;
            cbxTahapan.FormattingEnabled = true;
            cbxTahapan.Location = new Point(71, 337);
            cbxTahapan.Name = "cbxTahapan";
            cbxTahapan.Size = new Size(475, 33);
            cbxTahapan.TabIndex = 28;
            // 
            // cbxBidang
            // 
            cbxBidang.FlatStyle = FlatStyle.Flat;
            cbxBidang.FormattingEnabled = true;
            cbxBidang.Location = new Point(71, 235);
            cbxBidang.Name = "cbxBidang";
            cbxBidang.Size = new Size(475, 33);
            cbxBidang.TabIndex = 27;
            // 
            // tbxNamaLomba
            // 
            tbxNamaLomba.BorderStyle = BorderStyle.None;
            tbxNamaLomba.Font = new Font("Poppins Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tbxNamaLomba.Location = new Point(71, 134);
            tbxNamaLomba.Name = "tbxNamaLomba";
            tbxNamaLomba.Size = new Size(1023, 30);
            tbxNamaLomba.TabIndex = 26;
            // 
            // EditAchievement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 844);
            Controls.Add(panel1);
            Name = "EditAchievement";
            Text = "EditAchievement";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox tbxSertifikat;
        private TextBox tbxNamaLomba;
        private ComboBox cbxRegion;
        private ComboBox cbxBidang;
        private ComboBox cbxDosen;
        private ComboBox cbxTahapan;
    }
}