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
            btnAddConvertion = new Krypton.Toolkit.KryptonButton();
            tbxNamaBidang = new TextBox();
            SuspendLayout();
            // 
            // btnAddConvertion
            // 
            btnAddConvertion.CornerRoundingRadius = 30F;
            btnAddConvertion.Location = new Point(274, 322);
            btnAddConvertion.Margin = new Padding(2);
            btnAddConvertion.MaximumSize = new Size(248, 47);
            btnAddConvertion.MinimumSize = new Size(248, 47);
            btnAddConvertion.Name = "btnAddConvertion";
            btnAddConvertion.OverrideDefault.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddConvertion.OverrideDefault.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddConvertion.OverrideFocus.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddConvertion.OverrideFocus.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddConvertion.Size = new Size(248, 47);
            btnAddConvertion.StateCommon.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddConvertion.StateCommon.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddConvertion.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddConvertion.StateCommon.Border.Rounding = 30F;
            btnAddConvertion.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAddConvertion.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAddConvertion.StateCommon.Content.ShortText.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddConvertion.StateNormal.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddConvertion.StateNormal.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddConvertion.StatePressed.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddConvertion.StatePressed.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddConvertion.TabIndex = 24;
            btnAddConvertion.Values.Text = "Tambahkan";
            btnAddConvertion.Click += btnAddConvertion_Click;
            // 
            // tbxNamaBidang
            // 
            tbxNamaBidang.BorderStyle = BorderStyle.None;
            tbxNamaBidang.Location = new Point(246, 189);
            tbxNamaBidang.Name = "tbxNamaBidang";
            tbxNamaBidang.Size = new Size(310, 20);
            tbxNamaBidang.TabIndex = 25;
            // 
            // addBidang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(801, 451);
            Controls.Add(tbxNamaBidang);
            Controls.Add(btnAddConvertion);
            Name = "addBidang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addBidang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Krypton.Toolkit.KryptonButton btnAddConvertion;
        private TextBox tbxNamaBidang;
    }
}