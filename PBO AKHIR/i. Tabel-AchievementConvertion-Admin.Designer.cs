namespace fasilkom_prestasi
{
    partial class KonversiAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KonversiAdmin));
            dgvKonversi = new Krypton.Toolkit.KryptonDataGridView();
            btnAchievements = new Button();
            btnConvertion = new Button();
            panel1 = new Panel();
            btnOtherMenu = new Button();
            panel2 = new Panel();
            lblNamaAdmin = new Label();
            btnLogout = new Krypton.Toolkit.KryptonButton();
            lblNIP = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKonversi).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKonversi
            // 
            dgvKonversi.AllowUserToAddRows = false;
            dgvKonversi.AllowUserToDeleteRows = false;
            dgvKonversi.AllowUserToResizeColumns = false;
            dgvKonversi.AllowUserToResizeRows = false;
            dgvKonversi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKonversi.BorderStyle = BorderStyle.None;
            dgvKonversi.ColumnHeadersHeight = 36;
            dgvKonversi.Location = new Point(337, 227);
            dgvKonversi.Name = "dgvKonversi";
            dgvKonversi.ReadOnly = true;
            dgvKonversi.RowHeadersVisible = false;
            dgvKonversi.RowHeadersWidth = 51;
            dgvKonversi.RowTemplate.Height = 29;
            dgvKonversi.Size = new Size(1170, 502);
            dgvKonversi.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvKonversi.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvKonversi.TabIndex = 3;
            dgvKonversi.CellContentClick += dgvKonversi_CellContentClick;
            dgvKonversi.CellContentDoubleClick += dgvKonversi_CellContentDoubleClick;
            // 
            // btnAchievements
            // 
            btnAchievements.BackColor = Color.White;
            btnAchievements.FlatAppearance.BorderSize = 0;
            btnAchievements.FlatStyle = FlatStyle.Flat;
            btnAchievements.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAchievements.Image = (Image)resources.GetObject("btnAchievements.Image");
            btnAchievements.ImageAlign = ContentAlignment.MiddleLeft;
            btnAchievements.Location = new Point(10, 159);
            btnAchievements.Margin = new Padding(2);
            btnAchievements.Name = "btnAchievements";
            btnAchievements.Size = new Size(232, 62);
            btnAchievements.TabIndex = 32;
            btnAchievements.Text = "Achievement\r\nValidation";
            btnAchievements.UseVisualStyleBackColor = false;
            btnAchievements.Click += btnAchievements_Click;
            // 
            // btnConvertion
            // 
            btnConvertion.BackColor = Color.White;
            btnConvertion.FlatAppearance.BorderSize = 0;
            btnConvertion.FlatStyle = FlatStyle.Flat;
            btnConvertion.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConvertion.Image = (Image)resources.GetObject("btnConvertion.Image");
            btnConvertion.ImageAlign = ContentAlignment.MiddleLeft;
            btnConvertion.Location = new Point(10, 249);
            btnConvertion.Margin = new Padding(2);
            btnConvertion.Name = "btnConvertion";
            btnConvertion.Size = new Size(232, 62);
            btnConvertion.TabIndex = 33;
            btnConvertion.Text = "Convertion\r\nValidation";
            btnConvertion.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(189, 209, 255);
            panel1.Location = new Point(0, 249);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 62);
            panel1.TabIndex = 34;
            // 
            // btnOtherMenu
            // 
            btnOtherMenu.BackColor = Color.White;
            btnOtherMenu.FlatAppearance.BorderSize = 0;
            btnOtherMenu.FlatStyle = FlatStyle.Flat;
            btnOtherMenu.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOtherMenu.Image = (Image)resources.GetObject("btnOtherMenu.Image");
            btnOtherMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnOtherMenu.Location = new Point(10, 315);
            btnOtherMenu.Margin = new Padding(2);
            btnOtherMenu.Name = "btnOtherMenu";
            btnOtherMenu.Size = new Size(232, 62);
            btnOtherMenu.TabIndex = 35;
            btnOtherMenu.Text = "Lainnya\r\n";
            btnOtherMenu.UseVisualStyleBackColor = false;
            btnOtherMenu.Click += btnOtherMenu_Click;
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
            btnLogout.Click += btnLogout_Click;
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
            // KonversiAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(panel2);
            Controls.Add(btnOtherMenu);
            Controls.Add(panel1);
            Controls.Add(btnConvertion);
            Controls.Add(btnAchievements);
            Controls.Add(dgvKonversi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "KonversiAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tabel Achievement Convertion Admin";
            ((System.ComponentModel.ISupportInitialize)dgvKonversi).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvKonversi;
        private Button btnAchievements;
        private Button btnConvertion;
        private Panel panel1;
        private Button btnOtherMenu;
        private Panel panel2;
        private Label lblNamaAdmin;
        private Krypton.Toolkit.KryptonButton btnLogout;
        private Label lblNIP;
    }
}