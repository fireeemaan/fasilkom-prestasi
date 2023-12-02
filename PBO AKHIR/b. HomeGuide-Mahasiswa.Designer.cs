namespace fasilkom_prestasi
{
    partial class HomeGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeGuide));
            sidePanel = new Panel();
            btnHome = new Button();
            btnRecord = new Button();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(189, 209, 255);
            sidePanel.ForeColor = Color.White;
            sidePanel.Location = new Point(2, 122);
            sidePanel.Margin = new Padding(2);
            sidePanel.MaximumSize = new Size(8, 48);
            sidePanel.MinimumSize = new Size(8, 48);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(8, 48);
            sidePanel.TabIndex = 27;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.White;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(11, 122);
            btnHome.Margin = new Padding(2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(232, 48);
            btnHome.TabIndex = 26;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnRecord
            // 
            btnRecord.BackColor = Color.White;
            btnRecord.FlatAppearance.BorderSize = 0;
            btnRecord.FlatStyle = FlatStyle.Flat;
            btnRecord.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRecord.Image = (Image)resources.GetObject("btnRecord.Image");
            btnRecord.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecord.Location = new Point(11, 175);
            btnRecord.Margin = new Padding(2);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(232, 48);
            btnRecord.TabIndex = 28;
            btnRecord.Text = "Record";
            btnRecord.UseVisualStyleBackColor = false;
            btnRecord.Click += btnRecord_Click;
            // 
            // HomeGuide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1582, 853);
            Controls.Add(sidePanel);
            Controls.Add(btnHome);
            Controls.Add(btnRecord);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "HomeGuide";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Guide";
            Load += HomeGuide_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Button btnHome;
        private Button btnRecord;
    }
}