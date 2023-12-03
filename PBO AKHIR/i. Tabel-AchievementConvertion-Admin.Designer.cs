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
            dgvKonversiMatkul = new Krypton.Toolkit.KryptonDataGridView();
            btnAchievements = new Button();
            btnConvertion = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKonversiMatkul).BeginInit();
            SuspendLayout();
            // 
            // dgvKonversiMatkul
            // 
            dgvKonversiMatkul.AllowUserToAddRows = false;
            dgvKonversiMatkul.AllowUserToDeleteRows = false;
            dgvKonversiMatkul.AllowUserToResizeColumns = false;
            dgvKonversiMatkul.AllowUserToResizeRows = false;
            dgvKonversiMatkul.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKonversiMatkul.BorderStyle = BorderStyle.None;
            dgvKonversiMatkul.ColumnHeadersHeight = 36;
            dgvKonversiMatkul.Location = new Point(337, 227);
            dgvKonversiMatkul.Name = "dgvKonversiMatkul";
            dgvKonversiMatkul.ReadOnly = true;
            dgvKonversiMatkul.RowHeadersVisible = false;
            dgvKonversiMatkul.RowHeadersWidth = 51;
            dgvKonversiMatkul.RowTemplate.Height = 29;
            dgvKonversiMatkul.Size = new Size(1170, 502);
            dgvKonversiMatkul.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvKonversiMatkul.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvKonversiMatkul.TabIndex = 3;
            dgvKonversiMatkul.CellContentClick += dgvValidation_CellContentClick;
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
            Controls.Add(dgvKonversiMatkul);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "KonversiAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tabel Achievement Convertion Admin";
            ((System.ComponentModel.ISupportInitialize)dgvKonversiMatkul).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvKonversiMatkul;
        private Button btnAchievements;
        private Button btnConvertion;
    }
}