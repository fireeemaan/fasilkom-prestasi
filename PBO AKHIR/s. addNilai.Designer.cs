namespace fasilkom_prestasi
{
    partial class addNilai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addNilai));
            panel1 = new Panel();
            tbxMaxSKS = new TextBox();
            tbxMinSKS = new TextBox();
            cbxTahapan = new ComboBox();
            cbxRegion = new ComboBox();
            cbxNilai = new ComboBox();
            cbtnStatus = new Krypton.Toolkit.KryptonCheckButton();
            btnAddNilai = new Krypton.Toolkit.KryptonButton();
            btnEditNilai = new Krypton.Toolkit.KryptonButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(tbxMaxSKS);
            panel1.Controls.Add(tbxMinSKS);
            panel1.Controls.Add(cbxTahapan);
            panel1.Controls.Add(cbxRegion);
            panel1.Controls.Add(cbxNilai);
            panel1.Controls.Add(cbtnStatus);
            panel1.Controls.Add(btnEditNilai);
            panel1.Controls.Add(btnAddNilai);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // tbxMaxSKS
            // 
            tbxMaxSKS.BorderStyle = BorderStyle.None;
            tbxMaxSKS.Location = new Point(434, 215);
            tbxMaxSKS.Name = "tbxMaxSKS";
            tbxMaxSKS.Size = new Size(248, 20);
            tbxMaxSKS.TabIndex = 31;
            tbxMaxSKS.KeyPress += tbxMaxSKS_KeyPress;
            // 
            // tbxMinSKS
            // 
            tbxMinSKS.BorderStyle = BorderStyle.None;
            tbxMinSKS.Location = new Point(118, 215);
            tbxMinSKS.Name = "tbxMinSKS";
            tbxMinSKS.Size = new Size(248, 20);
            tbxMinSKS.TabIndex = 30;
            tbxMinSKS.KeyPress += tbxMinSKS_KeyPress;
            // 
            // cbxTahapan
            // 
            cbxTahapan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTahapan.FlatStyle = FlatStyle.Popup;
            cbxTahapan.FormattingEnabled = true;
            cbxTahapan.Location = new Point(504, 140);
            cbxTahapan.Name = "cbxTahapan";
            cbxTahapan.Size = new Size(178, 28);
            cbxTahapan.TabIndex = 3;
            // 
            // cbxRegion
            // 
            cbxRegion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRegion.FlatStyle = FlatStyle.Popup;
            cbxRegion.FormattingEnabled = true;
            cbxRegion.Location = new Point(292, 140);
            cbxRegion.Name = "cbxRegion";
            cbxRegion.Size = new Size(173, 28);
            cbxRegion.TabIndex = 2;
            // 
            // cbxNilai
            // 
            cbxNilai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNilai.FlatStyle = FlatStyle.Popup;
            cbxNilai.FormattingEnabled = true;
            cbxNilai.Items.AddRange(new object[] { "A", "AB", "B", "BC", "C" });
            cbxNilai.Location = new Point(118, 140);
            cbxNilai.Name = "cbxNilai";
            cbxNilai.Size = new Size(133, 28);
            cbxNilai.TabIndex = 1;
            // 
            // cbtnStatus
            // 
            cbtnStatus.CornerRoundingRadius = 8F;
            cbtnStatus.Location = new Point(381, 285);
            cbtnStatus.Name = "cbtnStatus";
            cbtnStatus.OverrideDefault.Back.Color1 = Color.White;
            cbtnStatus.OverrideDefault.Back.Color2 = Color.White;
            cbtnStatus.OverrideDefault.Border.Color1 = Color.Gray;
            cbtnStatus.OverrideDefault.Border.Color2 = Color.Gray;
            cbtnStatus.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cbtnStatus.Size = new Size(35, 35);
            cbtnStatus.StateCheckedNormal.Back.Color1 = Color.White;
            cbtnStatus.StateCheckedNormal.Back.Color2 = Color.White;
            cbtnStatus.StateCheckedNormal.Back.Image = (Image)resources.GetObject("cbtnStatus.StateCheckedNormal.Back.Image");
            cbtnStatus.StateCheckedNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            cbtnStatus.StateCheckedNormal.Border.Color1 = Color.Gray;
            cbtnStatus.StateCheckedNormal.Border.Color2 = Color.Gray;
            cbtnStatus.StateCheckedNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cbtnStatus.StateCheckedPressed.Back.Color1 = Color.WhiteSmoke;
            cbtnStatus.StateCheckedPressed.Back.Color2 = Color.WhiteSmoke;
            cbtnStatus.StateCheckedPressed.Border.Color1 = Color.Gray;
            cbtnStatus.StateCheckedPressed.Border.Color2 = Color.Gray;
            cbtnStatus.StateCheckedPressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cbtnStatus.StateCheckedTracking.Back.Color1 = Color.WhiteSmoke;
            cbtnStatus.StateCheckedTracking.Back.Color2 = Color.WhiteSmoke;
            cbtnStatus.StateCheckedTracking.Back.Image = (Image)resources.GetObject("cbtnStatus.StateCheckedTracking.Back.Image");
            cbtnStatus.StateCheckedTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            cbtnStatus.StateCheckedTracking.Border.Color1 = Color.Gray;
            cbtnStatus.StateCheckedTracking.Border.Color2 = Color.Gray;
            cbtnStatus.StateCheckedTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cbtnStatus.StateCommon.Back.Color1 = Color.White;
            cbtnStatus.StateCommon.Back.Color2 = Color.White;
            cbtnStatus.StateCommon.Border.Color1 = Color.Gray;
            cbtnStatus.StateCommon.Border.Color2 = Color.Gray;
            cbtnStatus.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cbtnStatus.StateCommon.Border.Rounding = 8F;
            cbtnStatus.StateTracking.Back.Color1 = Color.WhiteSmoke;
            cbtnStatus.StateTracking.Back.Color2 = Color.WhiteSmoke;
            cbtnStatus.StateTracking.Border.Color1 = Color.Gray;
            cbtnStatus.StateTracking.Border.Color2 = Color.Gray;
            cbtnStatus.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cbtnStatus.TabIndex = 0;
            cbtnStatus.Values.Text = "";
            // 
            // btnAddNilai
            // 
            btnAddNilai.CornerRoundingRadius = 30F;
            btnAddNilai.Location = new Point(274, 338);
            btnAddNilai.Margin = new Padding(2);
            btnAddNilai.MaximumSize = new Size(248, 47);
            btnAddNilai.MinimumSize = new Size(248, 47);
            btnAddNilai.Name = "btnAddNilai";
            btnAddNilai.OverrideDefault.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddNilai.OverrideDefault.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddNilai.OverrideFocus.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddNilai.OverrideFocus.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddNilai.Size = new Size(248, 47);
            btnAddNilai.StateCommon.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddNilai.StateCommon.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddNilai.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddNilai.StateCommon.Border.Rounding = 30F;
            btnAddNilai.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAddNilai.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAddNilai.StateCommon.Content.ShortText.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNilai.StateNormal.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddNilai.StateNormal.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddNilai.StatePressed.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddNilai.StatePressed.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddNilai.TabIndex = 29;
            btnAddNilai.Values.Text = "Add";
            btnAddNilai.Click += btnAddNilai_Click;
            // 
            // btnEditNilai
            // 
            btnEditNilai.CornerRoundingRadius = 30F;
            btnEditNilai.Location = new Point(274, 338);
            btnEditNilai.Margin = new Padding(2);
            btnEditNilai.MaximumSize = new Size(248, 47);
            btnEditNilai.MinimumSize = new Size(248, 47);
            btnEditNilai.Name = "btnEditNilai";
            btnEditNilai.OverrideDefault.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditNilai.OverrideDefault.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditNilai.OverrideFocus.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditNilai.OverrideFocus.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditNilai.Size = new Size(248, 47);
            btnEditNilai.StateCommon.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditNilai.StateCommon.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditNilai.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEditNilai.StateCommon.Border.Rounding = 30F;
            btnEditNilai.StateCommon.Content.ShortText.Color1 = Color.White;
            btnEditNilai.StateCommon.Content.ShortText.Color2 = Color.White;
            btnEditNilai.StateCommon.Content.ShortText.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditNilai.StateNormal.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditNilai.StateNormal.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditNilai.StatePressed.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditNilai.StatePressed.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditNilai.TabIndex = 32;
            btnEditNilai.Values.Text = "Save Changes";
            btnEditNilai.Click += btnEditNilai_Click;
            // 
            // addNilai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "addNilai";
            Text = "addNilai";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Krypton.Toolkit.KryptonCheckButton cbtnStatus;
        private ComboBox cbxNilai;
        private ComboBox cbxTahapan;
        private ComboBox cbxRegion;
        private Krypton.Toolkit.KryptonButton btnAddNilai;
        private TextBox tbxMaxSKS;
        private TextBox tbxMinSKS;
        private Krypton.Toolkit.KryptonButton btnEditNilai;
    }
}