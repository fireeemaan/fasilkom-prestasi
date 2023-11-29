namespace fasilkom_prestasi
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonButton1);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1600, 900);
            kryptonPanel1.StateCommon.Image = (Image)resources.GetObject("kryptonPanel1.StateCommon.Image");
            kryptonPanel1.TabIndex = 0;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(1520, 0);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.White;
            kryptonButton1.OverrideDefault.Back.Color2 = Color.White;
            kryptonButton1.OverrideDefault.Border.Color1 = Color.White;
            kryptonButton1.OverrideDefault.Border.Color2 = Color.White;
            kryptonButton1.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.OverrideFocus.Back.Color1 = Color.FromArgb(224, 224, 224);
            kryptonButton1.OverrideFocus.Back.Color2 = Color.FromArgb(224, 224, 224);
            kryptonButton1.OverrideFocus.Border.Color1 = Color.White;
            kryptonButton1.OverrideFocus.Border.Color2 = Color.White;
            kryptonButton1.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.Size = new Size(80, 80);
            kryptonButton1.StateTracking.Back.Color1 = Color.White;
            kryptonButton1.StateTracking.Back.Color2 = Color.White;
            kryptonButton1.TabIndex = 0;
            kryptonButton1.Values.Text = "Close";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Page";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ResumeLayout(false);
            
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}