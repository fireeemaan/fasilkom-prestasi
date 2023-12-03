namespace fasilkom_prestasi
{
    partial class Bidang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bidang));
            dgvFormBidang = new Krypton.Toolkit.KryptonDataGridView();
            btnAddAchievement = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)dgvFormBidang).BeginInit();
            SuspendLayout();
            // 
            // dgvFormBidang
            // 
            dgvFormBidang.AllowUserToAddRows = false;
            dgvFormBidang.AllowUserToDeleteRows = false;
            dgvFormBidang.AllowUserToResizeColumns = false;
            dgvFormBidang.AllowUserToResizeRows = false;
            dgvFormBidang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFormBidang.BorderStyle = BorderStyle.None;
            dgvFormBidang.ColumnHeadersHeight = 36;
            dgvFormBidang.Location = new Point(337, 227);
            dgvFormBidang.Name = "dgvFormBidang";
            dgvFormBidang.ReadOnly = true;
            dgvFormBidang.RowHeadersVisible = false;
            dgvFormBidang.RowHeadersWidth = 51;
            dgvFormBidang.RowTemplate.Height = 29;
            dgvFormBidang.Size = new Size(1170, 502);
            dgvFormBidang.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvFormBidang.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvFormBidang.TabIndex = 4;
            dgvFormBidang.CellContentClick += dgvFormBidang_CellContentClick;
            // 
            // btnAddAchievement
            // 
            btnAddAchievement.Location = new Point(1221, 166);
            btnAddAchievement.Margin = new Padding(2);
            btnAddAchievement.MaximumSize = new Size(208, 56);
            btnAddAchievement.MinimumSize = new Size(208, 56);
            btnAddAchievement.Name = "btnAddAchievement";
            btnAddAchievement.OverrideDefault.Back.Color1 = Color.White;
            btnAddAchievement.OverrideDefault.Back.Color2 = Color.White;
            btnAddAchievement.OverrideDefault.Back.Image = (Image)resources.GetObject("btnAddAchievement.OverrideDefault.Back.Image");
            btnAddAchievement.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAddAchievement.OverrideDefault.Border.Color1 = Color.White;
            btnAddAchievement.OverrideDefault.Border.Color2 = Color.White;
            btnAddAchievement.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddAchievement.OverrideFocus.Back.Color1 = Color.WhiteSmoke;
            btnAddAchievement.OverrideFocus.Back.Color2 = Color.WhiteSmoke;
            btnAddAchievement.OverrideFocus.Back.Image = (Image)resources.GetObject("btnAddAchievement.OverrideFocus.Back.Image");
            btnAddAchievement.OverrideFocus.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAddAchievement.OverrideFocus.Border.Color1 = Color.WhiteSmoke;
            btnAddAchievement.OverrideFocus.Border.Color2 = Color.WhiteSmoke;
            btnAddAchievement.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddAchievement.Size = new Size(208, 56);
            btnAddAchievement.StateCommon.Back.Color1 = Color.White;
            btnAddAchievement.StateCommon.Back.Color2 = Color.White;
            btnAddAchievement.StateCommon.Back.Image = (Image)resources.GetObject("btnAddAchievement.StateCommon.Back.Image");
            btnAddAchievement.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAddAchievement.StateCommon.Border.Color1 = Color.White;
            btnAddAchievement.StateCommon.Border.Color2 = Color.White;
            btnAddAchievement.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddAchievement.StateTracking.Back.Color1 = Color.WhiteSmoke;
            btnAddAchievement.StateTracking.Back.Color2 = Color.WhiteSmoke;
            btnAddAchievement.StateTracking.Back.Image = (Image)resources.GetObject("btnAddAchievement.StateTracking.Back.Image");
            btnAddAchievement.TabIndex = 7;
            btnAddAchievement.Values.Text = "";
            btnAddAchievement.Click += btnAddAchievement_Click;
            // 
            // Bidang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(btnAddAchievement);
            Controls.Add(dgvFormBidang);
            Name = "Bidang";
            Text = "Form Bidang";
            ((System.ComponentModel.ISupportInitialize)dgvFormBidang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvFormBidang;
        private Krypton.Toolkit.KryptonButton btnAddAchievement;
    }
}