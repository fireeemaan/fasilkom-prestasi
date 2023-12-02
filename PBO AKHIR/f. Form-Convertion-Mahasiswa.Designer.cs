namespace fasilkom_prestasi
{
    partial class Form_Convertion_Mahasiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Convertion_Mahasiswa));
            tbxNamaLomba = new TextBox();
            tbxRegion = new TextBox();
            tbxTahapan = new TextBox();
            tbxBidang = new TextBox();
            tbxNilai = new TextBox();
            cbxMatkulPilihan = new ComboBox();
            btnAddConvertion = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // tbxNamaLomba
            // 
            tbxNamaLomba.BackColor = Color.White;
            tbxNamaLomba.BorderStyle = BorderStyle.None;
            tbxNamaLomba.Location = new Point(402, 265);
            tbxNamaLomba.Name = "tbxNamaLomba";
            tbxNamaLomba.ReadOnly = true;
            tbxNamaLomba.Size = new Size(483, 20);
            tbxNamaLomba.TabIndex = 1;
            // 
            // tbxRegion
            // 
            tbxRegion.BackColor = Color.White;
            tbxRegion.BorderStyle = BorderStyle.None;
            tbxRegion.Location = new Point(402, 362);
            tbxRegion.Name = "tbxRegion";
            tbxRegion.ReadOnly = true;
            tbxRegion.Size = new Size(483, 20);
            tbxRegion.TabIndex = 2;
            // 
            // tbxTahapan
            // 
            tbxTahapan.BackColor = Color.White;
            tbxTahapan.BorderStyle = BorderStyle.None;
            tbxTahapan.Location = new Point(958, 362);
            tbxTahapan.Name = "tbxTahapan";
            tbxTahapan.ReadOnly = true;
            tbxTahapan.Size = new Size(483, 20);
            tbxTahapan.TabIndex = 3;
            // 
            // tbxBidang
            // 
            tbxBidang.BackColor = Color.White;
            tbxBidang.BorderStyle = BorderStyle.None;
            tbxBidang.Location = new Point(958, 265);
            tbxBidang.Name = "tbxBidang";
            tbxBidang.ReadOnly = true;
            tbxBidang.Size = new Size(483, 20);
            tbxBidang.TabIndex = 4;
            // 
            // tbxNilai
            // 
            tbxNilai.BackColor = Color.White;
            tbxNilai.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tbxNilai.Location = new Point(895, 447);
            tbxNilai.Name = "tbxNilai";
            tbxNilai.ReadOnly = true;
            tbxNilai.Size = new Size(54, 52);
            tbxNilai.TabIndex = 5;
            tbxNilai.TextAlign = HorizontalAlignment.Center;
            // 
            // cbxMatkulPilihan
            // 
            cbxMatkulPilihan.FlatStyle = FlatStyle.Flat;
            cbxMatkulPilihan.FormattingEnabled = true;
            cbxMatkulPilihan.Location = new Point(682, 576);
            cbxMatkulPilihan.Name = "cbxMatkulPilihan";
            cbxMatkulPilihan.Size = new Size(486, 28);
            cbxMatkulPilihan.TabIndex = 6;
            // 
            // btnAddConvertion
            // 
            btnAddConvertion.CornerRoundingRadius = 30F;
            btnAddConvertion.Location = new Point(799, 639);
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
            btnAddConvertion.TabIndex = 23;
            btnAddConvertion.Values.Text = "Add Convertion";
            // 
            // Form_Convertion_Mahasiswa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(btnAddConvertion);
            Controls.Add(cbxMatkulPilihan);
            Controls.Add(tbxNilai);
            Controls.Add(tbxBidang);
            Controls.Add(tbxTahapan);
            Controls.Add(tbxRegion);
            Controls.Add(tbxNamaLomba);
            Name = "Form_Convertion_Mahasiswa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Convertion_Mahasiswa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxNamaLomba;
        private TextBox tbxRegion;
        private TextBox tbxTahapan;
        private TextBox tbxBidang;
        private TextBox tbxNilai;
        private ComboBox cbxMatkulPilihan;
        private Krypton.Toolkit.KryptonButton btnAddConvertion;
    }
}