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
            checkBox1 = new CheckBox();
            invalidUsernamePasswordControl1 = new InvalidUsernamePasswordControl();
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
            PassBox.Size = new Size(487, 27);
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(1338, 601);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
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
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(invalidUsernamePasswordControl1);
            Controls.Add(checkBox1);
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
        private CheckBox checkBox1;
        private InvalidUsernamePasswordControl invalidUsernamePasswordControl1;
    }
}