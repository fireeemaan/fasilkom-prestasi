namespace fasilkom_prestasi
{
    partial class _10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_10));
            textBox1 = new TextBox();
            kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(677, 532);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(491, 20);
            textBox1.TabIndex = 7;
            // 
            // kryptonDataGridView1
            // 
            kryptonDataGridView1.BorderStyle = BorderStyle.None;
            kryptonDataGridView1.ColumnHeadersHeight = 36;
            kryptonDataGridView1.Location = new Point(338, 227);
            kryptonDataGridView1.Name = "kryptonDataGridView1";
            kryptonDataGridView1.RowHeadersWidth = 51;
            kryptonDataGridView1.RowTemplate.Height = 29;
            kryptonDataGridView1.Size = new Size(1170, 182);
            kryptonDataGridView1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.ForeColor = Color.Transparent;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(677, 452);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(491, 28);
            comboBox1.TabIndex = 9;
            // 
            // _10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(comboBox1);
            Controls.Add(kryptonDataGridView1);
            Controls.Add(textBox1);
            Name = "_10";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_10";
            ((System.ComponentModel.ISupportInitialize)kryptonDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private ComboBox comboBox1;
    }
}