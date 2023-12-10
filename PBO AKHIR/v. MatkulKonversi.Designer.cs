namespace fasilkom_prestasi
{
    partial class MatkulKonversi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatkulKonversi));
            dgvFormMatkulKonversi = new Krypton.Toolkit.KryptonDataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            btnAchievements = new Button();
            btnOtherMenu = new Button();
            btnConvertion = new Button();
            btnAddMatkulKonversi = new Krypton.Toolkit.KryptonButton();
            btnSistemInformasi = new Krypton.Toolkit.KryptonButton();
            btnTeknologiInformasi = new Krypton.Toolkit.KryptonButton();
            btnAll = new Krypton.Toolkit.KryptonButton();
            btnInformatika = new Krypton.Toolkit.KryptonButton();
            btnBack = new Krypton.Toolkit.KryptonButton();
            panel4 = new Panel();
            lblNamaAdmin = new Label();
            btnLogout = new Krypton.Toolkit.KryptonButton();
            lblNIP = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFormMatkulKonversi).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dgvFormMatkulKonversi
            // 
            dgvFormMatkulKonversi.AllowUserToAddRows = false;
            dgvFormMatkulKonversi.AllowUserToDeleteRows = false;
            dgvFormMatkulKonversi.AllowUserToResizeColumns = false;
            dgvFormMatkulKonversi.AllowUserToResizeRows = false;
            dgvFormMatkulKonversi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFormMatkulKonversi.BorderStyle = BorderStyle.None;
            dgvFormMatkulKonversi.ColumnHeadersHeight = 36;
            dgvFormMatkulKonversi.Location = new Point(337, 227);
            dgvFormMatkulKonversi.Name = "dgvFormMatkulKonversi";
            dgvFormMatkulKonversi.ReadOnly = true;
            dgvFormMatkulKonversi.RowHeadersVisible = false;
            dgvFormMatkulKonversi.RowHeadersWidth = 51;
            dgvFormMatkulKonversi.RowTemplate.Height = 29;
            dgvFormMatkulKonversi.Size = new Size(1170, 502);
            dgvFormMatkulKonversi.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvFormMatkulKonversi.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvFormMatkulKonversi.TabIndex = 6;
            dgvFormMatkulKonversi.CellContentClick += dgvFormMatkulKonversi_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnAchievements);
            panel1.Controls.Add(btnOtherMenu);
            panel1.Controls.Add(btnConvertion);
            panel1.Location = new Point(0, 166);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 233);
            panel1.TabIndex = 47;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(189, 209, 255);
            panel2.Location = new Point(-2, 157);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 62);
            panel2.TabIndex = 44;
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
            // btnAddMatkulKonversi
            // 
            btnAddMatkulKonversi.Location = new Point(1184, 166);
            btnAddMatkulKonversi.Margin = new Padding(2);
            btnAddMatkulKonversi.MinimumSize = new Size(208, 56);
            btnAddMatkulKonversi.Name = "btnAddMatkulKonversi";
            btnAddMatkulKonversi.OverrideDefault.Back.Color1 = Color.White;
            btnAddMatkulKonversi.OverrideDefault.Back.Color2 = Color.White;
            btnAddMatkulKonversi.OverrideDefault.Back.Image = (Image)resources.GetObject("btnAddMatkulKonversi.OverrideDefault.Back.Image");
            btnAddMatkulKonversi.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAddMatkulKonversi.OverrideDefault.Border.Color1 = Color.White;
            btnAddMatkulKonversi.OverrideDefault.Border.Color2 = Color.White;
            btnAddMatkulKonversi.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddMatkulKonversi.OverrideFocus.Back.Color1 = Color.WhiteSmoke;
            btnAddMatkulKonversi.OverrideFocus.Back.Color2 = Color.WhiteSmoke;
            btnAddMatkulKonversi.OverrideFocus.Back.Image = (Image)resources.GetObject("btnAddMatkulKonversi.OverrideFocus.Back.Image");
            btnAddMatkulKonversi.OverrideFocus.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAddMatkulKonversi.OverrideFocus.Border.Color1 = Color.WhiteSmoke;
            btnAddMatkulKonversi.OverrideFocus.Border.Color2 = Color.WhiteSmoke;
            btnAddMatkulKonversi.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddMatkulKonversi.Size = new Size(257, 56);
            btnAddMatkulKonversi.StateCommon.Back.Color1 = Color.White;
            btnAddMatkulKonversi.StateCommon.Back.Color2 = Color.White;
            btnAddMatkulKonversi.StateCommon.Back.Image = (Image)resources.GetObject("btnAddMatkulKonversi.StateCommon.Back.Image");
            btnAddMatkulKonversi.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAddMatkulKonversi.StateCommon.Border.Color1 = Color.White;
            btnAddMatkulKonversi.StateCommon.Border.Color2 = Color.White;
            btnAddMatkulKonversi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddMatkulKonversi.StateTracking.Back.Color1 = Color.WhiteSmoke;
            btnAddMatkulKonversi.StateTracking.Back.Color2 = Color.WhiteSmoke;
            btnAddMatkulKonversi.StateTracking.Back.Image = (Image)resources.GetObject("btnAddMatkulKonversi.StateTracking.Back.Image");
            btnAddMatkulKonversi.TabIndex = 45;
            btnAddMatkulKonversi.Values.Text = "";
            btnAddMatkulKonversi.Click += btnAddMatkulKonversi_Click;
            // 
            // btnSistemInformasi
            // 
            btnSistemInformasi.CornerRoundingRadius = 10F;
            btnSistemInformasi.Location = new Point(583, 176);
            btnSistemInformasi.Margin = new Padding(2);
            btnSistemInformasi.Name = "btnSistemInformasi";
            btnSistemInformasi.OverrideDefault.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnSistemInformasi.OverrideDefault.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnSistemInformasi.OverrideDefault.Border.Color1 = Color.FromArgb(189, 209, 255);
            btnSistemInformasi.OverrideDefault.Border.Color2 = Color.FromArgb(189, 209, 255);
            btnSistemInformasi.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSistemInformasi.OverrideFocus.Border.Color1 = Color.FromArgb(184, 206, 255);
            btnSistemInformasi.OverrideFocus.Border.Color2 = Color.FromArgb(184, 206, 255);
            btnSistemInformasi.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSistemInformasi.Size = new Size(113, 32);
            btnSistemInformasi.StateCommon.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnSistemInformasi.StateCommon.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnSistemInformasi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSistemInformasi.StateCommon.Border.Rounding = 10F;
            btnSistemInformasi.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSistemInformasi.StateNormal.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnSistemInformasi.StateNormal.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnSistemInformasi.StateNormal.Border.Color1 = Color.FromArgb(189, 209, 255);
            btnSistemInformasi.StateNormal.Border.Color2 = Color.FromArgb(189, 209, 255);
            btnSistemInformasi.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSistemInformasi.StatePressed.Back.Color1 = Color.FromArgb(184, 206, 255);
            btnSistemInformasi.StatePressed.Back.Color2 = Color.FromArgb(184, 206, 255);
            btnSistemInformasi.StatePressed.Border.Color1 = Color.FromArgb(184, 206, 255);
            btnSistemInformasi.StatePressed.Border.Color2 = Color.FromArgb(184, 206, 255);
            btnSistemInformasi.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSistemInformasi.TabIndex = 48;
            btnSistemInformasi.Values.Text = "SI";
            btnSistemInformasi.Click += btnSistemInformasi_Click;
            // 
            // btnTeknologiInformasi
            // 
            btnTeknologiInformasi.CornerRoundingRadius = 10F;
            btnTeknologiInformasi.Location = new Point(711, 176);
            btnTeknologiInformasi.Margin = new Padding(2);
            btnTeknologiInformasi.Name = "btnTeknologiInformasi";
            btnTeknologiInformasi.OverrideDefault.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnTeknologiInformasi.OverrideDefault.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnTeknologiInformasi.OverrideDefault.Border.Color1 = Color.FromArgb(189, 209, 255);
            btnTeknologiInformasi.OverrideDefault.Border.Color2 = Color.FromArgb(189, 209, 255);
            btnTeknologiInformasi.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTeknologiInformasi.OverrideFocus.Border.Color1 = Color.FromArgb(184, 206, 255);
            btnTeknologiInformasi.OverrideFocus.Border.Color2 = Color.FromArgb(184, 206, 255);
            btnTeknologiInformasi.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTeknologiInformasi.Size = new Size(113, 32);
            btnTeknologiInformasi.StateCommon.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnTeknologiInformasi.StateCommon.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnTeknologiInformasi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTeknologiInformasi.StateCommon.Border.Rounding = 10F;
            btnTeknologiInformasi.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnTeknologiInformasi.StateNormal.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnTeknologiInformasi.StateNormal.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnTeknologiInformasi.StateNormal.Border.Color1 = Color.FromArgb(189, 209, 255);
            btnTeknologiInformasi.StateNormal.Border.Color2 = Color.FromArgb(189, 209, 255);
            btnTeknologiInformasi.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTeknologiInformasi.StatePressed.Back.Color1 = Color.FromArgb(184, 206, 255);
            btnTeknologiInformasi.StatePressed.Back.Color2 = Color.FromArgb(184, 206, 255);
            btnTeknologiInformasi.StatePressed.Border.Color1 = Color.FromArgb(184, 206, 255);
            btnTeknologiInformasi.StatePressed.Border.Color2 = Color.FromArgb(184, 206, 255);
            btnTeknologiInformasi.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnTeknologiInformasi.TabIndex = 49;
            btnTeknologiInformasi.Values.Text = "TI";
            btnTeknologiInformasi.Click += btnTeknologiInformasi_Click;
            // 
            // btnAll
            // 
            btnAll.CornerRoundingRadius = 10F;
            btnAll.Location = new Point(456, 176);
            btnAll.Margin = new Padding(2);
            btnAll.Name = "btnAll";
            btnAll.OverrideDefault.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnAll.OverrideDefault.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnAll.OverrideDefault.Border.Color1 = Color.FromArgb(189, 209, 255);
            btnAll.OverrideDefault.Border.Color2 = Color.FromArgb(189, 209, 255);
            btnAll.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAll.OverrideFocus.Border.Color1 = Color.FromArgb(184, 206, 255);
            btnAll.OverrideFocus.Border.Color2 = Color.FromArgb(184, 206, 255);
            btnAll.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAll.Size = new Size(113, 32);
            btnAll.StateCommon.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnAll.StateCommon.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnAll.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAll.StateCommon.Border.Rounding = 10F;
            btnAll.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAll.StateNormal.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnAll.StateNormal.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnAll.StateNormal.Border.Color1 = Color.FromArgb(189, 209, 255);
            btnAll.StateNormal.Border.Color2 = Color.FromArgb(189, 209, 255);
            btnAll.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAll.StatePressed.Back.Color1 = Color.FromArgb(184, 206, 255);
            btnAll.StatePressed.Back.Color2 = Color.FromArgb(184, 206, 255);
            btnAll.StatePressed.Border.Color1 = Color.FromArgb(184, 206, 255);
            btnAll.StatePressed.Border.Color2 = Color.FromArgb(184, 206, 255);
            btnAll.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAll.TabIndex = 50;
            btnAll.Values.Text = "All";
            btnAll.Click += btnAll_Click;
            // 
            // btnInformatika
            // 
            btnInformatika.CornerRoundingRadius = 10F;
            btnInformatika.Location = new Point(839, 176);
            btnInformatika.Margin = new Padding(2);
            btnInformatika.Name = "btnInformatika";
            btnInformatika.OverrideDefault.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnInformatika.OverrideDefault.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnInformatika.OverrideDefault.Border.Color1 = Color.FromArgb(189, 209, 255);
            btnInformatika.OverrideDefault.Border.Color2 = Color.FromArgb(189, 209, 255);
            btnInformatika.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnInformatika.OverrideFocus.Border.Color1 = Color.FromArgb(184, 206, 255);
            btnInformatika.OverrideFocus.Border.Color2 = Color.FromArgb(184, 206, 255);
            btnInformatika.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnInformatika.Size = new Size(113, 32);
            btnInformatika.StateCommon.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnInformatika.StateCommon.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnInformatika.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnInformatika.StateCommon.Border.Rounding = 10F;
            btnInformatika.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnInformatika.StateNormal.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnInformatika.StateNormal.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnInformatika.StateNormal.Border.Color1 = Color.FromArgb(189, 209, 255);
            btnInformatika.StateNormal.Border.Color2 = Color.FromArgb(189, 209, 255);
            btnInformatika.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnInformatika.StatePressed.Back.Color1 = Color.FromArgb(184, 206, 255);
            btnInformatika.StatePressed.Back.Color2 = Color.FromArgb(184, 206, 255);
            btnInformatika.StatePressed.Border.Color1 = Color.FromArgb(184, 206, 255);
            btnInformatika.StatePressed.Border.Color2 = Color.FromArgb(184, 206, 255);
            btnInformatika.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnInformatika.TabIndex = 51;
            btnInformatika.Values.Text = "IF";
            btnInformatika.Click += btnInformatika_Click;
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
            btnBack.TabIndex = 54;
            btnBack.Values.Text = "";
            btnBack.Click += btnBack_Click;
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
            panel4.TabIndex = 55;
            // 
            // lblNamaAdmin
            // 
            lblNamaAdmin.AutoSize = true;
            lblNamaAdmin.BackColor = Color.Transparent;
            lblNamaAdmin.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNamaAdmin.Location = new Point(9, 0);
            lblNamaAdmin.MaximumSize = new Size(160, 26);
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
            // MatkulKonversi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(panel4);
            Controls.Add(btnBack);
            Controls.Add(btnInformatika);
            Controls.Add(btnAll);
            Controls.Add(btnTeknologiInformasi);
            Controls.Add(btnSistemInformasi);
            Controls.Add(btnAddMatkulKonversi);
            Controls.Add(panel1);
            Controls.Add(dgvFormMatkulKonversi);
            Name = "MatkulKonversi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KonversiMatkul";
            ((System.ComponentModel.ISupportInitialize)dgvFormMatkulKonversi).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvFormMatkulKonversi;
        private Panel panel1;
        private Panel panel2;
        private Button btnAchievements;
        private Button btnOtherMenu;
        private Button btnConvertion;
        private Krypton.Toolkit.KryptonButton btnAddMatkulKonversi;
        private Krypton.Toolkit.KryptonButton btnSistemInformasi;
        private Krypton.Toolkit.KryptonButton btnTeknologiInformasi;
        private Krypton.Toolkit.KryptonButton btnAll;
        private Krypton.Toolkit.KryptonButton btnInformatika;
        private Krypton.Toolkit.KryptonButton btnBack;
        private Panel panel4;
        private Label lblNamaAdmin;
        private Krypton.Toolkit.KryptonButton btnLogout;
        private Label lblNIP;
    }
}