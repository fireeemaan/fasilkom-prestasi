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
            kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).BeginInit();
            SuspendLayout();
            // 
            // kryptonDataGridView1
            // 
            kryptonDataGridView1.BorderStyle = BorderStyle.None;
            kryptonDataGridView1.ColumnHeadersHeight = 36;
            kryptonDataGridView1.Location = new Point(338, 227);
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.RowHeadersWidth = 51;
            kryptonDataGridView1.RowTemplate.Height = 29;
            kryptonDataGridView1.Size = new Size(1170, 184);
            kryptonDataGridView1.TabIndex = 2;
            // 
            // kryptonComboBox1
            // 
            kryptonComboBox1.DropDownWidth = 490;
            kryptonComboBox1.IntegralHeight = false;
            kryptonComboBox1.Location = new Point(681, 457);
            kryptonComboBox1.Name = "kryptonComboBox1";
            kryptonComboBox1.Size = new Size(483, 25);
            kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonComboBox1.TabIndex = 5;
            kryptonComboBox1.Text = "kryptonComboBox1";
            // 
            // Form_Convertion_Mahasiswa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(kryptonComboBox1);
            Controls.Add(kryptonDataGridView1);
            Name = "Form_Convertion_Mahasiswa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Convertion_Mahasiswa";
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
    }
}