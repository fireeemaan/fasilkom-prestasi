namespace fasilkom_prestasi
{
    partial class addMatkulKonversi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addMatkulKonversi));
            btnAddMatkulKonversi = new Krypton.Toolkit.KryptonButton();
            cbxProdi = new ComboBox();
            tbxSKS = new TextBox();
            tbxSemester = new TextBox();
            btnBack = new Krypton.Toolkit.KryptonButton();
            cbxMatkul = new ComboBox();
            cbxBidang = new ComboBox();
            btnEditMatkulKonversi = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // btnAddMatkulKonversi
            // 
            btnAddMatkulKonversi.CornerRoundingRadius = 30F;
            btnAddMatkulKonversi.Location = new Point(265, 330);
            btnAddMatkulKonversi.Margin = new Padding(2);
            btnAddMatkulKonversi.MaximumSize = new Size(248, 47);
            btnAddMatkulKonversi.MinimumSize = new Size(248, 47);
            btnAddMatkulKonversi.Name = "btnAddMatkulKonversi";
            btnAddMatkulKonversi.OverrideDefault.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddMatkulKonversi.OverrideDefault.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddMatkulKonversi.OverrideFocus.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddMatkulKonversi.OverrideFocus.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddMatkulKonversi.Size = new Size(248, 47);
            btnAddMatkulKonversi.StateCommon.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddMatkulKonversi.StateCommon.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddMatkulKonversi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddMatkulKonversi.StateCommon.Border.Rounding = 30F;
            btnAddMatkulKonversi.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAddMatkulKonversi.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAddMatkulKonversi.StateCommon.Content.ShortText.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddMatkulKonversi.StateNormal.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddMatkulKonversi.StateNormal.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddMatkulKonversi.StatePressed.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnAddMatkulKonversi.StatePressed.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnAddMatkulKonversi.TabIndex = 33;
            btnAddMatkulKonversi.Values.Text = "Add";
            btnAddMatkulKonversi.Click += btnaddKonversiMatkul_Click;
            // 
            // cbxProdi
            // 
            cbxProdi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProdi.FlatStyle = FlatStyle.Popup;
            cbxProdi.FormattingEnabled = true;
            cbxProdi.Location = new Point(129, 278);
            cbxProdi.Name = "cbxProdi";
            cbxProdi.Size = new Size(309, 28);
            cbxProdi.TabIndex = 34;
            // 
            // tbxSKS
            // 
            tbxSKS.BorderStyle = BorderStyle.None;
            tbxSKS.Location = new Point(505, 210);
            tbxSKS.Name = "tbxSKS";
            tbxSKS.Size = new Size(61, 20);
            tbxSKS.TabIndex = 35;
            // 
            // tbxSemester
            // 
            tbxSemester.BorderStyle = BorderStyle.None;
            tbxSemester.Location = new Point(505, 148);
            tbxSemester.Name = "tbxSemester";
            tbxSemester.Size = new Size(61, 20);
            tbxSemester.TabIndex = 36;
            // 
            // btnBack
            // 
            btnBack.CornerRoundingRadius = 10F;
            btnBack.Location = new Point(71, 85);
            btnBack.Margin = new Padding(2);
            btnBack.MaximumSize = new Size(36, 36);
            btnBack.MinimumSize = new Size(36, 36);
            btnBack.Name = "btnBack";
            btnBack.OverrideDefault.Back.Color1 = Color.WhiteSmoke;
            btnBack.OverrideDefault.Back.Color2 = Color.WhiteSmoke;
            btnBack.Size = new Size(36, 36);
            btnBack.StateCommon.Back.Color1 = Color.Transparent;
            btnBack.StateCommon.Back.Color2 = Color.Transparent;
            btnBack.StateCommon.Back.Image = (Image)resources.GetObject("btnBack.StateCommon.Back.Image");
            btnBack.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnBack.StateCommon.Border.Color1 = Color.White;
            btnBack.StateCommon.Border.Color2 = Color.White;
            btnBack.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBack.StateCommon.Border.Rounding = 10F;
            btnBack.StatePressed.Back.Color1 = Color.WhiteSmoke;
            btnBack.StatePressed.Back.Color2 = Color.WhiteSmoke;
            btnBack.TabIndex = 48;
            btnBack.Values.Text = "";
            // 
            // cbxMatkul
            // 
            cbxMatkul.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMatkul.FlatStyle = FlatStyle.Popup;
            cbxMatkul.FormattingEnabled = true;
            cbxMatkul.Location = new Point(129, 210);
            cbxMatkul.Name = "cbxMatkul";
            cbxMatkul.Size = new Size(309, 28);
            cbxMatkul.TabIndex = 49;
            // 
            // cbxBidang
            // 
            cbxBidang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBidang.FlatStyle = FlatStyle.Popup;
            cbxBidang.FormattingEnabled = true;
            cbxBidang.Location = new Point(129, 145);
            cbxBidang.Name = "cbxBidang";
            cbxBidang.Size = new Size(309, 28);
            cbxBidang.TabIndex = 50;
            // 
            // btnEditMatkulKonversi
            // 
            btnEditMatkulKonversi.CornerRoundingRadius = 30F;
            btnEditMatkulKonversi.Location = new Point(265, 330);
            btnEditMatkulKonversi.Margin = new Padding(2);
            btnEditMatkulKonversi.MaximumSize = new Size(248, 47);
            btnEditMatkulKonversi.MinimumSize = new Size(248, 47);
            btnEditMatkulKonversi.Name = "btnEditMatkulKonversi";
            btnEditMatkulKonversi.OverrideDefault.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditMatkulKonversi.OverrideDefault.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditMatkulKonversi.OverrideFocus.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditMatkulKonversi.OverrideFocus.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditMatkulKonversi.Size = new Size(248, 47);
            btnEditMatkulKonversi.StateCommon.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditMatkulKonversi.StateCommon.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditMatkulKonversi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnEditMatkulKonversi.StateCommon.Border.Rounding = 30F;
            btnEditMatkulKonversi.StateCommon.Content.ShortText.Color1 = Color.White;
            btnEditMatkulKonversi.StateCommon.Content.ShortText.Color2 = Color.White;
            btnEditMatkulKonversi.StateCommon.Content.ShortText.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditMatkulKonversi.StateNormal.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditMatkulKonversi.StateNormal.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditMatkulKonversi.StatePressed.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnEditMatkulKonversi.StatePressed.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnEditMatkulKonversi.TabIndex = 52;
            btnEditMatkulKonversi.Values.Text = "Save Changes";
            btnEditMatkulKonversi.Click += btnEditMatkulKonversi_Click;
            // 
            // addMatkulKonversi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(801, 451);
            Controls.Add(cbxBidang);
            Controls.Add(cbxMatkul);
            Controls.Add(btnBack);
            Controls.Add(tbxSemester);
            Controls.Add(tbxSKS);
            Controls.Add(cbxProdi);
            Controls.Add(btnEditMatkulKonversi);
            Controls.Add(btnAddMatkulKonversi);
            Name = "addMatkulKonversi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addMatkulKonversi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnAddMatkulKonversi;
        private ComboBox cbxProdi;
        private TextBox tbxSKS;
        private TextBox tbxSemester;
        private Krypton.Toolkit.KryptonButton btnBack;
        private ComboBox cbxMatkul;
        private ComboBox cbxBidang;
        private Krypton.Toolkit.KryptonButton btnEditMatkulKonversi;
    }
}