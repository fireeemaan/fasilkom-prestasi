namespace fasilkom_prestasi
{
    partial class addProdi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProdi));
            tbxNamaProdi = new TextBox();
            btnAddProdi = new Krypton.Toolkit.KryptonButton();
            btnEditProdi = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // tbxNamaProdi
            // 
            tbxNamaProdi.BorderStyle = BorderStyle.None;
            tbxNamaProdi.Location = new Point(245, 190);
            tbxNamaProdi.Name = "tbxNamaProdi";
            tbxNamaProdi.Size = new Size(310, 20);
            tbxNamaProdi.TabIndex = 30;
            // 
            // btnAddProdi
            // 
            btnAddProdi.CornerRoundingRadius = 30F;
            btnAddProdi.Location = new Point(274, 238);
            btnAddProdi.Margin = new Padding(2);
            btnAddProdi.MaximumSize = new Size(248, 47);
            btnAddProdi.MinimumSize = new Size(248, 47);
            btnAddProdi.Name = "btnAddProdi";
            btnAddProdi.OverrideDefault.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddProdi.OverrideDefault.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddProdi.OverrideFocus.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddProdi.OverrideFocus.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddProdi.Size = new Size(248, 47);
            btnAddProdi.StateCommon.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddProdi.StateCommon.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddProdi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddProdi.StateCommon.Border.Rounding = 30F;
            btnAddProdi.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAddProdi.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAddProdi.StateCommon.Content.ShortText.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddProdi.StateNormal.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddProdi.StateNormal.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddProdi.StatePressed.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddProdi.StatePressed.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddProdi.TabIndex = 31;
            btnAddProdi.Values.Text = "Tambahkan";
            btnAddProdi.Click += btnAddProdi_Click;
            // 
            // btnEditProdi
            // 
            btnEditProdi.CornerRoundingRadius = 30F;
            btnEditProdi.Location = new Point(274, 289);
            btnEditProdi.Margin = new Padding(2);
            btnEditProdi.MaximumSize = new Size(248, 47);
            btnEditProdi.MinimumSize = new Size(248, 47);
            btnEditProdi.Name = "btnEditProdi";
            btnEditProdi.OverrideDefault.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditProdi.OverrideDefault.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditProdi.OverrideFocus.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditProdi.OverrideFocus.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditProdi.Size = new Size(248, 47);
            btnEditProdi.StateCommon.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditProdi.StateCommon.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditProdi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEditProdi.StateCommon.Border.Rounding = 30F;
            btnEditProdi.StateCommon.Content.ShortText.Color1 = Color.White;
            btnEditProdi.StateCommon.Content.ShortText.Color2 = Color.White;
            btnEditProdi.StateCommon.Content.ShortText.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditProdi.StateNormal.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditProdi.StateNormal.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditProdi.StatePressed.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditProdi.StatePressed.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditProdi.TabIndex = 32;
            btnEditProdi.Values.Text = "Simpan";
            btnEditProdi.Click += btnEditProdi_Click;
            // 
            // addProdi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditProdi);
            Controls.Add(btnAddProdi);
            Controls.Add(tbxNamaProdi);
            Name = "addProdi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addProdi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxNamaProdi;
        private Krypton.Toolkit.KryptonButton btnAddProdi;
        private Krypton.Toolkit.KryptonButton btnEditProdi;
    }
}