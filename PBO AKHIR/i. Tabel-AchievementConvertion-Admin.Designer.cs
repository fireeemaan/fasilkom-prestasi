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
            ((System.ComponentModel.ISupportInitialize)dgvKonversi).BeginInit();
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
            btnAchievements.Location = new Point(2, 159);
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
            btnConvertion.Location = new Point(2, 249);
            btnConvertion.Margin = new Padding(2);
            btnConvertion.Name = "btnConvertion";
            btnConvertion.Size = new Size(232, 62);
            btnConvertion.TabIndex = 33;
            btnConvertion.Text = "Convertion\r\nValidation";
            btnConvertion.UseVisualStyleBackColor = false;
            // 
            // KonversiAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(btnConvertion);
            Controls.Add(btnAchievements);
            Controls.Add(dgvKonversi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "KonversiAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tabel Achievement Convertion Admin";
            ((System.ComponentModel.ISupportInitialize)dgvKonversi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvKonversi;
        private Button btnAchievements;
        private Button btnConvertion;
    }
}