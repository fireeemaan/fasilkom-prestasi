namespace fasilkom_prestasi
{
    partial class Form_Convertion_Mahasiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Convertion_Mahasiswa));
            tbxNamaLomba = new TextBox();
            tbxRegion = new TextBox();
            tbxTahapan = new TextBox();
            tbxBidang = new TextBox();
            tbxNilai = new TextBox();
            cbxMatkulPilihan = new ComboBox();
            btnAddConvertion = new Krypton.Toolkit.KryptonButton();
            btnBackConvertion = new Krypton.Toolkit.KryptonButton();
            dgvKonversiMatkul = new Krypton.Toolkit.KryptonDataGridView();
            tbxSKS = new TextBox();
            btnAddMK = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)dgvKonversiMatkul).BeginInit();
            SuspendLayout();
            // 
            // tbxNamaLomba
            // 
            tbxNamaLomba.BackColor = Color.White;
            tbxNamaLomba.BorderStyle = BorderStyle.None;
            tbxNamaLomba.Enabled = false;
            tbxNamaLomba.Location = new Point(402, 265);
            tbxNamaLomba.Name = "tbxNamaLomba";
            tbxNamaLomba.ReadOnly = true;
            tbxNamaLomba.Size = new Size(483, 20);
            tbxNamaLomba.TabIndex = 1;
            // 
            // tbxRegion
            // 
            tbxRegion.BackColor = Color.White;
            tbxRegion.BorderStyle = BorderStyle.None;
            tbxRegion.Enabled = false;
            tbxRegion.Location = new Point(402, 362);
            tbxRegion.Name = "tbxRegion";
            tbxRegion.ReadOnly = true;
            tbxRegion.Size = new Size(483, 20);
            tbxRegion.TabIndex = 2;
            // 
            // tbxTahapan
            // 
            tbxTahapan.BackColor = Color.White;
            tbxTahapan.BorderStyle = BorderStyle.None;
            tbxTahapan.Enabled = false;
            tbxTahapan.Location = new Point(958, 362);
            tbxTahapan.Name = "tbxTahapan";
            tbxTahapan.ReadOnly = true;
            tbxTahapan.Size = new Size(483, 20);
            tbxTahapan.TabIndex = 3;
            // 
            // tbxBidang
            // 
            tbxBidang.BackColor = Color.White;
            tbxBidang.BorderStyle = BorderStyle.None;
            tbxBidang.Enabled = false;
            tbxBidang.Location = new Point(958, 265);
            tbxBidang.Name = "tbxBidang";
            tbxBidang.ReadOnly = true;
            tbxBidang.Size = new Size(483, 20);
            tbxBidang.TabIndex = 4;
            // 
            // tbxNilai
            // 
            tbxNilai.BackColor = Color.White;
            tbxNilai.BorderStyle = BorderStyle.None;
            tbxNilai.Enabled = false;
            tbxNilai.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbxNilai.Location = new Point(414, 448);
            tbxNilai.Name = "tbxNilai";
            tbxNilai.ReadOnly = true;
            tbxNilai.Size = new Size(54, 45);
            tbxNilai.TabIndex = 5;
            tbxNilai.TextAlign = HorizontalAlignment.Center;
            // 
            // cbxMatkulPilihan
            // 
            cbxMatkulPilihan.FlatStyle = FlatStyle.Flat;
            cbxMatkulPilihan.FormattingEnabled = true;
            cbxMatkulPilihan.Location = new Point(650, 475);
            cbxMatkulPilihan.Name = "cbxMatkulPilihan";
            cbxMatkulPilihan.Size = new Size(732, 28);
            cbxMatkulPilihan.TabIndex = 6;
            // 
            // btnAddConvertion
            // 
            btnAddConvertion.CornerRoundingRadius = 30F;
            btnAddConvertion.Location = new Point(797, 731);
            btnAddConvertion.Margin = new Padding(2);
            btnAddConvertion.MaximumSize = new Size(248, 47);
            btnAddConvertion.MinimumSize = new Size(248, 47);
            btnAddConvertion.Name = "btnAddConvertion";
            btnAddConvertion.OverrideDefault.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddConvertion.OverrideDefault.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddConvertion.OverrideFocus.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddConvertion.OverrideFocus.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddConvertion.Size = new Size(248, 47);
            btnAddConvertion.StateCommon.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddConvertion.StateCommon.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddConvertion.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddConvertion.StateCommon.Border.Rounding = 30F;
            btnAddConvertion.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAddConvertion.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAddConvertion.StateCommon.Content.ShortText.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddConvertion.StateNormal.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddConvertion.StateNormal.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddConvertion.StatePressed.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddConvertion.StatePressed.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddConvertion.TabIndex = 23;
            btnAddConvertion.Values.Text = "Add Convertion";
            btnAddConvertion.Click += btnAddConvertion_Click;
            // 
            // btnBackConvertion
            // 
            btnBackConvertion.CornerRoundingRadius = 10F;
            btnBackConvertion.Location = new Point(363, 174);
            btnBackConvertion.Margin = new Padding(2);
            btnBackConvertion.MaximumSize = new Size(36, 36);
            btnBackConvertion.MinimumSize = new Size(36, 36);
            btnBackConvertion.Name = "btnBackConvertion";
            btnBackConvertion.OverrideDefault.Back.Color1 = Color.WhiteSmoke;
            btnBackConvertion.OverrideDefault.Back.Color2 = Color.WhiteSmoke;
            btnBackConvertion.Size = new Size(36, 36);
            btnBackConvertion.StateCommon.Back.Color1 = Color.Transparent;
            btnBackConvertion.StateCommon.Back.Color2 = Color.Transparent;
            btnBackConvertion.StateCommon.Back.Image = (Image)resources.GetObject("btnBackConvertion.StateCommon.Back.Image");
            btnBackConvertion.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnBackConvertion.StateCommon.Border.Color1 = Color.White;
            btnBackConvertion.StateCommon.Border.Color2 = Color.White;
            btnBackConvertion.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBackConvertion.StateCommon.Border.Rounding = 10F;
            btnBackConvertion.StatePressed.Back.Color1 = Color.WhiteSmoke;
            btnBackConvertion.StatePressed.Back.Color2 = Color.WhiteSmoke;
            btnBackConvertion.TabIndex = 24;
            btnBackConvertion.Values.Text = "";
            btnBackConvertion.Click += btnBackConvertion_Click;
            // 
            // dgvKonversiMatkul
            // 
            dgvKonversiMatkul.AllowUserToAddRows = false;
            dgvKonversiMatkul.AllowUserToDeleteRows = false;
            dgvKonversiMatkul.AllowUserToResizeColumns = false;
            dgvKonversiMatkul.AllowUserToResizeRows = false;
            dgvKonversiMatkul.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKonversiMatkul.BorderStyle = BorderStyle.None;
            dgvKonversiMatkul.ColumnHeadersHeight = 36;
            dgvKonversiMatkul.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKonversiMatkul.Location = new Point(338, 523);
            dgvKonversiMatkul.Name = "dgvKonversiMatkul";
            dgvKonversiMatkul.RowHeadersVisible = false;
            dgvKonversiMatkul.RowHeadersWidth = 51;
            dgvKonversiMatkul.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKonversiMatkul.RowTemplate.Height = 45;
            dgvKonversiMatkul.Size = new Size(1170, 187);
            dgvKonversiMatkul.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvKonversiMatkul.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvKonversiMatkul.TabIndex = 25;
            // 
            // tbxSKS
            // 
            tbxSKS.BackColor = Color.White;
            tbxSKS.BorderStyle = BorderStyle.None;
            tbxSKS.Enabled = false;
            tbxSKS.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbxSKS.Location = new Point(527, 448);
            tbxSKS.Name = "tbxSKS";
            tbxSKS.ReadOnly = true;
            tbxSKS.Size = new Size(54, 45);
            tbxSKS.TabIndex = 26;
            tbxSKS.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAddMK
            // 
            btnAddMK.CornerRoundingRadius = 12F;
            btnAddMK.Location = new Point(1410, 470);
            btnAddMK.Name = "btnAddMK";
            btnAddMK.OverrideDefault.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddMK.OverrideDefault.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddMK.OverrideDefault.Border.Color1 = Color.FromArgb(128, 167, 255);
            btnAddMK.OverrideDefault.Border.Color2 = Color.FromArgb(128, 167, 255);
            btnAddMK.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddMK.Size = new Size(40, 39);
            btnAddMK.StateCommon.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddMK.StateCommon.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddMK.StateCommon.Back.Image = (Image)resources.GetObject("btnAddMK.StateCommon.Back.Image");
            btnAddMK.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAddMK.StateCommon.Border.Color1 = Color.FromArgb(128, 167, 255);
            btnAddMK.StateCommon.Border.Color2 = Color.FromArgb(128, 167, 255);
            btnAddMK.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddMK.StateCommon.Border.Rounding = 12F;
            btnAddMK.StateCommon.Content.ShortText.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddMK.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            btnAddMK.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            btnAddMK.StateNormal.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddMK.StateNormal.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddMK.StateNormal.Border.Color1 = Color.FromArgb(128, 167, 255);
            btnAddMK.StateNormal.Border.Color2 = Color.FromArgb(128, 167, 255);
            btnAddMK.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddMK.StatePressed.Back.Color1 = Color.FromArgb(124, 161, 246);
            btnAddMK.StatePressed.Back.Color2 = Color.FromArgb(124, 161, 246);
            btnAddMK.StatePressed.Border.Color1 = Color.FromArgb(124, 161, 246);
            btnAddMK.StatePressed.Border.Color2 = Color.FromArgb(124, 161, 246);
            btnAddMK.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddMK.TabIndex = 27;
            btnAddMK.Values.Text = "";
            btnAddMK.Click += btnAddMK_Click;
            // 
            // Form_Convertion_Mahasiswa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(btnAddMK);
            Controls.Add(tbxSKS);
            Controls.Add(dgvKonversiMatkul);
            Controls.Add(btnBackConvertion);
            Controls.Add(btnAddConvertion);
            Controls.Add(cbxMatkulPilihan);
            Controls.Add(tbxNilai);
            Controls.Add(tbxBidang);
            Controls.Add(tbxTahapan);
            Controls.Add(tbxRegion);
            Controls.Add(tbxNamaLomba);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Convertion_Mahasiswa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Convertion Mahasiswa";
            FormClosing += Form_Convertion_Mahasiswa_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvKonversiMatkul).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxNamaLomba;
        private TextBox tbxRegion;
        private TextBox tbxTahapan;
        private TextBox tbxBidang;
        private TextBox tbxNilai;
        private ComboBox cbxMatkulPilihan;
        private Krypton.Toolkit.KryptonButton btnAddConvertion;
        private Krypton.Toolkit.KryptonButton btnBackConvertion;
        private Krypton.Toolkit.KryptonDataGridView dgvKonversiMatkul;
        private TextBox tbxSKS;
        private Krypton.Toolkit.KryptonButton btnAddMK;
    }
}