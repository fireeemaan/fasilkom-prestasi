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
            DataValid = new RadioButton();
            DataInvalid = new RadioButton();
            textBox5 = new TextBox();
            kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DataValid
            // 
            DataValid.AutoSize = true;
            DataValid.Location = new Point(516, 249);
            DataValid.Name = "DataValid";
            DataValid.Size = new Size(17, 16);
            DataValid.TabIndex = 0;
            DataValid.TabStop = true;
            DataValid.UseVisualStyleBackColor = true;
            // 
            // DataInvalid
            // 
            DataInvalid.AutoSize = true;
            DataInvalid.Location = new Point(667, 249);
            DataInvalid.Name = "DataInvalid";
            DataInvalid.Size = new Size(17, 16);
            DataInvalid.TabIndex = 1;
            DataInvalid.TabStop = true;
            DataInvalid.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(426, 323);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(993, 20);
            textBox5.TabIndex = 5;
            // 
            // kryptonDataGridView1
            // 
            kryptonDataGridView1.BorderStyle = BorderStyle.None;
            kryptonDataGridView1.ColumnHeadersHeight = 36;
            kryptonDataGridView1.Location = new Point(338, 374);
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.RowHeadersWidth = 51;
            kryptonDataGridView1.RowTemplate.Height = 29;
            kryptonDataGridView1.Size = new Size(1170, 355);
            kryptonDataGridView1.TabIndex = 6;
            // 
            // Form_AchievementValidation_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(kryptonDataGridView1);
            Controls.Add(textBox5);
            Controls.Add(DataInvalid);
            Controls.Add(DataValid);
            Name = "Form_AchievementValidation_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_AchievementValidation_Admin";
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton DataValid;
        private RadioButton DataInvalid;
        private TextBox textBox5;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
    }
}