namespace fasilkom_prestasi
{
    partial class Matkul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matkul));
            panel1 = new Panel();
            panel4 = new Panel();
            lblNamaAdmin = new Label();
            btnLogout = new Krypton.Toolkit.KryptonButton();
            lblNIP = new Label();
            btnBack = new Krypton.Toolkit.KryptonButton();
            btnAddMatkul = new Krypton.Toolkit.KryptonButton();
            panel2 = new Panel();
            panel3 = new Panel();
            btnAchievements = new Button();
            btnOtherMenu = new Button();
            btnConvertion = new Button();
            dgvMatkul = new Krypton.Toolkit.KryptonDataGridView();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatkul).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnAddMatkul);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgvMatkul);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1582, 853);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblNamaAdmin);
            panel4.Controls.Add(btnLogout);
            panel4.Controls.Add(lblNIP);
            panel4.Location = new Point(2, 807);
            panel4.Name = "panel4";
            panel4.Size = new Size(241, 47);
            panel4.TabIndex = 54;
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
            // btnBack
            // 
            btnBack.CornerRoundingRadius = 10F;
            btnBack.Location = new Point(360, 170);
            btnBack.Margin = new Padding(2);
            btnBack.MaximumSize = new Size(36, 36);
            btnBack.MinimumSize = new Size(36, 36);
            btnBack.Name = "btnBack";
            btnBack.OverrideDefault.Back.Color1 = Color.WhiteSmoke;
            btnBack.OverrideDefault.Back.Color2 = Color.WhiteSmoke;
            btnBack.Size = new Size(36, 36);
            btnBack.StateCommon.Back.Color1 = Color.Transparent;
            btnBack.StateCommon.Back.Color2 = Color.Transparent;
            btnBack.StateCommon.Back.Image = (Image)resources.GetObject("btnBack.StateCommon.Back.Image");
            btnBack.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnBack.StateCommon.Border.Color1 = Color.White;
            btnBack.StateCommon.Border.Color2 = Color.White;
            btnBack.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBack.StateCommon.Border.Rounding = 10F;
            btnBack.StatePressed.Back.Color1 = Color.WhiteSmoke;
            btnBack.StatePressed.Back.Color2 = Color.WhiteSmoke;
            btnBack.TabIndex = 53;
            btnBack.Values.Text = "";
            btnBack.Click += btnBack_Click;
            // 
            // btnAddMatkul
            // 
            btnAddMatkul.CornerRoundingRadius = 10F;
            btnAddMatkul.Location = new Point(1221, 166);
            btnAddMatkul.Margin = new Padding(2);
            btnAddMatkul.MaximumSize = new Size(208, 56);
            btnAddMatkul.MinimumSize = new Size(208, 56);
            btnAddMatkul.Name = "btnAddMatkul";
            btnAddMatkul.OverrideDefault.Back.Color1 = Color.White;
            btnAddMatkul.OverrideDefault.Back.Color2 = Color.White;
            btnAddMatkul.OverrideDefault.Back.Image = (Image)resources.GetObject("btnAddMatkul.OverrideDefault.Back.Image");
            btnAddMatkul.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAddMatkul.OverrideDefault.Border.Color1 = Color.White;
            btnAddMatkul.OverrideDefault.Border.Color2 = Color.White;
            btnAddMatkul.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddMatkul.OverrideFocus.Back.Color1 = Color.WhiteSmoke;
            btnAddMatkul.OverrideFocus.Back.Color2 = Color.WhiteSmoke;
            btnAddMatkul.OverrideFocus.Back.Image = (Image)resources.GetObject("btnAddMatkul.OverrideFocus.Back.Image");
            btnAddMatkul.OverrideFocus.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAddMatkul.OverrideFocus.Border.Color1 = Color.WhiteSmoke;
            btnAddMatkul.OverrideFocus.Border.Color2 = Color.WhiteSmoke;
            btnAddMatkul.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddMatkul.Size = new Size(208, 56);
            btnAddMatkul.StateCommon.Back.Color1 = Color.White;
            btnAddMatkul.StateCommon.Back.Color2 = Color.White;
            btnAddMatkul.StateCommon.Back.Image = (Image)resources.GetObject("btnAddMatkul.StateCommon.Back.Image");
            btnAddMatkul.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAddMatkul.StateCommon.Border.Color1 = Color.White;
            btnAddMatkul.StateCommon.Border.Color2 = Color.White;
            btnAddMatkul.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddMatkul.StateCommon.Border.Rounding = 10F;
            btnAddMatkul.StateTracking.Back.Color1 = Color.WhiteSmoke;
            btnAddMatkul.StateTracking.Back.Color2 = Color.WhiteSmoke;
            btnAddMatkul.TabIndex = 52;
            btnAddMatkul.Values.Text = "";
            btnAddMatkul.Click += btnAddMatkul_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnAchievements);
            panel2.Controls.Add(btnOtherMenu);
            panel2.Controls.Add(btnConvertion);
            panel2.Location = new Point(0, 166);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 233);
            panel2.TabIndex = 51;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(189, 209, 255);
            panel3.Location = new Point(-2, 157);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 62);
            panel3.TabIndex = 44;
            // 
            // btnAchievements
            // 
            btnAchievements.BackColor = Color.White;
            btnAchievements.FlatAppearance.BorderSize = 0;
            btnAchievements.FlatStyle = FlatStyle.Flat;
            btnAchievements.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAchievements.Image = (Image)resources.GetObject("btnAchievements.Image");
            btnAchievements.ImageAlign = ContentAlignment.MiddleLeft;
            btnAchievements.Location = new Point(8, 1);
            btnAchievements.Margin = new Padding(2);
            btnAchievements.Name = "btnAchievements";
            btnAchievements.Size = new Size(232, 62);
            btnAchievements.TabIndex = 41;
            btnAchievements.Text = "Achievement\r\nValidation";
            btnAchievements.UseVisualStyleBackColor = false;
            btnAchievements.Click += btnAchievements_Click;
            // 
            // btnOtherMenu
            // 
            btnOtherMenu.BackColor = Color.White;
            btnOtherMenu.FlatAppearance.BorderSize = 0;
            btnOtherMenu.FlatStyle = FlatStyle.Flat;
            btnOtherMenu.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOtherMenu.Image = (Image)resources.GetObject("btnOtherMenu.Image");
            btnOtherMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnOtherMenu.Location = new Point(8, 157);
            btnOtherMenu.Margin = new Padding(2);
            btnOtherMenu.Name = "btnOtherMenu";
            btnOtherMenu.Size = new Size(232, 62);
            btnOtherMenu.TabIndex = 43;
            btnOtherMenu.Text = "Lainnya\r\n";
            btnOtherMenu.UseVisualStyleBackColor = false;
            // 
            // btnConvertion
            // 
            btnConvertion.BackColor = Color.White;
            btnConvertion.FlatAppearance.BorderSize = 0;
            btnConvertion.FlatStyle = FlatStyle.Flat;
            btnConvertion.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConvertion.Image = (Image)resources.GetObject("btnConvertion.Image");
            btnConvertion.ImageAlign = ContentAlignment.MiddleLeft;
            btnConvertion.Location = new Point(8, 91);
            btnConvertion.Margin = new Padding(2);
            btnConvertion.Name = "btnConvertion";
            btnConvertion.Size = new Size(232, 62);
            btnConvertion.TabIndex = 42;
            btnConvertion.Text = "Convertion\r\nValidation";
            btnConvertion.UseVisualStyleBackColor = false;
            btnConvertion.Click += btnConvertion_Click;
            // 
            // dgvMatkul
            // 
            dgvMatkul.AllowUserToAddRows = false;
            dgvMatkul.AllowUserToDeleteRows = false;
            dgvMatkul.AllowUserToResizeColumns = false;
            dgvMatkul.AllowUserToResizeRows = false;
            dgvMatkul.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatkul.BorderStyle = BorderStyle.None;
            dgvMatkul.ColumnHeadersHeight = 36;
            dgvMatkul.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMatkul.Location = new Point(337, 227);
            dgvMatkul.Name = "dgvMatkul";
            dgvMatkul.ReadOnly = true;
            dgvMatkul.RowHeadersVisible = false;
            dgvMatkul.RowHeadersWidth = 51;
            dgvMatkul.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMatkul.RowTemplate.Height = 45;
            dgvMatkul.Size = new Size(1170, 578);
            dgvMatkul.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvMatkul.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvMatkul.TabIndex = 2;
            dgvMatkul.CellContentClick += dgvMatkul_CellContentClick;
            // 
            // Matkul
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel1);
            Name = "Matkul";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Matkul";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMatkul).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Krypton.Toolkit.KryptonDataGridView dgvMatkul;
        private Panel panel2;
        private Panel panel3;
        private Button btnAchievements;
        private Button btnOtherMenu;
        private Button btnConvertion;
        private Krypton.Toolkit.KryptonButton btnAddMatkul;
        private Krypton.Toolkit.KryptonButton btnBack;
        private Panel panel4;
        private Label lblNamaAdmin;
        private Krypton.Toolkit.KryptonButton btnLogout;
        private Label lblNIP;
    }
}