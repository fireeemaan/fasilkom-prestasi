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
            UserBox = new TextBox();
            PassBox = new TextBox();
            btnLogin = new Krypton.Toolkit.KryptonButton();
            invalidUsernamePasswordControl1 = new InvalidUsernamePasswordControl();
            hideButton = new Krypton.Toolkit.KryptonCheckButton();
            SuspendLayout();
            // 
            // UserBox
            // 
            UserBox.BorderStyle = BorderStyle.None;
            UserBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserBox.Location = new Point(983, 393);
            UserBox.Name = "UserBox";
            UserBox.Size = new Size(487, 27);
            UserBox.TabIndex = 0;
            // 
            // PassBox
            // 
            PassBox.BorderStyle = BorderStyle.None;
            PassBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PassBox.Location = new Point(983, 532);
            PassBox.Name = "PassBox";
            PassBox.PasswordChar = '*';
            PassBox.Size = new Size(438, 27);
            PassBox.TabIndex = 1;
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
            // invalidUsernamePasswordControl1
            // 
            invalidUsernamePasswordControl1.BackColor = Color.White;
            invalidUsernamePasswordControl1.Location = new Point(942, 43);
            invalidUsernamePasswordControl1.Name = "invalidUsernamePasswordControl1";
            invalidUsernamePasswordControl1.Size = new Size(543, 73);
            invalidUsernamePasswordControl1.TabIndex = 6;
            invalidUsernamePasswordControl1.Load += invalidUsernamePasswordControl1_Load;
            // 
            // hideButton
            // 
            hideButton.CornerRoundingRadius = 6F;
            hideButton.Location = new Point(1425, 525);
            hideButton.Name = "hideButton";
            hideButton.OverrideDefault.Back.Color1 = Color.White;
            hideButton.OverrideDefault.Back.Color2 = Color.White;
            hideButton.OverrideDefault.Border.Color1 = Color.White;
            hideButton.OverrideDefault.Border.Color2 = Color.White;
            hideButton.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            hideButton.Size = new Size(45, 45);
            hideButton.StateCheckedNormal.Back.Color1 = Color.White;
            hideButton.StateCheckedNormal.Back.Color2 = Color.White;
            hideButton.StateCheckedNormal.Back.Image = (Image)resources.GetObject("hideButton.StateCheckedNormal.Back.Image");
            hideButton.StateCheckedNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            hideButton.StateCheckedNormal.Border.Color1 = Color.White;
            hideButton.StateCheckedNormal.Border.Color2 = Color.White;
            hideButton.StateCheckedNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            hideButton.StateCheckedPressed.Back.Color1 = Color.WhiteSmoke;
            hideButton.StateCheckedPressed.Back.Color2 = Color.WhiteSmoke;
            hideButton.StateCheckedPressed.Back.Image = (Image)resources.GetObject("hideButton.StateCheckedPressed.Back.Image");
            hideButton.StateCheckedPressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            hideButton.StateCheckedPressed.Border.Color1 = Color.WhiteSmoke;
            hideButton.StateCheckedPressed.Border.Color2 = Color.WhiteSmoke;
            hideButton.StateCheckedPressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            hideButton.StateCheckedTracking.Back.Color1 = Color.WhiteSmoke;
            hideButton.StateCheckedTracking.Back.Color2 = Color.WhiteSmoke;
            hideButton.StateCheckedTracking.Back.Image = (Image)resources.GetObject("hideButton.StateCheckedTracking.Back.Image");
            hideButton.StateCheckedTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            hideButton.StateCheckedTracking.Border.Color1 = Color.WhiteSmoke;
            hideButton.StateCheckedTracking.Border.Color2 = Color.WhiteSmoke;
            hideButton.StateCheckedTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            hideButton.StateCommon.Back.Color1 = Color.White;
            hideButton.StateCommon.Back.Color2 = Color.White;
            hideButton.StateCommon.Back.Image = (Image)resources.GetObject("hideButton.StateCommon.Back.Image");
            hideButton.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            hideButton.StateCommon.Border.Color1 = Color.White;
            hideButton.StateCommon.Border.Color2 = Color.White;
            hideButton.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            hideButton.StateCommon.Border.Rounding = 6F;
            hideButton.StatePressed.Back.Color1 = Color.WhiteSmoke;
            hideButton.StatePressed.Back.Color2 = Color.WhiteSmoke;
            hideButton.StatePressed.Border.Color1 = Color.WhiteSmoke;
            hideButton.StatePressed.Border.Color2 = Color.WhiteSmoke;
            hideButton.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            hideButton.StateTracking.Back.Color1 = Color.WhiteSmoke;
            hideButton.StateTracking.Back.Color2 = Color.WhiteSmoke;
            hideButton.StateTracking.Border.Color1 = Color.WhiteSmoke;
            hideButton.StateTracking.Border.Color2 = Color.WhiteSmoke;
            hideButton.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            hideButton.TabIndex = 9;
            hideButton.Values.Text = "";
            hideButton.Click += hideButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(hideButton);
            Controls.Add(invalidUsernamePasswordControl1);
            Controls.Add(btnLogin);
            Controls.Add(PassBox);
            Controls.Add(UserBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserBox;
        private TextBox PassBox;
        private Krypton.Toolkit.KryptonButton btnLogin;
        private InvalidUsernamePasswordControl invalidUsernamePasswordControl1;
        private Krypton.Toolkit.KryptonCheckButton hideButton;
    }
}