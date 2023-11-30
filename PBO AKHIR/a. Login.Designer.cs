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
            tbxUser = new TextBox();
            tbxPass = new TextBox();
            btnLogin = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // tbxUser
            // 
            tbxUser.BorderStyle = BorderStyle.None;
            tbxUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxUser.Location = new Point(983, 395);
            tbxUser.Name = "tbxUser";
            tbxUser.Size = new Size(487, 27);
            tbxUser.TabIndex = 0;
            // 
            // tbxPass
            // 
            tbxPass.BorderStyle = BorderStyle.None;
            tbxPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxPass.Location = new Point(983, 534);
            tbxPass.Name = "tbxPass";
            tbxPass.Size = new Size(487, 27);
            tbxPass.TabIndex = 1;
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
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(btnLogin);
            Controls.Add(tbxPass);
            Controls.Add(tbxUser);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxUser;
        private TextBox tbxPass;
        private Krypton.Toolkit.KryptonButton btnLogin;
    }
}