namespace fasilkom_prestasi
{
    partial class Tahapan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tahapan));
            dgvFormTahapan = new Krypton.Toolkit.KryptonDataGridView();
            btnAddTahapan = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)dgvFormTahapan).BeginInit();
            SuspendLayout();
            // 
            // dgvFormTahapan
            // 
            dgvFormTahapan.AllowUserToAddRows = false;
            dgvFormTahapan.AllowUserToDeleteRows = false;
            dgvFormTahapan.AllowUserToResizeColumns = false;
            dgvFormTahapan.AllowUserToResizeRows = false;
            dgvFormTahapan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFormTahapan.BorderStyle = BorderStyle.None;
            dgvFormTahapan.ColumnHeadersHeight = 36;
            dgvFormTahapan.Location = new Point(337, 227);
            dgvFormTahapan.Name = "dgvFormTahapan";
            dgvFormTahapan.ReadOnly = true;
            dgvFormTahapan.RowHeadersVisible = false;
            dgvFormTahapan.RowHeadersWidth = 51;
            dgvFormTahapan.RowTemplate.Height = 29;
            dgvFormTahapan.Size = new Size(1170, 502);
            dgvFormTahapan.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvFormTahapan.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvFormTahapan.TabIndex = 5;
            dgvFormTahapan.CellContentClick += dgvFormTahapan_CellContentClick;
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
            btnAddTahapan.TabIndex = 8;
            btnAddTahapan.Values.Text = "";
            btnAddTahapan.Click += btnAddTahapan_Click;
            // 
            // Tahapan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(btnAddTahapan);
            Controls.Add(dgvFormTahapan);
            Name = "Tahapan";
            Text = "Tahapan";
            ((System.ComponentModel.ISupportInitialize)dgvFormTahapan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvFormTahapan;
        private Krypton.Toolkit.KryptonButton btnAddTahapan;
    }
}