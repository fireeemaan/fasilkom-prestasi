namespace fasilkom_prestasi
{
    partial class Nilai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nilai));
            panel1 = new Panel();
            btnAddNilai = new Krypton.Toolkit.KryptonButton();
            panel2 = new Panel();
            panel3 = new Panel();
            btnAchievements = new Button();
            btnOtherMenu = new Button();
            btnConvertion = new Button();
            btnBack = new Krypton.Toolkit.KryptonButton();
            dgvNilai = new Krypton.Toolkit.KryptonDataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNilai).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(btnAddNilai);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(dgvNilai);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1582, 853);
            panel1.TabIndex = 0;
            // 
            // btnAddNilai
            // 
            btnAddNilai.CornerRoundingRadius = 10F;
            btnAddNilai.Location = new Point(1221, 166);
            btnAddNilai.Margin = new Padding(2);
            btnAddNilai.MaximumSize = new Size(208, 56);
            btnAddNilai.MinimumSize = new Size(208, 56);
            btnAddNilai.Name = "btnAddNilai";
            btnAddNilai.OverrideDefault.Back.Color1 = Color.White;
            btnAddNilai.OverrideDefault.Back.Color2 = Color.White;
            btnAddNilai.OverrideDefault.Back.Image = (Image)resources.GetObject("btnAddNilai.OverrideDefault.Back.Image");
            btnAddNilai.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAddNilai.OverrideDefault.Border.Color1 = Color.White;
            btnAddNilai.OverrideDefault.Border.Color2 = Color.White;
            btnAddNilai.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddNilai.OverrideFocus.Back.Color1 = Color.WhiteSmoke;
            btnAddNilai.OverrideFocus.Back.Color2 = Color.WhiteSmoke;
            btnAddNilai.OverrideFocus.Back.Image = (Image)resources.GetObject("btnAddNilai.OverrideFocus.Back.Image");
            btnAddNilai.OverrideFocus.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAddNilai.OverrideFocus.Border.Color1 = Color.WhiteSmoke;
            btnAddNilai.OverrideFocus.Border.Color2 = Color.WhiteSmoke;
            btnAddNilai.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddNilai.Size = new Size(208, 56);
            btnAddNilai.StateCommon.Back.Color1 = Color.White;
            btnAddNilai.StateCommon.Back.Color2 = Color.White;
            btnAddNilai.StateCommon.Back.Image = (Image)resources.GetObject("btnAddNilai.StateCommon.Back.Image");
            btnAddNilai.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAddNilai.StateCommon.Border.Color1 = Color.White;
            btnAddNilai.StateCommon.Border.Color2 = Color.White;
            btnAddNilai.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddNilai.StateCommon.Border.Rounding = 10F;
            btnAddNilai.StatePressed.Back.Image = (Image)resources.GetObject("btnAddNilai.StatePressed.Back.Image");
            btnAddNilai.StateTracking.Back.Color1 = Color.WhiteSmoke;
            btnAddNilai.StateTracking.Back.Color2 = Color.WhiteSmoke;
            btnAddNilai.StateTracking.Back.Image = (Image)resources.GetObject("btnAddNilai.StateTracking.Back.Image");
            btnAddNilai.TabIndex = 51;
            btnAddNilai.Values.Text = "";
            btnAddNilai.Click += btnAddNilai_Click;
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
            panel2.TabIndex = 50;
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
            btnBack.TabIndex = 49;
            btnBack.Values.Text = "";
            btnBack.Click += btnBack_Click;
            // 
            // dgvNilai
            // 
            dgvNilai.AllowUserToAddRows = false;
            dgvNilai.AllowUserToDeleteRows = false;
            dgvNilai.AllowUserToResizeColumns = false;
            dgvNilai.AllowUserToResizeRows = false;
            dgvNilai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNilai.BorderStyle = BorderStyle.None;
            dgvNilai.ColumnHeadersHeight = 36;
            dgvNilai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNilai.Location = new Point(337, 227);
            dgvNilai.Name = "dgvNilai";
            dgvNilai.ReadOnly = true;
            dgvNilai.RowHeadersVisible = false;
            dgvNilai.RowHeadersWidth = 51;
            dgvNilai.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNilai.RowTemplate.Height = 45;
            dgvNilai.Size = new Size(1170, 578);
            dgvNilai.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvNilai.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvNilai.TabIndex = 1;
            dgvNilai.CellContentClick += dgvNilai_CellContentClick;
            // 
            // Nilai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel1);
            Name = "Nilai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nilai";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNilai).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Krypton.Toolkit.KryptonDataGridView dgvNilai;
        private Krypton.Toolkit.KryptonButton btnBack;
        private Panel panel2;
        private Panel panel3;
        private Button btnAchievements;
        private Button btnOtherMenu;
        private Button btnConvertion;
        private Krypton.Toolkit.KryptonButton btnAddNilai;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}