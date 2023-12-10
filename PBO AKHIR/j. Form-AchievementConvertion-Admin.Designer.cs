namespace fasilkom_prestasi
{
    partial class Form_ConvertionValidation_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ConvertionValidation_Admin));
            dgvMatkulKonversi = new Krypton.Toolkit.KryptonDataGridView();
            tbxBidang = new TextBox();
            tbxNilai = new TextBox();
            btnBackConvertion = new Krypton.Toolkit.KryptonButton();
            btnAddConvertion = new Krypton.Toolkit.KryptonButton();
            tbxRegion = new TextBox();
            tbxNamaLomba = new TextBox();
            tbxTahapan = new TextBox();
            tbxNama = new TextBox();
            tbxNIM = new TextBox();
            tbxLinkDok = new TextBox();
            rbtnReject = new RadioButton();
            rbtnAccept = new RadioButton();
            tbxJumlahSKS = new TextBox();
            panel2 = new Panel();
            lblNamaAdmin = new Label();
            btnLogout = new Krypton.Toolkit.KryptonButton();
            lblNIP = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMatkulKonversi).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMatkulKonversi
            // 
            dgvMatkulKonversi.AllowUserToAddRows = false;
            dgvMatkulKonversi.AllowUserToDeleteRows = false;
            dgvMatkulKonversi.AllowUserToResizeColumns = false;
            dgvMatkulKonversi.AllowUserToResizeRows = false;
            dgvMatkulKonversi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatkulKonversi.BorderStyle = BorderStyle.None;
            dgvMatkulKonversi.ColumnHeadersHeight = 36;
            dgvMatkulKonversi.Location = new Point(331, 227);
            dgvMatkulKonversi.Name = "dgvMatkulKonversi";
            dgvMatkulKonversi.ReadOnly = true;
            dgvMatkulKonversi.RowHeadersVisible = false;
            dgvMatkulKonversi.RowHeadersWidth = 51;
            dgvMatkulKonversi.RowTemplate.Height = 29;
            dgvMatkulKonversi.Size = new Size(1170, 182);
            dgvMatkulKonversi.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvMatkulKonversi.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvMatkulKonversi.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvMatkulKonversi.TabIndex = 8;
            dgvMatkulKonversi.CellContentDoubleClick += dgvMatkulKonversi_CellContentDoubleClick;
            // 
            // tbxBidang
            // 
            tbxBidang.BackColor = Color.White;
            tbxBidang.BorderStyle = BorderStyle.None;
            tbxBidang.Enabled = false;
            tbxBidang.Location = new Point(956, 617);
            tbxBidang.Name = "tbxBidang";
            tbxBidang.ReadOnly = true;
            tbxBidang.Size = new Size(248, 20);
            tbxBidang.TabIndex = 7;
            // 
            // tbxNilai
            // 
            tbxNilai.BackColor = Color.White;
            tbxNilai.BorderStyle = BorderStyle.None;
            tbxNilai.Enabled = false;
            tbxNilai.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbxNilai.Location = new Point(850, 688);
            tbxNilai.Name = "tbxNilai";
            tbxNilai.ReadOnly = true;
            tbxNilai.Size = new Size(54, 45);
            tbxNilai.TabIndex = 9;
            tbxNilai.TextAlign = HorizontalAlignment.Center;
            // 
            // btnBackConvertion
            // 
            btnBackConvertion.CornerRoundingRadius = 10F;
            btnBackConvertion.Location = new Point(352, 170);
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
            btnBackConvertion.TabIndex = 25;
            btnBackConvertion.Values.Text = "";
            btnBackConvertion.Click += btnBackConvertion_Click;
            // 
            // btnAddConvertion
            // 
            btnAddConvertion.CornerRoundingRadius = 30F;
            btnAddConvertion.Location = new Point(1161, 686);
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
            btnAddConvertion.TabIndex = 24;
            btnAddConvertion.Values.Text = "Save Changes";
            btnAddConvertion.Click += btnAddConvertion_Click;
            // 
            // tbxRegion
            // 
            tbxRegion.BackColor = Color.White;
            tbxRegion.BorderStyle = BorderStyle.None;
            tbxRegion.Enabled = false;
            tbxRegion.Location = new Point(1246, 617);
            tbxRegion.Name = "tbxRegion";
            tbxRegion.ReadOnly = true;
            tbxRegion.Size = new Size(153, 20);
            tbxRegion.TabIndex = 26;
            // 
            // tbxNamaLomba
            // 
            tbxNamaLomba.BackColor = Color.White;
            tbxNamaLomba.BorderStyle = BorderStyle.None;
            tbxNamaLomba.Enabled = false;
            tbxNamaLomba.Location = new Point(956, 451);
            tbxNamaLomba.Name = "tbxNamaLomba";
            tbxNamaLomba.ReadOnly = true;
            tbxNamaLomba.Size = new Size(443, 20);
            tbxNamaLomba.TabIndex = 27;
            // 
            // tbxTahapan
            // 
            tbxTahapan.BackColor = Color.White;
            tbxTahapan.BorderStyle = BorderStyle.None;
            tbxTahapan.Enabled = false;
            tbxTahapan.Location = new Point(956, 537);
            tbxTahapan.Name = "tbxTahapan";
            tbxTahapan.ReadOnly = true;
            tbxTahapan.Size = new Size(443, 20);
            tbxTahapan.TabIndex = 28;
            // 
            // tbxNama
            // 
            tbxNama.BackColor = Color.White;
            tbxNama.BorderStyle = BorderStyle.None;
            tbxNama.Enabled = false;
            tbxNama.Location = new Point(428, 451);
            tbxNama.Name = "tbxNama";
            tbxNama.ReadOnly = true;
            tbxNama.Size = new Size(477, 20);
            tbxNama.TabIndex = 29;
            // 
            // tbxNIM
            // 
            tbxNIM.BackColor = Color.White;
            tbxNIM.BorderStyle = BorderStyle.None;
            tbxNIM.Enabled = false;
            tbxNIM.Location = new Point(428, 537);
            tbxNIM.Name = "tbxNIM";
            tbxNIM.ReadOnly = true;
            tbxNIM.Size = new Size(477, 20);
            tbxNIM.TabIndex = 30;
            // 
            // tbxLinkDok
            // 
            tbxLinkDok.BackColor = Color.White;
            tbxLinkDok.BorderStyle = BorderStyle.None;
            tbxLinkDok.Location = new Point(428, 617);
            tbxLinkDok.Name = "tbxLinkDok";
            tbxLinkDok.Size = new Size(477, 20);
            tbxLinkDok.TabIndex = 31;
            // 
            // rbtnReject
            // 
            rbtnReject.AutoSize = true;
            rbtnReject.BackColor = Color.White;
            rbtnReject.Location = new Point(1058, 717);
            rbtnReject.Name = "rbtnReject";
            rbtnReject.Size = new Size(17, 16);
            rbtnReject.TabIndex = 32;
            rbtnReject.UseVisualStyleBackColor = false;
            // 
            // rbtnAccept
            // 
            rbtnAccept.AutoSize = true;
            rbtnAccept.BackColor = Color.White;
            rbtnAccept.Location = new Point(1058, 678);
            rbtnAccept.Name = "rbtnAccept";
            rbtnAccept.Size = new Size(17, 16);
            rbtnAccept.TabIndex = 33;
            rbtnAccept.UseVisualStyleBackColor = false;
            // 
            // tbxJumlahSKS
            // 
            tbxJumlahSKS.BackColor = Color.White;
            tbxJumlahSKS.BorderStyle = BorderStyle.None;
            tbxJumlahSKS.Enabled = false;
            tbxJumlahSKS.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbxJumlahSKS.Location = new Point(760, 688);
            tbxJumlahSKS.Name = "tbxJumlahSKS";
            tbxJumlahSKS.ReadOnly = true;
            tbxJumlahSKS.Size = new Size(54, 45);
            tbxJumlahSKS.TabIndex = 34;
            tbxJumlahSKS.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblNamaAdmin);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(lblNIP);
            panel2.Location = new Point(2, 807);
            panel2.Name = "panel2";
            panel2.Size = new Size(241, 47);
            panel2.TabIndex = 38;
            // 
            // lblNamaAdmin
            // 
            lblNamaAdmin.AutoSize = true;
            lblNamaAdmin.BackColor = Color.Transparent;
            lblNamaAdmin.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNamaAdmin.Location = new Point(9, 0);
            lblNamaAdmin.Name = "lblNamaAdmin";
            lblNamaAdmin.Size = new Size(92, 26);
            lblNamaAdmin.TabIndex = 14;
            lblNamaAdmin.Text = "John Doe";
            // 
            // btnLogout
            // 
            btnLogout.CornerRoundingRadius = 6F;
            btnLogout.Location = new Point(202, 7);
            btnLogout.Name = "btnLogout";
            btnLogout.OverrideDefault.Back.Color1 = Color.White;
            btnLogout.OverrideDefault.Back.Color2 = Color.White;
            btnLogout.OverrideDefault.Border.Color1 = Color.White;
            btnLogout.OverrideDefault.Border.Color2 = Color.White;
            btnLogout.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogout.Size = new Size(32, 32);
            btnLogout.StateCommon.Back.Color1 = Color.White;
            btnLogout.StateCommon.Back.Color2 = Color.White;
            btnLogout.StateCommon.Back.Image = (Image)resources.GetObject("btnLogout.StateCommon.Back.Image");
            btnLogout.StateCommon.Border.Color1 = Color.White;
            btnLogout.StateCommon.Border.Color2 = Color.White;
            btnLogout.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogout.StateCommon.Border.Rounding = 6F;
            btnLogout.StateNormal.Back.Color1 = Color.White;
            btnLogout.StateNormal.Back.Color2 = Color.White;
            btnLogout.StatePressed.Back.Color1 = Color.WhiteSmoke;
            btnLogout.StatePressed.Back.Color2 = Color.WhiteSmoke;
            btnLogout.StatePressed.Border.Color1 = Color.WhiteSmoke;
            btnLogout.StatePressed.Border.Color2 = Color.WhiteSmoke;
            btnLogout.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogout.StateTracking.Back.Color1 = Color.WhiteSmoke;
            btnLogout.StateTracking.Back.Color2 = Color.WhiteSmoke;
            btnLogout.StateTracking.Border.Color1 = Color.WhiteSmoke;
            btnLogout.StateTracking.Border.Color2 = Color.WhiteSmoke;
            btnLogout.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogout.TabIndex = 16;
            btnLogout.Values.Text = "";
            // 
            // lblNIP
            // 
            lblNIP.AutoSize = true;
            lblNIP.BackColor = Color.Transparent;
            lblNIP.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNIP.Location = new Point(9, 21);
            lblNIP.Name = "lblNIP";
            lblNIP.Size = new Size(96, 26);
            lblNIP.TabIndex = 15;
            lblNIP.Text = "1234567890";
            // 
            // Form_ConvertionValidation_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(panel2);
            Controls.Add(tbxJumlahSKS);
            Controls.Add(rbtnAccept);
            Controls.Add(rbtnReject);
            Controls.Add(tbxLinkDok);
            Controls.Add(tbxNIM);
            Controls.Add(tbxNama);
            Controls.Add(tbxTahapan);
            Controls.Add(tbxNamaLomba);
            Controls.Add(tbxRegion);
            Controls.Add(btnBackConvertion);
            Controls.Add(btnAddConvertion);
            Controls.Add(tbxNilai);
            Controls.Add(dgvMatkulKonversi);
            Controls.Add(tbxBidang);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_ConvertionValidation_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Achievement Convertion Admin";
            ((System.ComponentModel.ISupportInitialize)dgvMatkulKonversi).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Krypton.Toolkit.KryptonDataGridView dgvMatkulKonversi;
        private TextBox tbxBidang;
        private TextBox tbxNilai;
        private Krypton.Toolkit.KryptonButton btnBackConvertion;
        private Krypton.Toolkit.KryptonButton btnAddConvertion;
        private TextBox tbxRegion;
        private TextBox tbxNamaLomba;
        private TextBox tbxTahapan;
        private TextBox tbxNama;
        private TextBox tbxNIM;
        private TextBox tbxLinkDok;
        private RadioButton rbtnReject;
        private RadioButton rbtnAccept;
        private TextBox tbxJumlahSKS;
        private Panel panel2;
        private Label lblNamaAdmin;
        private Krypton.Toolkit.KryptonButton btnLogout;
        private Label lblNIP;
    }
}