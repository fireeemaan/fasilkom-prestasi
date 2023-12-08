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
            btnAddTahapan = new Krypton.Toolkit.KryptonButton();
            cbxTahapan = new ComboBox();
            cbxRegion = new ComboBox();
            cbxNilai = new ComboBox();
            cbtnStatus = new Krypton.Toolkit.KryptonCheckButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(tbxMaxSKS);
            panel1.Controls.Add(tbxMinSKS);
            panel1.Controls.Add(btnAddTahapan);
            panel1.Controls.Add(cbxTahapan);
            panel1.Controls.Add(cbxRegion);
            panel1.Controls.Add(cbxNilai);
            panel1.Controls.Add(cbtnStatus);
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
            // btnAddTahapan
            // 
            btnAddTahapan.CornerRoundingRadius = 30F;
            btnAddTahapan.Location = new Point(274, 338);
            btnAddTahapan.Margin = new Padding(2);
            btnAddTahapan.MaximumSize = new Size(248, 47);
            btnAddTahapan.MinimumSize = new Size(248, 47);
            btnAddTahapan.Name = "btnAddTahapan";
            btnAddTahapan.OverrideDefault.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddTahapan.OverrideDefault.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddTahapan.OverrideFocus.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddTahapan.OverrideFocus.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddTahapan.Size = new Size(248, 47);
            btnAddTahapan.StateCommon.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddTahapan.StateCommon.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddTahapan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddTahapan.StateCommon.Border.Rounding = 30F;
            btnAddTahapan.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAddTahapan.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAddTahapan.StateCommon.Content.ShortText.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddTahapan.StateNormal.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddTahapan.StateNormal.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddTahapan.StatePressed.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddTahapan.StatePressed.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddTahapan.TabIndex = 29;
            btnAddTahapan.Values.Text = "Tambahkan";
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
        private Krypton.Toolkit.KryptonButton btnAddTahapan;
        private TextBox tbxMaxSKS;
        private TextBox tbxMinSKS;
    }
}