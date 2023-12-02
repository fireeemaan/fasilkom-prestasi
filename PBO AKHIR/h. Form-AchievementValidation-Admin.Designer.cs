namespace fasilkom_prestasi
{
    partial class Form_AchievementValidation_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AchievementValidation_Admin));
            textBox5 = new TextBox();
            rbtnInvalid = new RadioButton();
            rbtnValid = new RadioButton();
            tbxNamaLomba = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            btnSaveValidation = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(426, 327);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(993, 20);
            textBox5.TabIndex = 8;
            // 
            // rbtnInvalid
            // 
            rbtnInvalid.AutoSize = true;
            rbtnInvalid.Location = new Point(658, 251);
            rbtnInvalid.Name = "rbtnInvalid";
            rbtnInvalid.Size = new Size(17, 16);
            rbtnInvalid.TabIndex = 7;
            rbtnInvalid.TabStop = true;
            rbtnInvalid.UseVisualStyleBackColor = true;
            // 
            // rbtnValid
            // 
            rbtnValid.AutoSize = true;
            rbtnValid.Location = new Point(512, 251);
            rbtnValid.Name = "rbtnValid";
            rbtnValid.Size = new Size(17, 16);
            rbtnValid.TabIndex = 6;
            rbtnValid.TabStop = true;
            rbtnValid.UseVisualStyleBackColor = true;
            // 
            // tbxNamaLomba
            // 
            tbxNamaLomba.BorderStyle = BorderStyle.None;
            tbxNamaLomba.Location = new Point(404, 419);
            tbxNamaLomba.Name = "tbxNamaLomba";
            tbxNamaLomba.ReadOnly = true;
            tbxNamaLomba.Size = new Size(483, 20);
            tbxNamaLomba.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(959, 419);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(483, 20);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(959, 516);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(483, 20);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(404, 516);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(483, 20);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(959, 613);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(483, 20);
            textBox4.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(404, 613);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(483, 20);
            textBox6.TabIndex = 13;
            // 
            // btnSaveValidation
            // 
            btnSaveValidation.CornerRoundingRadius = 30F;
            btnSaveValidation.Location = new Point(797, 687);
            btnSaveValidation.Margin = new Padding(2);
            btnSaveValidation.MaximumSize = new Size(248, 47);
            btnSaveValidation.MinimumSize = new Size(248, 47);
            btnSaveValidation.Name = "btnSaveValidation";
            btnSaveValidation.OverrideDefault.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnSaveValidation.OverrideDefault.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnSaveValidation.OverrideFocus.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnSaveValidation.OverrideFocus.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnSaveValidation.Size = new Size(248, 47);
            btnSaveValidation.StateCommon.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnSaveValidation.StateCommon.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnSaveValidation.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSaveValidation.StateCommon.Border.Rounding = 30F;
            btnSaveValidation.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSaveValidation.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSaveValidation.StateCommon.Content.ShortText.Font = new Font("Poppins ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveValidation.StateNormal.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnSaveValidation.StateNormal.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnSaveValidation.StatePressed.Back.Color1 = Color.FromArgb(128, 167, 255);
            btnSaveValidation.StatePressed.Back.Color2 = Color.FromArgb(128, 167, 255);
            btnSaveValidation.TabIndex = 23;
            btnSaveValidation.Values.Text = "Save Changes";
            btnSaveValidation.Click += btnSaveValidation_Click;
            // 
            // Form_AchievementValidation_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(btnSaveValidation);
            Controls.Add(textBox4);
            Controls.Add(textBox6);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(tbxNamaLomba);
            Controls.Add(textBox5);
            Controls.Add(rbtnInvalid);
            Controls.Add(rbtnValid);
            Name = "Form_AchievementValidation_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_AchievementValidation_Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private RadioButton rbtnInvalid;
        private RadioButton rbtnValid;
        private TextBox tbxNamaLomba;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private Krypton.Toolkit.KryptonButton btnSaveValidation;
    }
}