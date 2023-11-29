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
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            btnRecord = new Button();
            btnHome = new Button();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            archiveControl1 = new ArchiveControl();
            btnClose = new Krypton.Toolkit.KryptonButton();
            sidePanel = new Panel();
            addAchievementControl1 = new AddAchievementControl();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(btnRecord);
            kryptonPanel1.Controls.Add(btnHome);
            kryptonPanel1.Controls.Add(kryptonPanel2);
            kryptonPanel1.Location = new Point(1, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(245, 900);
            kryptonPanel1.StateCommon.Color1 = Color.White;
            kryptonPanel1.StateCommon.Color2 = Color.White;
            kryptonPanel1.TabIndex = 0;
            // 
            // btnRecord
            // 
            btnRecord.BackColor = Color.White;
            btnRecord.FlatAppearance.BorderSize = 0;
            btnRecord.FlatStyle = FlatStyle.Flat;
            btnRecord.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRecord.Image = (Image)resources.GetObject("btnRecord.Image");
            btnRecord.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecord.Location = new Point(11, 178);
            btnRecord.MaximumSize = new Size(234, 58);
            btnRecord.MinimumSize = new Size(234, 58);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(234, 58);
            btnRecord.TabIndex = 2;
            btnRecord.Text = "Record";
            btnRecord.UseVisualStyleBackColor = false;
            btnRecord.Click += btnRecord_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.White;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(11, 114);
            btnHome.MaximumSize = new Size(234, 58);
            btnHome.MinimumSize = new Size(234, 58);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(234, 58);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Location = new Point(0, 12);
            kryptonPanel2.MaximumSize = new Size(245, 60);
            kryptonPanel2.MinimumSize = new Size(245, 60);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(245, 60);
            kryptonPanel2.StateCommon.Color1 = Color.White;
            kryptonPanel2.StateCommon.Image = (Image)resources.GetObject("kryptonPanel2.StateCommon.Image");
            kryptonPanel2.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            kryptonPanel2.TabIndex = 0;
            // 
            // archiveControl1
            // 
            archiveControl1.Location = new Point(343, 152);
            archiveControl1.MaximumSize = new Size(1170, 672);
            archiveControl1.MinimumSize = new Size(1170, 672);
            archiveControl1.Name = "archiveControl1";
            archiveControl1.Record = null;
            archiveControl1.Size = new Size(1170, 672);
            archiveControl1.TabIndex = 1;
            archiveControl1.Load += archiveControl1_Load;
            // 
            // btnClose
            // 
            btnClose.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorStack;
            btnClose.Location = new Point(1530, 0);
            btnClose.MaximumSize = new Size(70, 70);
            btnClose.MinimumSize = new Size(70, 70);
            btnClose.Name = "btnClose";
            btnClose.OverrideDefault.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnClose.OverrideDefault.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnClose.OverrideFocus.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnClose.OverrideFocus.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnClose.Size = new Size(70, 70);
            btnClose.StateCommon.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnClose.StateCommon.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnClose.StateCommon.Back.Image = (Image)resources.GetObject("btnClose.StateCommon.Back.Image");
            btnClose.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnClose.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            btnClose.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            btnClose.StateTracking.Back.Color1 = Color.FromArgb(184, 206, 255);
            btnClose.StateTracking.Back.Color2 = Color.FromArgb(184, 206, 255);
            btnClose.StateTracking.Back.Image = (Image)resources.GetObject("btnClose.StateTracking.Back.Image");
            btnClose.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnClose.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.False;
            btnClose.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            btnClose.TabIndex = 2;
            btnClose.Values.Text = "";
            btnClose.Click += btnClose_Click;
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
            // addAchievementControl1
            // 
            addAchievementControl1.BackgroundImage = (Image)resources.GetObject("addAchievementControl1.BackgroundImage");
            addAchievementControl1.Location = new Point(343, 152);
            addAchievementControl1.Name = "addAchievementControl1";
            addAchievementControl1.Record = null;
            addAchievementControl1.Size = new Size(1170, 672);
            addAchievementControl1.TabIndex = 3;
            // 
            // Record
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(189, 209, 255);
            ClientSize = new Size(1600, 900);
            Controls.Add(sidePanel);
            Controls.Add(btnClose);
            Controls.Add(kryptonPanel1);
            Controls.Add(archiveControl1);
            Controls.Add(addAchievementControl1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1600, 900);
            MinimumSize = new Size(1600, 900);
            Name = "Record";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Archive";
            Load += Record_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ArchiveControl archiveControl1;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Button btnHome;
        private Panel sidePanel;
        private Button btnRecord;
        private AddAchievementControl addAchievementControl1;
    }
}