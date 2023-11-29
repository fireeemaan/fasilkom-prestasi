namespace fasilkom_prestasi
{
    partial class AddAchievement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAchievement));
            panel1 = new Panel();
            panel2 = new Panel();
            btnAddAchievement = new Krypton.Toolkit.KryptonButton();
            btnBackAchievement = new Krypton.Toolkit.KryptonButton();
            sidePanel = new Panel();
            btnHome = new Button();
            btnRecord = new Button();
            tbxNamaLomba = new TextBox();
            cbxBidang = new ComboBox();
            cbxTahapan = new ComboBox();
            cbxDosen = new ComboBox();
            cbxRegion = new ComboBox();
            tbxSertifikat = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(sidePanel);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnRecord);
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
            panel2.Controls.Add(cbxRegion);
            panel2.Controls.Add(cbxDosen);
            panel2.Controls.Add(cbxTahapan);
            panel2.Controls.Add(cbxBidang);
            panel2.Controls.Add(tbxNamaLomba);
            panel2.Controls.Add(btnAddAchievement);
            panel2.Controls.Add(btnBackAchievement);
            panel2.Location = new Point(337, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(1170, 672);
            panel2.TabIndex = 6;
            // 
            // btnAddAchievement
            // 
            btnAddAchievement.CornerRoundingRadius = 30F;
            btnAddAchievement.Location = new Point(429, 542);
            btnAddAchievement.MaximumSize = new Size(310, 59);
            btnAddAchievement.MinimumSize = new Size(310, 59);
            btnAddAchievement.Name = "btnAddAchievement";
            btnAddAchievement.OverrideDefault.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddAchievement.OverrideDefault.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddAchievement.OverrideFocus.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddAchievement.OverrideFocus.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddAchievement.Size = new Size(310, 59);
            btnAddAchievement.StateCommon.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddAchievement.StateCommon.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddAchievement.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddAchievement.StateCommon.Border.Rounding = 30F;
            btnAddAchievement.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAddAchievement.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAddAchievement.StateCommon.Content.ShortText.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddAchievement.StateNormal.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddAchievement.StateNormal.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddAchievement.StatePressed.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddAchievement.StatePressed.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddAchievement.TabIndex = 19;
            btnAddAchievement.Values.Text = "Add";
            btnAddAchievement.Click += btnAddAchievement_Click;
            // 
            // btnBackAchievement
            // 
            btnBackAchievement.CornerRoundingRadius = 10F;
            btnBackAchievement.Location = new Point(27, 17);
            btnBackAchievement.MaximumSize = new Size(45, 45);
            btnBackAchievement.MinimumSize = new Size(45, 45);
            btnBackAchievement.Name = "btnBackAchievement";
            btnBackAchievement.OverrideDefault.Back.Color1 = Color.WhiteSmoke;
            btnBackAchievement.OverrideDefault.Back.Color2 = Color.WhiteSmoke;
            btnBackAchievement.Size = new Size(45, 45);
            btnBackAchievement.StateCommon.Back.Color1 = Color.Transparent;
            btnBackAchievement.StateCommon.Back.Color2 = Color.Transparent;
            btnBackAchievement.StateCommon.Back.Image = (Image)resources.GetObject("btnBackAchievement.StateCommon.Back.Image");
            btnBackAchievement.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnBackAchievement.StateCommon.Border.Color1 = Color.White;
            btnBackAchievement.StateCommon.Border.Color2 = Color.White;
            btnBackAchievement.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBackAchievement.StateCommon.Border.Rounding = 10F;
            btnBackAchievement.StatePressed.Back.Color1 = Color.WhiteSmoke;
            btnBackAchievement.StatePressed.Back.Color2 = Color.WhiteSmoke;
            btnBackAchievement.TabIndex = 12;
            btnBackAchievement.Values.Text = "";
            btnBackAchievement.Click += btnBackAchievement_Click;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(189, 209, 255);
            sidePanel.ForeColor = Color.White;
            sidePanel.Location = new Point(3, 178);
            sidePanel.MaximumSize = new Size(10, 58);
            sidePanel.MinimumSize = new Size(10, 58);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(10, 58);
            sidePanel.TabIndex = 4;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.White;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(12, 114);
            btnHome.MaximumSize = new Size(234, 58);
            btnHome.MinimumSize = new Size(234, 58);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(234, 58);
            btnHome.TabIndex = 3;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnRecord
            // 
            btnRecord.BackColor = Color.White;
            btnRecord.FlatAppearance.BorderSize = 0;
            btnRecord.FlatStyle = FlatStyle.Flat;
            btnRecord.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRecord.Image = (Image)resources.GetObject("btnRecord.Image");
            btnRecord.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecord.Location = new Point(12, 178);
            btnRecord.MaximumSize = new Size(234, 58);
            btnRecord.MinimumSize = new Size(234, 58);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(234, 58);
            btnRecord.TabIndex = 5;
            btnRecord.Text = "Record";
            btnRecord.UseVisualStyleBackColor = false;
            // 
            // tbxNamaLomba
            // 
            tbxNamaLomba.BorderStyle = BorderStyle.None;
            tbxNamaLomba.Font = new Font("Poppins Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tbxNamaLomba.Location = new Point(70, 133);
            tbxNamaLomba.Name = "tbxNamaLomba";
            tbxNamaLomba.Size = new Size(1023, 30);
            tbxNamaLomba.TabIndex = 20;
            // 
            // cbxBidang
            // 
            cbxBidang.FlatStyle = FlatStyle.Flat;
            cbxBidang.FormattingEnabled = true;
            cbxBidang.Location = new Point(70, 234);
            cbxBidang.Name = "cbxBidang";
            cbxBidang.Size = new Size(475, 33);
            cbxBidang.TabIndex = 21;
            // 
            // cbxTahapan
            // 
            cbxTahapan.FlatStyle = FlatStyle.Flat;
            cbxTahapan.FormattingEnabled = true;
            cbxTahapan.Location = new Point(70, 336);
            cbxTahapan.Name = "cbxTahapan";
            cbxTahapan.Size = new Size(475, 33);
            cbxTahapan.TabIndex = 22;
            // 
            // cbxDosen
            // 
            cbxDosen.FlatStyle = FlatStyle.Flat;
            cbxDosen.FormattingEnabled = true;
            cbxDosen.Location = new Point(70, 435);
            cbxDosen.Name = "cbxDosen";
            cbxDosen.Size = new Size(475, 33);
            cbxDosen.TabIndex = 23;
            // 
            // cbxRegion
            // 
            cbxRegion.FlatStyle = FlatStyle.Flat;
            cbxRegion.FormattingEnabled = true;
            cbxRegion.Location = new Point(652, 234);
            cbxRegion.Name = "cbxRegion";
            cbxRegion.Size = new Size(441, 33);
            cbxRegion.TabIndex = 24;
            // 
            // tbxSertifikat
            // 
            tbxSertifikat.BorderStyle = BorderStyle.None;
            tbxSertifikat.Font = new Font("Poppins Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tbxSertifikat.Location = new Point(652, 336);
            tbxSertifikat.Name = "tbxSertifikat";
            tbxSertifikat.Size = new Size(441, 30);
            tbxSertifikat.TabIndex = 25;
            // 
            // AddAchievement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 844);
            Controls.Add(panel1);
            Name = "AddAchievement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAchievement";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel sidePanel;
        private Button btnHome;
        private Button btnRecord;
        private Panel panel2;
        private Krypton.Toolkit.KryptonButton btnBackAchievement;
        private Krypton.Toolkit.KryptonButton btnAddAchievement;
        private TextBox tbxNamaLomba;
        private ComboBox cbxTahapan;
        private ComboBox cbxBidang;
        private TextBox tbxSertifikat;
        private ComboBox cbxRegion;
        private ComboBox cbxDosen;
    }
}