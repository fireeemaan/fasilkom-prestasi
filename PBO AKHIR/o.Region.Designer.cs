namespace fasilkom_prestasi
{
    partial class Region
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Region));
            btnAddTahapan = new Krypton.Toolkit.KryptonButton();
            dgvFormRegion = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvFormRegion).BeginInit();
            SuspendLayout();
            // 
            // btnAddTahapan
            // 
            btnAddTahapan.Location = new Point(1221, 166);
            btnAddTahapan.Margin = new Padding(2);
            btnAddTahapan.MaximumSize = new Size(208, 56);
            btnAddTahapan.MinimumSize = new Size(208, 56);
            btnAddTahapan.Name = "btnAddTahapan";
            btnAddTahapan.OverrideDefault.Back.Color1 = Color.White;
            btnAddTahapan.OverrideDefault.Back.Color2 = Color.White;
            btnAddTahapan.OverrideDefault.Back.Image = (Image)resources.GetObject("btnAddTahapan.OverrideDefault.Back.Image");
            btnAddTahapan.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAddTahapan.OverrideDefault.Border.Color1 = Color.White;
            btnAddTahapan.OverrideDefault.Border.Color2 = Color.White;
            btnAddTahapan.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddTahapan.OverrideFocus.Back.Color1 = Color.WhiteSmoke;
            btnAddTahapan.OverrideFocus.Back.Color2 = Color.WhiteSmoke;
            btnAddTahapan.OverrideFocus.Back.Image = (Image)resources.GetObject("btnAddTahapan.OverrideFocus.Back.Image");
            btnAddTahapan.OverrideFocus.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAddTahapan.OverrideFocus.Border.Color1 = Color.WhiteSmoke;
            btnAddTahapan.OverrideFocus.Border.Color2 = Color.WhiteSmoke;
            btnAddTahapan.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddTahapan.Size = new Size(208, 56);
            btnAddTahapan.StateCommon.Back.Color1 = Color.White;
            btnAddTahapan.StateCommon.Back.Color2 = Color.White;
            btnAddTahapan.StateCommon.Back.Image = (Image)resources.GetObject("btnAddTahapan.StateCommon.Back.Image");
            btnAddTahapan.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAddTahapan.StateCommon.Border.Color1 = Color.White;
            btnAddTahapan.StateCommon.Border.Color2 = Color.White;
            btnAddTahapan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddTahapan.StateTracking.Back.Color1 = Color.WhiteSmoke;
            btnAddTahapan.StateTracking.Back.Color2 = Color.WhiteSmoke;
            btnAddTahapan.StateTracking.Back.Image = (Image)resources.GetObject("btnAddTahapan.StateTracking.Back.Image");
            btnAddTahapan.TabIndex = 9;
            btnAddTahapan.Values.Text = "";
            btnAddTahapan.Click += btnAddRegion_Click;
            // 
            // dgvFormRegion
            // 
            dgvFormRegion.AllowUserToAddRows = false;
            dgvFormRegion.AllowUserToDeleteRows = false;
            dgvFormRegion.AllowUserToResizeColumns = false;
            dgvFormRegion.AllowUserToResizeRows = false;
            dgvFormRegion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFormRegion.BorderStyle = BorderStyle.None;
            dgvFormRegion.ColumnHeadersHeight = 36;
            dgvFormRegion.Location = new Point(337, 227);
            dgvFormRegion.Name = "dgvFormRegion";
            dgvFormRegion.ReadOnly = true;
            dgvFormRegion.RowHeadersVisible = false;
            dgvFormRegion.RowHeadersWidth = 51;
            dgvFormRegion.RowTemplate.Height = 29;
            dgvFormRegion.Size = new Size(1170, 502);
            dgvFormRegion.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvFormRegion.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvFormRegion.TabIndex = 10;
            dgvFormRegion.CellContentClick += dgvFormRegion_CellContentClick;
            // 
            // Region
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(dgvFormRegion);
            Controls.Add(btnAddTahapan);
            Name = "Region";
            Text = "Region";
            ((System.ComponentModel.ISupportInitialize)dgvFormRegion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnAddTahapan;
        private Krypton.Toolkit.KryptonDataGridView dgvFormRegion;
    }
}