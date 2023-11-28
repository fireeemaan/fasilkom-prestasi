namespace fasilkom_prestasi
{
    partial class AddAchievementControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAchievementControl));
            panel1 = new Panel();
            cbxBidang = new ComboBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            tbxNamaLomba = new Krypton.Toolkit.KryptonTextBox();
            label1 = new Label();
            cbxRegion = new ComboBox();
            cbxDosen = new ComboBox();
            cbxTahapan = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(cbxTahapan);
            panel1.Controls.Add(cbxDosen);
            panel1.Controls.Add(cbxRegion);
            panel1.Controls.Add(cbxBidang);
            panel1.Controls.Add(kryptonButton1);
            panel1.Controls.Add(tbxNamaLomba);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1170, 672);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // cbxBidang
            // 
            cbxBidang.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxBidang.FlatStyle = FlatStyle.Flat;
            cbxBidang.FormattingEnabled = true;
            cbxBidang.Location = new Point(68, 233);
            cbxBidang.Name = "cbxBidang";
            cbxBidang.Size = new Size(480, 33);
            cbxBidang.TabIndex = 7;
            cbxBidang.Text = "Pilih Bidang...";
            // 
            // kryptonButton1
            // 
            kryptonButton1.CornerRoundingRadius = 30F;
            kryptonButton1.Location = new Point(430, 513);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(128, 167, 255);
            kryptonButton1.OverrideDefault.Back.Color2 = Color.FromArgb(128, 167, 255);
            kryptonButton1.OverrideFocus.Back.Color1 = Color.FromArgb(128, 167, 255);
            kryptonButton1.OverrideFocus.Back.Color2 = Color.FromArgb(128, 167, 255);
            kryptonButton1.Size = new Size(310, 59);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(128, 167, 255);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(128, 167, 255);
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.Rounding = 30F;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonButton1.StateNormal.Back.Color1 = Color.FromArgb(128, 167, 255);
            kryptonButton1.StateNormal.Back.Color2 = Color.FromArgb(128, 167, 255);
            kryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(128, 167, 255);
            kryptonButton1.StatePressed.Back.Color2 = Color.FromArgb(128, 167, 255);
            kryptonButton1.TabIndex = 6;
            kryptonButton1.Values.Text = "Add";
            // 
            // tbxNamaLomba
            // 
            tbxNamaLomba.Location = new Point(68, 132);
            tbxNamaLomba.Name = "tbxNamaLomba";
            tbxNamaLomba.Size = new Size(1023, 36);
            tbxNamaLomba.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            tbxNamaLomba.StateActive.Content.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbxNamaLomba.TabIndex = 1;
            tbxNamaLomba.Text = "\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Poppins SemiBold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(456, 11);
            label1.Name = "label1";
            label1.Size = new Size(258, 46);
            label1.TabIndex = 0;
            label1.Text = "Add Achievement";
            // 
            // cbxRegion
            // 
            cbxRegion.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxRegion.FlatStyle = FlatStyle.Flat;
            cbxRegion.FormattingEnabled = true;
            cbxRegion.Location = new Point(68, 334);
            cbxRegion.Name = "cbxRegion";
            cbxRegion.Size = new Size(480, 33);
            cbxRegion.TabIndex = 8;
            cbxRegion.Text = "Pilih Region...";
            // 
            // cbxDosen
            // 
            cbxDosen.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxDosen.FlatStyle = FlatStyle.Flat;
            cbxDosen.FormattingEnabled = true;
            cbxDosen.Location = new Point(68, 436);
            cbxDosen.Name = "cbxDosen";
            cbxDosen.Size = new Size(480, 33);
            cbxDosen.TabIndex = 9;
            cbxDosen.Text = "Pilih Dosen Pembimbing...";
            // 
            // cbxTahapan
            // 
            cbxTahapan.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxTahapan.FlatStyle = FlatStyle.Flat;
            cbxTahapan.FormattingEnabled = true;
            cbxTahapan.Location = new Point(653, 334);
            cbxTahapan.Name = "cbxTahapan";
            cbxTahapan.Size = new Size(445, 33);
            cbxTahapan.TabIndex = 10;
            cbxTahapan.Text = "Pilih Tahapan...";
            // 
            // AddAchievementControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AddAchievementControl";
            Size = new Size(1170, 672);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Krypton.Toolkit.KryptonTextBox tbxNamaLomba;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComboBox cbxBidang;
        private ComboBox cbxTahapan;
        private ComboBox cbxDosen;
        private ComboBox cbxRegion;
    }
}
