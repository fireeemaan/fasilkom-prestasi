namespace fasilkom_prestasi
{
    partial class Validation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Validation));
            dgvValidation = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvValidation).BeginInit();
            SuspendLayout();
            // 
            // dgvValidation
            // 
            dgvValidation.AllowUserToAddRows = false;
            dgvValidation.AllowUserToDeleteRows = false;
            dgvValidation.AllowUserToResizeColumns = false;
            dgvValidation.AllowUserToResizeRows = false;
            dgvValidation.BorderStyle = BorderStyle.None;
            dgvValidation.ColumnHeadersHeight = 36;
            dgvValidation.Location = new Point(338, 227);
            dgvValidation.Name = "dgvValidation";
            dgvValidation.ReadOnly = true;
            dgvValidation.RowHeadersVisible = false;
            dgvValidation.RowHeadersWidth = 51;
            dgvValidation.RowTemplate.Height = 29;
            dgvValidation.Size = new Size(1170, 502);
            dgvValidation.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvValidation.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvValidation.TabIndex = 2;
            dgvValidation.CellContentClick += dgvValidation_CellContentClick;
            dgvValidation.CellContentDoubleClick += dgvValidation_CellContentDoubleClick;
            // 
            // Validation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(dgvValidation);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Validation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tabel Achievement Validation Admin";
            ((System.ComponentModel.ISupportInitialize)dgvValidation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvValidation;
    }
}