namespace fasilkom_prestasi
{
    partial class Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Record));
            dgvPrestasi = new Krypton.Toolkit.KryptonDataGridView();
            btnAddAchievement = new Krypton.Toolkit.KryptonButton();
            sidePanel = new Panel();
            btnHome = new Button();
            btnRecord = new Button();
            panel2 = new Panel();
            btnConvertion = new Krypton.Toolkit.KryptonButton();
            btnArchive = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)dgvPrestasi).BeginInit();
            SuspendLayout();
            // 
            // dgvPrestasi
            // 
            dgvPrestasi.AllowUserToAddRows = false;
            dgvPrestasi.AllowUserToDeleteRows = false;
            dgvPrestasi.AllowUserToResizeColumns = false;
            dgvPrestasi.AllowUserToResizeRows = false;
            dgvPrestasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestasi.BorderStyle = BorderStyle.None;
            dgvPrestasi.ColumnHeadersHeight = 36;
            dgvPrestasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPrestasi.Location = new Point(338, 227);
            dgvPrestasi.Name = "dgvPrestasi";
            dgvPrestasi.RowHeadersVisible = false;
            dgvPrestasi.RowHeadersWidth = 51;
            dgvPrestasi.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrestasi.RowTemplate.Height = 45;
            dgvPrestasi.Size = new Size(1170, 578);
            dgvPrestasi.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvPrestasi.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvPrestasi.TabIndex = 0;
            dgvPrestasi.CellContentClick += dgvPrestasi_CellContentClick;
            // 
            // btnAddAchievement
            // 
            btnAddAchievement.Location = new Point(1183, 166);
            btnAddAchievement.Margin = new Padding(2);
            btnAddAchievement.MaximumSize = new Size(208, 56);
            btnAddAchievement.MinimumSize = new Size(208, 56);
            btnAddAchievement.Name = "btnAddAchievement";
            btnAddAchievement.OverrideDefault.Back.Color1 = Color.White;
            btnAddAchievement.OverrideDefault.Back.Color2 = Color.White;
            btnAddAchievement.OverrideDefault.Back.Image = (Image)resources.GetObject("btnAddAchievement.OverrideDefault.Back.Image");
            btnAddAchievement.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAddAchievement.OverrideDefault.Border.Color1 = Color.White;
            btnAddAchievement.OverrideDefault.Border.Color2 = Color.White;
            btnAddAchievement.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddAchievement.OverrideFocus.Back.Color1 = Color.WhiteSmoke;
            btnAddAchievement.OverrideFocus.Back.Color2 = Color.WhiteSmoke;
            btnAddAchievement.OverrideFocus.Back.Image = (Image)resources.GetObject("btnAddAchievement.OverrideFocus.Back.Image");
            btnAddAchievement.OverrideFocus.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAddAchievement.OverrideFocus.Border.Color1 = Color.WhiteSmoke;
            btnAddAchievement.OverrideFocus.Border.Color2 = Color.WhiteSmoke;
            btnAddAchievement.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddAchievement.Size = new Size(208, 56);
            btnAddAchievement.StateCommon.Back.Color1 = Color.White;
            btnAddAchievement.StateCommon.Back.Color2 = Color.White;
            btnAddAchievement.StateCommon.Back.Image = (Image)resources.GetObject("btnAddAchievement.StateCommon.Back.Image");
            btnAddAchievement.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAddAchievement.StateCommon.Border.Color1 = Color.White;
            btnAddAchievement.StateCommon.Border.Color2 = Color.White;
            btnAddAchievement.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddAchievement.StateTracking.Back.Color1 = Color.WhiteSmoke;
            btnAddAchievement.StateTracking.Back.Color2 = Color.WhiteSmoke;
            btnAddAchievement.StateTracking.Back.Image = (Image)resources.GetObject("btnAddAchievement.StateTracking.Back.Image");
            btnAddAchievement.TabIndex = 6;
            btnAddAchievement.Values.Text = "";
            btnAddAchievement.Click += btnAddAchievement_Click;
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
            sidePanel.TabIndex = 9;
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
            btnHome.TabIndex = 8;
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
            btnRecord.TabIndex = 10;
            btnRecord.Text = "Record";
            btnRecord.UseVisualStyleBackColor = false;
            btnRecord.Click += btnRecord_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(95, 120, 178);
            panel2.Location = new Point(363, 135);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(61, 4);
            panel2.TabIndex = 13;
            // 
            // btnConvertion
            // 
            btnConvertion.CornerRoundingRadius = 10F;
            btnConvertion.Location = new Point(458, 107);
            btnConvertion.Margin = new Padding(2);
            btnConvertion.Name = "btnConvertion";
            btnConvertion.OverrideDefault.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnConvertion.OverrideDefault.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnConvertion.OverrideDefault.Border.Color1 = Color.FromArgb(189, 209, 255);
            btnConvertion.OverrideDefault.Border.Color2 = Color.FromArgb(189, 209, 255);
            btnConvertion.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConvertion.OverrideFocus.Border.Color1 = Color.FromArgb(184, 206, 255);
            btnConvertion.OverrideFocus.Border.Color2 = Color.FromArgb(184, 206, 255);
            btnConvertion.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConvertion.Size = new Size(139, 32);
            btnConvertion.StateCommon.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnConvertion.StateCommon.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnConvertion.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConvertion.StateCommon.Border.Rounding = 10F;
            btnConvertion.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnConvertion.StateNormal.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnConvertion.StateNormal.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnConvertion.StateNormal.Border.Color1 = Color.FromArgb(189, 209, 255);
            btnConvertion.StateNormal.Border.Color2 = Color.FromArgb(189, 209, 255);
            btnConvertion.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConvertion.StatePressed.Back.Color1 = Color.FromArgb(184, 206, 255);
            btnConvertion.StatePressed.Back.Color2 = Color.FromArgb(184, 206, 255);
            btnConvertion.StatePressed.Border.Color1 = Color.FromArgb(184, 206, 255);
            btnConvertion.StatePressed.Border.Color2 = Color.FromArgb(184, 206, 255);
            btnConvertion.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConvertion.TabIndex = 12;
            btnConvertion.Values.Text = "Convertion";
            btnConvertion.Click += btnConvertion_Click;
            // 
            // btnArchive
            // 
            btnArchive.CornerRoundingRadius = 10F;
            btnArchive.Location = new Point(338, 107);
            btnArchive.Margin = new Padding(2);
            btnArchive.Name = "btnArchive";
            btnArchive.OverrideDefault.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnArchive.OverrideDefault.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnArchive.OverrideDefault.Border.Color1 = Color.FromArgb(189, 209, 255);
            btnArchive.OverrideDefault.Border.Color2 = Color.FromArgb(189, 209, 255);
            btnArchive.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnArchive.OverrideFocus.Border.Color1 = Color.FromArgb(184, 206, 255);
            btnArchive.OverrideFocus.Border.Color2 = Color.FromArgb(184, 206, 255);
            btnArchive.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnArchive.Size = new Size(113, 32);
            btnArchive.StateCommon.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnArchive.StateCommon.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnArchive.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnArchive.StateCommon.Border.Rounding = 10F;
            btnArchive.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnArchive.StateNormal.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnArchive.StateNormal.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnArchive.StateNormal.Border.Color1 = Color.FromArgb(189, 209, 255);
            btnArchive.StateNormal.Border.Color2 = Color.FromArgb(189, 209, 255);
            btnArchive.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnArchive.StatePressed.Back.Color1 = Color.FromArgb(184, 206, 255);
            btnArchive.StatePressed.Back.Color2 = Color.FromArgb(184, 206, 255);
            btnArchive.StatePressed.Border.Color1 = Color.FromArgb(184, 206, 255);
            btnArchive.StatePressed.Border.Color2 = Color.FromArgb(184, 206, 255);
            btnArchive.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnArchive.TabIndex = 11;
            btnArchive.Values.Text = "Archive";
            // 
            // Record
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(panel2);
            Controls.Add(btnConvertion);
            Controls.Add(btnArchive);
            Controls.Add(sidePanel);
            Controls.Add(btnHome);
            Controls.Add(btnRecord);
            Controls.Add(btnAddAchievement);
            Controls.Add(dgvPrestasi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Record";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tabel Archive Mahasiswa";
            Load += Record_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrestasi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvPrestasi;
        private Krypton.Toolkit.KryptonButton btnConvertion;
        private Krypton.Toolkit.KryptonButton btnAddAchievement;
        private Panel sidePanel;
        private Button btnHome;
        private Button btnRecord;
        private Panel panel2;
        private Krypton.Toolkit.KryptonButton btnArchive;
    }
}