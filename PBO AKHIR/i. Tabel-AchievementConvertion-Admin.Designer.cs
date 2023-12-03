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
            // KonversiAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
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
    }
}