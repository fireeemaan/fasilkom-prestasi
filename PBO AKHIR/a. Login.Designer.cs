namespace fasilkom_prestasi
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnLogin = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(983, 395);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(487, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(983, 534);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(487, 27);
            textBox2.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.CornerRoundingRadius = 30F;
            btnLogin.Location = new Point(1115, 656);
            btnLogin.Name = "btnLogin";
            btnLogin.OverrideDefault.Back.Color1 = Color.FromArgb(65, 48, 165);
            btnLogin.OverrideDefault.Back.Color2 = Color.FromArgb(65, 48, 165);
            btnLogin.Size = new Size(205, 55);
            btnLogin.StateCommon.Back.Color1 = Color.FromArgb(65, 48, 165);
            btnLogin.StateCommon.Back.Color2 = Color.FromArgb(65, 48, 165);
            btnLogin.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLogin.StateCommon.Border.Rounding = 30F;
            btnLogin.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLogin.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLogin.StateCommon.Content.ShortText.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.StatePressed.Back.Color1 = Color.FromArgb(52, 38, 132);
            btnLogin.StatePressed.Back.Color2 = Color.FromArgb(52, 38, 132);
            btnLogin.TabIndex = 2;
            btnLogin.Values.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(btnLogin);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Krypton.Toolkit.KryptonButton btnLogin;
    }
}