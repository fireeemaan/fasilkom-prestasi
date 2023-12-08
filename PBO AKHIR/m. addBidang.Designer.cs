namespace fasilkom_prestasi
{
    partial class addBidang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addBidang));
            btnAddBidang = new Krypton.Toolkit.KryptonButton();
            tbxNamaBidang = new TextBox();
            btnEditBidang = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // btnAddBidang
            // 
            btnAddBidang.CornerRoundingRadius = 30F;
            btnAddBidang.Location = new Point(274, 289);
            btnAddBidang.Margin = new Padding(2);
            btnAddBidang.MaximumSize = new Size(248, 47);
            btnAddBidang.MinimumSize = new Size(248, 47);
            btnAddBidang.Name = "btnAddBidang";
            btnAddBidang.OverrideDefault.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddBidang.OverrideDefault.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddBidang.OverrideFocus.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddBidang.OverrideFocus.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddBidang.Size = new Size(248, 47);
            btnAddBidang.StateCommon.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddBidang.StateCommon.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddBidang.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddBidang.StateCommon.Border.Rounding = 30F;
            btnAddBidang.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAddBidang.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAddBidang.StateCommon.Content.ShortText.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddBidang.StateNormal.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddBidang.StateNormal.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddBidang.StatePressed.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddBidang.StatePressed.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddBidang.TabIndex = 24;
            btnAddBidang.Values.Text = "Tambahkan";
            btnAddBidang.Click += btnAddBidang_Click;
            // 
            // tbxNamaBidang
            // 
            tbxNamaBidang.BorderStyle = BorderStyle.None;
            tbxNamaBidang.Location = new Point(246, 189);
            tbxNamaBidang.Name = "tbxNamaBidang";
            tbxNamaBidang.Size = new Size(310, 20);
            tbxNamaBidang.TabIndex = 25;
            // 
            // btnEditBidang
            // 
            btnEditBidang.CornerRoundingRadius = 30F;
            btnEditBidang.Location = new Point(274, 289);
            btnEditBidang.Margin = new Padding(2);
            btnEditBidang.MaximumSize = new Size(248, 47);
            btnEditBidang.MinimumSize = new Size(248, 47);
            btnEditBidang.Name = "btnEditBidang";
            btnEditBidang.OverrideDefault.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditBidang.OverrideDefault.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditBidang.OverrideFocus.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditBidang.OverrideFocus.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditBidang.Size = new Size(248, 47);
            btnEditBidang.StateCommon.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditBidang.StateCommon.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditBidang.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEditBidang.StateCommon.Border.Rounding = 30F;
            btnEditBidang.StateCommon.Content.ShortText.Color1 = Color.White;
            btnEditBidang.StateCommon.Content.ShortText.Color2 = Color.White;
            btnEditBidang.StateCommon.Content.ShortText.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditBidang.StateNormal.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditBidang.StateNormal.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditBidang.StatePressed.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditBidang.StatePressed.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditBidang.TabIndex = 26;
            btnEditBidang.Values.Text = "Simpan";
            btnEditBidang.Click += btnEditBidang_Click;
            // 
            // addBidang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(801, 451);
            Controls.Add(btnEditBidang);
            Controls.Add(tbxNamaBidang);
            Controls.Add(btnAddBidang);
            Name = "addBidang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addBidang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Krypton.Toolkit.KryptonButton btnAddBidang;
        private TextBox tbxNamaBidang;
        private Krypton.Toolkit.KryptonButton btnEditBidang;
    }
}