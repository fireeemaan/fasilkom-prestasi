namespace fasilkom_prestasi
{
    partial class addRegion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addRegion));
            btnAddRegion = new Krypton.Toolkit.KryptonButton();
            btnEditRegion = new Krypton.Toolkit.KryptonButton();
            tbxNamaRegion = new TextBox();
            SuspendLayout();
            // 
            // btnAddRegion
            // 
            btnAddRegion.CornerRoundingRadius = 30F;
            btnAddRegion.Location = new Point(274, 254);
            btnAddRegion.Margin = new Padding(2);
            btnAddRegion.MaximumSize = new Size(248, 47);
            btnAddRegion.MinimumSize = new Size(248, 47);
            btnAddRegion.Name = "btnAddRegion";
            btnAddRegion.OverrideDefault.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddRegion.OverrideDefault.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddRegion.OverrideFocus.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddRegion.OverrideFocus.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddRegion.Size = new Size(248, 47);
            btnAddRegion.StateCommon.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddRegion.StateCommon.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddRegion.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddRegion.StateCommon.Border.Rounding = 30F;
            btnAddRegion.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAddRegion.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAddRegion.StateCommon.Content.ShortText.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddRegion.StateNormal.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddRegion.StateNormal.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddRegion.StatePressed.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddRegion.StatePressed.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddRegion.TabIndex = 29;
            btnAddRegion.Values.Text = "Tambahkan";
            btnAddRegion.Click += btnAddRegion_Click;
            // 
            // btnEditRegion
            // 
            btnEditRegion.CornerRoundingRadius = 30F;
            btnEditRegion.Location = new Point(274, 305);
            btnEditRegion.Margin = new Padding(2);
            btnEditRegion.MaximumSize = new Size(248, 47);
            btnEditRegion.MinimumSize = new Size(248, 47);
            btnEditRegion.Name = "btnEditRegion";
            btnEditRegion.OverrideDefault.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditRegion.OverrideDefault.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditRegion.OverrideFocus.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditRegion.OverrideFocus.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditRegion.Size = new Size(248, 47);
            btnEditRegion.StateCommon.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditRegion.StateCommon.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditRegion.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEditRegion.StateCommon.Border.Rounding = 30F;
            btnEditRegion.StateCommon.Content.ShortText.Color1 = Color.White;
            btnEditRegion.StateCommon.Content.ShortText.Color2 = Color.White;
            btnEditRegion.StateCommon.Content.ShortText.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditRegion.StateNormal.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditRegion.StateNormal.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditRegion.StatePressed.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditRegion.StatePressed.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditRegion.TabIndex = 30;
            btnEditRegion.Values.Text = "Simpan";
            btnEditRegion.Click += btnEditRegion_Click;
            // 
            // tbxNamaRegion
            // 
            tbxNamaRegion.BorderStyle = BorderStyle.None;
            tbxNamaRegion.Location = new Point(246, 188);
            tbxNamaRegion.Name = "tbxNamaRegion";
            tbxNamaRegion.Size = new Size(310, 20);
            tbxNamaRegion.TabIndex = 31;
            // 
            // addRegion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(tbxNamaRegion);
            Controls.Add(btnEditRegion);
            Controls.Add(btnAddRegion);
            Name = "addRegion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addRegion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnAddRegion;
        private Krypton.Toolkit.KryptonButton btnEditRegion;
        private TextBox tbxNamaRegion;
    }
}