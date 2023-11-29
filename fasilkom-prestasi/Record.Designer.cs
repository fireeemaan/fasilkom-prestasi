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
            sidePanel = new Panel();
            btnHome = new Button();
            btnRecord = new Button();
            panel1 = new Panel();
            dgvPrestasi = new Krypton.Toolkit.KryptonDataGridView();
            panel2 = new Panel();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            label1 = new Label();
            btnConvertion = new Krypton.Toolkit.KryptonButton();
            btnAddAchievement = new Krypton.Toolkit.KryptonButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestasi).BeginInit();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.ForeColor = Color.White;
            sidePanel.Location = new Point(1, 178);
            sidePanel.MaximumSize = new Size(10, 58);
            sidePanel.MinimumSize = new Size(10, 58);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(10, 58);
            sidePanel.TabIndex = 2;
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
            btnHome.TabIndex = 1;
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
            btnRecord.Location = new Point(12, 178);
            btnRecord.MaximumSize = new Size(234, 58);
            btnRecord.MinimumSize = new Size(234, 58);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(234, 58);
            btnRecord.TabIndex = 2;
            btnRecord.Text = "Record";
            btnRecord.UseVisualStyleBackColor = false;
            btnRecord.Click += btnRecord_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(dgvPrestasi);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(kryptonButton2);
            panel1.Controls.Add(kryptonButton1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnConvertion);
            panel1.Controls.Add(btnAddAchievement);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnRecord);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1578, 844);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // dgvPrestasi
            // 
            dgvPrestasi.AllowUserToAddRows = false;
            dgvPrestasi.AllowUserToDeleteRows = false;
            dgvPrestasi.AllowUserToResizeColumns = false;
            dgvPrestasi.AllowUserToResizeRows = false;
            dgvPrestasi.BorderStyle = BorderStyle.None;
            dgvPrestasi.ColumnHeadersHeight = 51;
            dgvPrestasi.Location = new Point(337, 216);
            dgvPrestasi.Name = "dgvPrestasi";
            dgvPrestasi.ReadOnly = true;
            dgvPrestasi.RowHeadersVisible = false;
            dgvPrestasi.RowHeadersWidth = 10;
            dgvPrestasi.RowTemplate.Height = 50;
            dgvPrestasi.Size = new Size(1170, 566);
            dgvPrestasi.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvPrestasi.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom;
            dgvPrestasi.TabIndex = 10;
            dgvPrestasi.CellContentClick += dgvPrestasi_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(95, 120, 178);
            panel2.Location = new Point(372, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(73, 5);
            panel2.TabIndex = 9;
            // 
            // kryptonButton2
            // 
            kryptonButton2.CornerRoundingRadius = 10F;
            kryptonButton2.Location = new Point(500, 93);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.OverrideDefault.Back.Color1 = Color.FromArgb(189, 209, 255);
            kryptonButton2.OverrideDefault.Back.Color2 = Color.FromArgb(189, 209, 255);
            kryptonButton2.OverrideDefault.Border.Color1 = Color.FromArgb(189, 209, 255);
            kryptonButton2.OverrideDefault.Border.Color2 = Color.FromArgb(189, 209, 255);
            kryptonButton2.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton2.OverrideFocus.Border.Color1 = Color.FromArgb(184, 206, 255);
            kryptonButton2.OverrideFocus.Border.Color2 = Color.FromArgb(184, 206, 255);
            kryptonButton2.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton2.Size = new Size(140, 38);
            kryptonButton2.StateCommon.Back.Color1 = Color.FromArgb(189, 209, 255);
            kryptonButton2.StateCommon.Back.Color2 = Color.FromArgb(189, 209, 255);
            kryptonButton2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton2.StateCommon.Border.Rounding = 10F;
            kryptonButton2.StateCommon.Content.ShortText.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButton2.StateNormal.Back.Color1 = Color.FromArgb(189, 209, 255);
            kryptonButton2.StateNormal.Back.Color2 = Color.FromArgb(189, 209, 255);
            kryptonButton2.StateNormal.Border.Color1 = Color.FromArgb(189, 209, 255);
            kryptonButton2.StateNormal.Border.Color2 = Color.FromArgb(189, 209, 255);
            kryptonButton2.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton2.StatePressed.Back.Color1 = Color.FromArgb(184, 206, 255);
            kryptonButton2.StatePressed.Back.Color2 = Color.FromArgb(184, 206, 255);
            kryptonButton2.StatePressed.Border.Color1 = Color.FromArgb(184, 206, 255);
            kryptonButton2.StatePressed.Border.Color2 = Color.FromArgb(184, 206, 255);
            kryptonButton2.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton2.TabIndex = 8;
            kryptonButton2.Values.Text = "Convertion";
            // 
            // kryptonButton1
            // 
            kryptonButton1.CornerRoundingRadius = 10F;
            kryptonButton1.Location = new Point(356, 93);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(189, 209, 255);
            kryptonButton1.OverrideDefault.Back.Color2 = Color.FromArgb(189, 209, 255);
            kryptonButton1.OverrideDefault.Border.Color1 = Color.FromArgb(189, 209, 255);
            kryptonButton1.OverrideDefault.Border.Color2 = Color.FromArgb(189, 209, 255);
            kryptonButton1.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.OverrideFocus.Border.Color1 = Color.FromArgb(184, 206, 255);
            kryptonButton1.OverrideFocus.Border.Color2 = Color.FromArgb(184, 206, 255);
            kryptonButton1.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.Size = new Size(109, 38);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(189, 209, 255);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(189, 209, 255);
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.Rounding = 10F;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButton1.StateNormal.Back.Color1 = Color.FromArgb(189, 209, 255);
            kryptonButton1.StateNormal.Back.Color2 = Color.FromArgb(189, 209, 255);
            kryptonButton1.StateNormal.Border.Color1 = Color.FromArgb(189, 209, 255);
            kryptonButton1.StateNormal.Border.Color2 = Color.FromArgb(189, 209, 255);
            kryptonButton1.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(184, 206, 255);
            kryptonButton1.StatePressed.Back.Color2 = Color.FromArgb(184, 206, 255);
            kryptonButton1.StatePressed.Border.Color1 = Color.FromArgb(184, 206, 255);
            kryptonButton1.StatePressed.Border.Color2 = Color.FromArgb(184, 206, 255);
            kryptonButton1.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.TabIndex = 7;
            kryptonButton1.Values.Text = "Archive";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(337, 30);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(128, 50);
            label1.TabIndex = 6;
            label1.Text = "Record";
            // 
            // btnConvertion
            // 
            btnConvertion.Location = new Point(1203, 143);
            btnConvertion.MaximumSize = new Size(249, 67);
            btnConvertion.MinimumSize = new Size(249, 67);
            btnConvertion.Name = "btnConvertion";
            btnConvertion.OverrideDefault.Back.Color1 = Color.White;
            btnConvertion.OverrideDefault.Back.Color2 = Color.White;
            btnConvertion.OverrideDefault.Back.Image = (Image)resources.GetObject("btnConvertion.OverrideDefault.Back.Image");
            btnConvertion.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnConvertion.OverrideDefault.Border.Color1 = Color.White;
            btnConvertion.OverrideDefault.Border.Color2 = Color.White;
            btnConvertion.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConvertion.OverrideFocus.Back.Color1 = Color.WhiteSmoke;
            btnConvertion.OverrideFocus.Back.Color2 = Color.WhiteSmoke;
            btnConvertion.OverrideFocus.Back.Image = (Image)resources.GetObject("btnConvertion.OverrideFocus.Back.Image");
            btnConvertion.OverrideFocus.Border.Color1 = Color.WhiteSmoke;
            btnConvertion.OverrideFocus.Border.Color2 = Color.WhiteSmoke;
            btnConvertion.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConvertion.Size = new Size(249, 67);
            btnConvertion.StateCommon.Back.Color1 = Color.White;
            btnConvertion.StateCommon.Back.Color2 = Color.White;
            btnConvertion.StateCommon.Back.Image = (Image)resources.GetObject("btnConvertion.StateCommon.Back.Image");
            btnConvertion.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnConvertion.StateCommon.Border.Color1 = Color.White;
            btnConvertion.StateCommon.Border.Color2 = Color.White;
            btnConvertion.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConvertion.StateTracking.Back.Color1 = Color.WhiteSmoke;
            btnConvertion.StateTracking.Back.Color2 = Color.WhiteSmoke;
            btnConvertion.StateTracking.Back.Image = (Image)resources.GetObject("btnConvertion.StateTracking.Back.Image");
            btnConvertion.TabIndex = 5;
            btnConvertion.Values.Text = "";
            // 
            // btnAddAchievement
            // 
            btnAddAchievement.Location = new Point(948, 143);
            btnAddAchievement.MaximumSize = new Size(249, 67);
            btnAddAchievement.MinimumSize = new Size(249, 67);
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
            btnAddAchievement.Size = new Size(249, 67);
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
            btnAddAchievement.TabIndex = 4;
            btnAddAchievement.Values.Text = "";
            btnAddAchievement.Click += btnAddAchievement_Click;
            // 
            // Record
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(189, 209, 255);
            ClientSize = new Size(1578, 844);
            Controls.Add(sidePanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(1600, 900);
            MinimumSize = new Size(1600, 900);
            Name = "Record";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Archive";
            Load += Record_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestasi).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel sidePanel;
        private Button btnHome;
        private Button btnRecord;
        private Panel panel1;
        private Krypton.Toolkit.KryptonButton btnConvertion;
        private Krypton.Toolkit.KryptonButton btnAddAchievement;
        private Label label1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Panel panel2;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonDataGridView dgvPrestasi;
    }
}