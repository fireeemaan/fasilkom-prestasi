namespace fasilkom_prestasi
{
    partial class HomeGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeGuide));
            sidePanel = new Panel();
            btnHome = new Button();
            btnRecord = new Button();
            panel1 = new Panel();
            lblNamaMhs = new Label();
            btnLogout = new Krypton.Toolkit.KryptonButton();
            lblNIM = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(189, 209, 255);
            sidePanel.ForeColor = Color.White;
            sidePanel.Location = new Point(2, 122);
            sidePanel.Margin = new Padding(2);
            sidePanel.MaximumSize = new Size(8, 48);
            sidePanel.MinimumSize = new Size(8, 48);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(8, 48);
            sidePanel.TabIndex = 27;
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
            btnHome.TabIndex = 26;
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
            btnRecord.Location = new Point(11, 175);
            btnRecord.Margin = new Padding(2);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(232, 48);
            btnRecord.TabIndex = 28;
            btnRecord.Text = "Record";
            btnRecord.UseVisualStyleBackColor = false;
            btnRecord.Click += btnRecord_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblNamaMhs);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblNIM);
            panel1.Location = new Point(2, 807);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 47);
            panel1.TabIndex = 29;
            // 
            // lblNamaMhs
            // 
            lblNamaMhs.AutoSize = true;
            lblNamaMhs.BackColor = Color.Transparent;
            lblNamaMhs.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNamaMhs.Location = new Point(9, 0);
            lblNamaMhs.Name = "lblNamaMhs";
            lblNamaMhs.Size = new Size(92, 26);
            lblNamaMhs.TabIndex = 14;
            lblNamaMhs.Text = "John Doe";
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
            btnLogout.Click += btnLogout_Click;
            // 
            // lblNIM
            // 
            lblNIM.AutoSize = true;
            lblNIM.BackColor = Color.Transparent;
            lblNIM.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNIM.Location = new Point(9, 21);
            lblNIM.Name = "lblNIM";
            lblNIM.Size = new Size(96, 26);
            lblNIM.TabIndex = 15;
            lblNIM.Text = "1234567890";
            // 
            // HomeGuide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(panel1);
            Controls.Add(sidePanel);
            Controls.Add(btnHome);
            Controls.Add(btnRecord);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "HomeGuide";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Guide";
            FormClosing += HomeGuide_FormClosing;
            Load += HomeGuide_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Button btnHome;
        private Button btnRecord;
        private Panel panel1;
        private Label lblNamaMhs;
        private Krypton.Toolkit.KryptonButton btnLogout;
        private Label lblNIM;
    }
}