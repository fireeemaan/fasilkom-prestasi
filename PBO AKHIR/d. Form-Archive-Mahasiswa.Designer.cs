namespace fasilkom_prestasi
{
    partial class FormArchiveMahasiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArchiveMahasiswa));
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            kryptonComboBox2 = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(404, 296);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(483, 20);
            textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(404, 491);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(483, 20);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(959, 296);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(483, 20);
            textBox4.TabIndex = 3;
            // 
            // kryptonComboBox1
            // 
            kryptonComboBox1.DropDownWidth = 490;
            kryptonComboBox1.IntegralHeight = false;
            kryptonComboBox1.Location = new Point(404, 391);
            kryptonComboBox1.Name = "kryptonComboBox1";
            kryptonComboBox1.Size = new Size(483, 25);
            kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonComboBox1.TabIndex = 4;
            kryptonComboBox1.Text = "kryptonComboBox1";
            // 
            // kryptonComboBox2
            // 
            kryptonComboBox2.DropDownWidth = 490;
            kryptonComboBox2.IntegralHeight = false;
            kryptonComboBox2.Location = new Point(959, 391);
            kryptonComboBox2.Name = "kryptonComboBox2";
            kryptonComboBox2.Size = new Size(483, 25);
            kryptonComboBox2.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonComboBox2.TabIndex = 5;
            kryptonComboBox2.Text = "kryptonComboBox2";
            // 
            // FormArchiveMahasiswa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(kryptonComboBox2);
            Controls.Add(kryptonComboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Name = "FormArchiveMahasiswa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormArchiveMahasiswa";
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox2;
    }
}