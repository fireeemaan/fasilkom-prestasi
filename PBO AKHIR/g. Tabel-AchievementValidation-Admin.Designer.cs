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
            sidePanel = new Panel();
            btnRecord = new Button();
            btnArchive = new Krypton.Toolkit.KryptonButton();
            btnValidShow = new Krypton.Toolkit.KryptonButton();
            btnInvalidShow = new Krypton.Toolkit.KryptonButton();
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
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(189, 209, 255);
            sidePanel.ForeColor = Color.White;
            sidePanel.Location = new Point(2, 159);
            sidePanel.Margin = new Padding(2);
            sidePanel.MaximumSize = new Size(8, 48);
            sidePanel.MinimumSize = new Size(8, 48);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(8, 48);
            sidePanel.TabIndex = 26;
            sidePanel.Paint += sidePanel_Paint;
            // 
            // btnRecord
            // 
            btnRecord.BackColor = Color.White;
            btnRecord.FlatAppearance.BorderSize = 0;
            btnRecord.FlatStyle = FlatStyle.Flat;
            btnRecord.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRecord.Image = (Image)resources.GetObject("btnRecord.Image");
            btnRecord.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecord.Location = new Point(11, 159);
            btnRecord.Margin = new Padding(2);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(232, 48);
            btnRecord.TabIndex = 27;
            btnRecord.Text = "Validation";
            btnRecord.UseVisualStyleBackColor = false;
            btnRecord.Click += btnRecord_Click;
            // 
            // btnArchive
            // 
            btnArchive.CornerRoundingRadius = 10F;
            btnArchive.Location = new Point(362, 113);
            btnArchive.Margin = new Padding(2);
            btnArchive.Name = "btnArchive";
            btnArchive.OverrideDefault.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnArchive.OverrideDefault.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnArchive.OverrideDefault.Border.Color1 = Color.FromArgb(189, 209, 255);
            btnArchive.OverrideDefault.Border.Color2 = Color.FromArgb(189, 209, 255);
            btnArchive.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnArchive.OverrideFocus.Border.Color1 = Color.FromArgb(184, 206, 255);
            btnArchive.OverrideFocus.Border.Color2 = Color.FromArgb(184, 206, 255);
            btnArchive.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnArchive.Size = new Size(113, 32);
            btnArchive.StateCommon.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnArchive.StateCommon.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnArchive.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnArchive.StateCommon.Border.Rounding = 10F;
            btnArchive.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnArchive.StateNormal.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnArchive.StateNormal.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnArchive.StateNormal.Border.Color1 = Color.FromArgb(189, 209, 255);
            btnArchive.StateNormal.Border.Color2 = Color.FromArgb(189, 209, 255);
            btnArchive.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnArchive.StatePressed.Back.Color1 = Color.FromArgb(184, 206, 255);
            btnArchive.StatePressed.Back.Color2 = Color.FromArgb(184, 206, 255);
            btnArchive.StatePressed.Border.Color1 = Color.FromArgb(184, 206, 255);
            btnArchive.StatePressed.Border.Color2 = Color.FromArgb(184, 206, 255);
            btnArchive.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnArchive.TabIndex = 28;
            btnArchive.Values.Text = "Process";
            // 
            // btnValidShow
            // 
            btnValidShow.CornerRoundingRadius = 10F;
            btnValidShow.Location = new Point(479, 113);
            btnValidShow.Margin = new Padding(2);
            btnValidShow.Name = "btnValidShow";
            btnValidShow.OverrideDefault.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnValidShow.OverrideDefault.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnValidShow.OverrideDefault.Border.Color1 = Color.FromArgb(189, 209, 255);
            btnValidShow.OverrideDefault.Border.Color2 = Color.FromArgb(189, 209, 255);
            btnValidShow.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnValidShow.OverrideFocus.Border.Color1 = Color.FromArgb(184, 206, 255);
            btnValidShow.OverrideFocus.Border.Color2 = Color.FromArgb(184, 206, 255);
            btnValidShow.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnValidShow.Size = new Size(113, 32);
            btnValidShow.StateCommon.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnValidShow.StateCommon.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnValidShow.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnValidShow.StateCommon.Border.Rounding = 10F;
            btnValidShow.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnValidShow.StateNormal.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnValidShow.StateNormal.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnValidShow.StateNormal.Border.Color1 = Color.FromArgb(189, 209, 255);
            btnValidShow.StateNormal.Border.Color2 = Color.FromArgb(189, 209, 255);
            btnValidShow.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnValidShow.StatePressed.Back.Color1 = Color.FromArgb(184, 206, 255);
            btnValidShow.StatePressed.Back.Color2 = Color.FromArgb(184, 206, 255);
            btnValidShow.StatePressed.Border.Color1 = Color.FromArgb(184, 206, 255);
            btnValidShow.StatePressed.Border.Color2 = Color.FromArgb(184, 206, 255);
            btnValidShow.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnValidShow.TabIndex = 29;
            btnValidShow.Values.Text = "Valid";
            btnValidShow.Click += btnValidShow_Click;
            // 
            // btnInvalidShow
            // 
            btnInvalidShow.CornerRoundingRadius = 10F;
            btnInvalidShow.Location = new Point(607, 113);
            btnInvalidShow.Margin = new Padding(2);
            btnInvalidShow.Name = "btnInvalidShow";
            btnInvalidShow.OverrideDefault.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnInvalidShow.OverrideDefault.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnInvalidShow.OverrideDefault.Border.Color1 = Color.FromArgb(189, 209, 255);
            btnInvalidShow.OverrideDefault.Border.Color2 = Color.FromArgb(189, 209, 255);
            btnInvalidShow.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnInvalidShow.OverrideFocus.Border.Color1 = Color.FromArgb(184, 206, 255);
            btnInvalidShow.OverrideFocus.Border.Color2 = Color.FromArgb(184, 206, 255);
            btnInvalidShow.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnInvalidShow.Size = new Size(113, 32);
            btnInvalidShow.StateCommon.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnInvalidShow.StateCommon.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnInvalidShow.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnInvalidShow.StateCommon.Border.Rounding = 10F;
            btnInvalidShow.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnInvalidShow.StateNormal.Back.Color1 = Color.FromArgb(189, 209, 255);
            btnInvalidShow.StateNormal.Back.Color2 = Color.FromArgb(189, 209, 255);
            btnInvalidShow.StateNormal.Border.Color1 = Color.FromArgb(189, 209, 255);
            btnInvalidShow.StateNormal.Border.Color2 = Color.FromArgb(189, 209, 255);
            btnInvalidShow.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnInvalidShow.StatePressed.Back.Color1 = Color.FromArgb(184, 206, 255);
            btnInvalidShow.StatePressed.Back.Color2 = Color.FromArgb(184, 206, 255);
            btnInvalidShow.StatePressed.Border.Color1 = Color.FromArgb(184, 206, 255);
            btnInvalidShow.StatePressed.Border.Color2 = Color.FromArgb(184, 206, 255);
            btnInvalidShow.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnInvalidShow.TabIndex = 30;
            btnInvalidShow.Values.Text = "Invalid";
            // 
            // Validation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(btnInvalidShow);
            Controls.Add(btnValidShow);
            Controls.Add(btnArchive);
            Controls.Add(sidePanel);
            Controls.Add(btnRecord);
            Controls.Add(dgvValidation);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Validation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tabel Achievement Validation Admin";
            ((System.ComponentModel.ISupportInitialize)dgvValidation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvValidation;
        private Panel sidePanel;
        private Button btnRecord;
        private Krypton.Toolkit.KryptonButton btnArchive;
        private Krypton.Toolkit.KryptonButton btnValidShow;
        private Krypton.Toolkit.KryptonButton btnInvalidShow;
    }
}