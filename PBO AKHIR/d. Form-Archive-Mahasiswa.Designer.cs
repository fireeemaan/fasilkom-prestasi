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
            sidePanel = new Panel();
            btnHome = new Button();
            btnRecord = new Button();
            btnEditAchievement = new Krypton.Toolkit.KryptonButton();
            btnBackAchievement = new Krypton.Toolkit.KryptonButton();
            btnAddAchievement = new Krypton.Toolkit.KryptonButton();
            cbxDosen = new ComboBox();
            cbxTahapan = new ComboBox();
            cbxBidang = new ComboBox();
            cbxRegion = new ComboBox();
            tbxSertifikat = new TextBox();
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
            panel1.Controls.Add(sidePanel);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnRecord);
            panel1.Controls.Add(btnEditAchievement);
            panel1.Controls.Add(btnBackAchievement);
            panel1.Controls.Add(btnAddAchievement);
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
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(189, 209, 255);
            sidePanel.ForeColor = Color.White;
            sidePanel.Location = new Point(2, 175);
            sidePanel.Margin = new Padding(2);
            sidePanel.MaximumSize = new Size(8, 48);
            sidePanel.MinimumSize = new Size(8, 48);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(8, 48);
            sidePanel.TabIndex = 24;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.White;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(11, 122);
            btnHome.Margin = new Padding(2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(232, 48);
            btnHome.TabIndex = 23;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnRecord
            // 
            btnRecord.BackColor = Color.White;
            btnRecord.FlatAppearance.BorderSize = 0;
            btnRecord.FlatStyle = FlatStyle.Flat;
            btnRecord.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRecord.Image = (Image)resources.GetObject("btnRecord.Image");
            btnRecord.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecord.Location = new Point(11, 175);
            btnRecord.Margin = new Padding(2);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(232, 48);
            btnRecord.TabIndex = 25;
            btnRecord.Text = "Record";
            btnRecord.UseVisualStyleBackColor = false;
            // 
            // btnEditAchievement
            // 
            btnEditAchievement.CornerRoundingRadius = 30F;
            btnEditAchievement.Location = new Point(807, 585);
            btnEditAchievement.Margin = new Padding(2);
            btnEditAchievement.MaximumSize = new Size(248, 47);
            btnEditAchievement.MinimumSize = new Size(248, 47);
            btnEditAchievement.Name = "btnEditAchievement";
            btnEditAchievement.OverrideDefault.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditAchievement.OverrideDefault.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditAchievement.OverrideFocus.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditAchievement.OverrideFocus.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditAchievement.Size = new Size(248, 47);
            btnEditAchievement.StateCommon.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditAchievement.StateCommon.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditAchievement.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEditAchievement.StateCommon.Border.Rounding = 30F;
            btnEditAchievement.StateCommon.Content.ShortText.Color1 = Color.White;
            btnEditAchievement.StateCommon.Content.ShortText.Color2 = Color.White;
            btnEditAchievement.StateCommon.Content.ShortText.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditAchievement.StateNormal.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditAchievement.StateNormal.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditAchievement.StatePressed.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditAchievement.StatePressed.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditAchievement.TabIndex = 22;
            btnEditAchievement.Values.Text = "Save Changes";
            btnEditAchievement.Click += btnEditAchievement_Click;
            // 
            // btnBackAchievement
            // 
            btnBackAchievement.CornerRoundingRadius = 10F;
            btnBackAchievement.Location = new Point(361, 173);
            btnBackAchievement.Margin = new Padding(2);
            btnBackAchievement.MaximumSize = new Size(36, 36);
            btnBackAchievement.MinimumSize = new Size(36, 36);
            btnBackAchievement.Name = "btnBackAchievement";
            btnBackAchievement.OverrideDefault.Back.Color1 = Color.WhiteSmoke;
            btnBackAchievement.OverrideDefault.Back.Color2 = Color.WhiteSmoke;
            btnBackAchievement.Size = new Size(36, 36);
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
            btnBackAchievement.TabIndex = 21;
            btnBackAchievement.Values.Text = "";
            btnBackAchievement.Click += btnBackAchievement_Click;
            // 
            // btnAddAchievement
            // 
            btnAddAchievement.CornerRoundingRadius = 30F;
            btnAddAchievement.Location = new Point(807, 585);
            btnAddAchievement.Margin = new Padding(2);
            btnAddAchievement.MaximumSize = new Size(248, 47);
            btnAddAchievement.MinimumSize = new Size(248, 47);
            btnAddAchievement.Name = "btnAddAchievement";
            btnAddAchievement.OverrideDefault.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddAchievement.OverrideDefault.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddAchievement.OverrideFocus.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddAchievement.OverrideFocus.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddAchievement.Size = new Size(248, 47);
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
            btnAddAchievement.TabIndex = 20;
            btnAddAchievement.Values.Text = "Add";
            btnAddAchievement.Click += btnAddAchievement_Click;
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
            // cbxTahapan
            // 
            cbxTahapan.FlatStyle = FlatStyle.Flat;
            cbxTahapan.FormattingEnabled = true;
            cbxTahapan.Location = new Point(959, 390);
            cbxTahapan.Name = "cbxTahapan";
            cbxTahapan.Size = new Size(483, 28);
            cbxTahapan.TabIndex = 8;
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
            // cbxRegion
            // 
            cbxRegion.FlatStyle = FlatStyle.Flat;
            cbxRegion.FormattingEnabled = true;
            cbxRegion.Location = new Point(404, 390);
            cbxRegion.Name = "cbxRegion";
            cbxRegion.Size = new Size(483, 28);
            cbxRegion.TabIndex = 6;
            // 
            // tbxSertifikat
            // 
            tbxSertifikat.BorderStyle = BorderStyle.None;
            tbxSertifikat.Location = new Point(959, 490);
            tbxSertifikat.Name = "tbxSertifikat";
            tbxSertifikat.Size = new Size(483, 20);
            tbxSertifikat.TabIndex = 5;
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
        private ComboBox cbxRegion;
        private Krypton.Toolkit.KryptonButton btnAddAchievement;
        private Krypton.Toolkit.KryptonButton btnBackAchievement;
        private Krypton.Toolkit.KryptonButton btnEditAchievement;
        private Panel sidePanel;
        private Button btnHome;
        private Button btnRecord;
        private ComboBox cbxBidang;
    }
}