namespace fasilkom_prestasi
{
    partial class Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Record));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            sidePanel = new Panel();
            btnHome = new Button();
            btnRecord = new Button();
            panel1 = new Panel();
            btnConvertion = new Krypton.Toolkit.KryptonButton();
            btnAddAchievement = new Krypton.Toolkit.KryptonButton();
            dgvPrestasi = new Krypton.Toolkit.KryptonDataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestasi).BeginInit();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.ForeColor = Color.White;
            sidePanel.Location = new Point(1, 178);
            sidePanel.MaximumSize = new Size(10, 58);
            sidePanel.MinimumSize = new Size(10, 58);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(10, 58);
            sidePanel.TabIndex = 2;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.White;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(12, 114);
            btnHome.MaximumSize = new Size(234, 58);
            btnHome.MinimumSize = new Size(234, 58);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(234, 58);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnRecord
            // 
            btnRecord.BackColor = Color.White;
            btnRecord.FlatAppearance.BorderSize = 0;
            btnRecord.FlatStyle = FlatStyle.Flat;
            btnRecord.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRecord.Image = (Image)resources.GetObject("btnRecord.Image");
            btnRecord.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecord.Location = new Point(12, 178);
            btnRecord.MaximumSize = new Size(234, 58);
            btnRecord.MinimumSize = new Size(234, 58);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(234, 58);
            btnRecord.TabIndex = 2;
            btnRecord.Text = "Record";
            btnRecord.UseVisualStyleBackColor = false;
            btnRecord.Click += btnRecord_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(btnConvertion);
            panel1.Controls.Add(btnAddAchievement);
            panel1.Controls.Add(dgvPrestasi);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnRecord);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1578, 844);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // btnConvertion
            // 
            btnConvertion.Location = new Point(1203, 143);
            btnConvertion.MaximumSize = new Size(249, 67);
            btnConvertion.MinimumSize = new Size(249, 67);
            btnConvertion.Name = "btnConvertion";
            btnConvertion.OverrideDefault.Back.Color1 = Color.White;
            btnConvertion.OverrideDefault.Back.Color2 = Color.White;
            btnConvertion.OverrideDefault.Back.Image = (Image)resources.GetObject("btnConvertion.OverrideDefault.Back.Image");
            btnConvertion.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnConvertion.OverrideDefault.Border.Color1 = Color.White;
            btnConvertion.OverrideDefault.Border.Color2 = Color.White;
            btnConvertion.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConvertion.OverrideFocus.Back.Color1 = Color.WhiteSmoke;
            btnConvertion.OverrideFocus.Back.Color2 = Color.WhiteSmoke;
            btnConvertion.OverrideFocus.Back.Image = (Image)resources.GetObject("btnConvertion.OverrideFocus.Back.Image");
            btnConvertion.OverrideFocus.Border.Color1 = Color.WhiteSmoke;
            btnConvertion.OverrideFocus.Border.Color2 = Color.WhiteSmoke;
            btnConvertion.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConvertion.Size = new Size(249, 67);
            btnConvertion.StateCommon.Back.Color1 = Color.White;
            btnConvertion.StateCommon.Back.Color2 = Color.White;
            btnConvertion.StateCommon.Back.Image = (Image)resources.GetObject("btnConvertion.StateCommon.Back.Image");
            btnConvertion.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnConvertion.StateCommon.Border.Color1 = Color.White;
            btnConvertion.StateCommon.Border.Color2 = Color.White;
            btnConvertion.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConvertion.StateTracking.Back.Color1 = Color.WhiteSmoke;
            btnConvertion.StateTracking.Back.Color2 = Color.WhiteSmoke;
            btnConvertion.StateTracking.Back.Image = (Image)resources.GetObject("btnConvertion.StateTracking.Back.Image");
            btnConvertion.TabIndex = 5;
            btnConvertion.Values.Text = "";
            // 
            // btnAddAchievement
            // 
            btnAddAchievement.Location = new Point(948, 143);
            btnAddAchievement.MaximumSize = new Size(249, 67);
            btnAddAchievement.MinimumSize = new Size(249, 67);
            btnAddAchievement.Name = "btnAddAchievement";
            btnAddAchievement.OverrideDefault.Back.Color1 = Color.White;
            btnAddAchievement.OverrideDefault.Back.Color2 = Color.White;
            btnAddAchievement.OverrideDefault.Back.Image = (Image)resources.GetObject("btnAddAchievement.OverrideDefault.Back.Image");
            btnAddAchievement.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAddAchievement.OverrideDefault.Border.Color1 = Color.White;
            btnAddAchievement.OverrideDefault.Border.Color2 = Color.White;
            btnAddAchievement.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddAchievement.OverrideFocus.Back.Color1 = Color.WhiteSmoke;
            btnAddAchievement.OverrideFocus.Back.Color2 = Color.WhiteSmoke;
            btnAddAchievement.OverrideFocus.Back.Image = (Image)resources.GetObject("btnAddAchievement.OverrideFocus.Back.Image");
            btnAddAchievement.OverrideFocus.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAddAchievement.OverrideFocus.Border.Color1 = Color.WhiteSmoke;
            btnAddAchievement.OverrideFocus.Border.Color2 = Color.WhiteSmoke;
            btnAddAchievement.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddAchievement.Size = new Size(249, 67);
            btnAddAchievement.StateCommon.Back.Color1 = Color.White;
            btnAddAchievement.StateCommon.Back.Color2 = Color.White;
            btnAddAchievement.StateCommon.Back.Image = (Image)resources.GetObject("btnAddAchievement.StateCommon.Back.Image");
            btnAddAchievement.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            btnAddAchievement.StateCommon.Border.Color1 = Color.White;
            btnAddAchievement.StateCommon.Border.Color2 = Color.White;
            btnAddAchievement.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAddAchievement.StateTracking.Back.Color1 = Color.WhiteSmoke;
            btnAddAchievement.StateTracking.Back.Color2 = Color.WhiteSmoke;
            btnAddAchievement.StateTracking.Back.Image = (Image)resources.GetObject("btnAddAchievement.StateTracking.Back.Image");
            btnAddAchievement.TabIndex = 4;
            btnAddAchievement.Values.Text = "";
            btnAddAchievement.Click += btnAddAchievement_Click;
            // 
            // dgvPrestasi
            // 
            dgvPrestasi.AllowUserToAddRows = false;
            dgvPrestasi.AllowUserToDeleteRows = false;
            dgvPrestasi.AllowUserToResizeColumns = false;
            dgvPrestasi.AllowUserToResizeRows = false;
            dgvPrestasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestasi.BorderStyle = BorderStyle.None;
            dgvPrestasi.ColumnHeadersHeight = 51;
            dgvPrestasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPrestasi.Location = new Point(337, 216);
            dgvPrestasi.MaximumSize = new Size(1170, 571);
            dgvPrestasi.Name = "dgvPrestasi";
            dgvPrestasi.ReadOnly = true;
            dgvPrestasi.RowHeadersVisible = false;
            dgvPrestasi.RowHeadersWidth = 62;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrestasi.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPrestasi.RowTemplate.Height = 50;
            dgvPrestasi.Size = new Size(1170, 565);
            dgvPrestasi.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvPrestasi.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom;
            dgvPrestasi.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvPrestasi.StateSelected.DataCell.Back.Color1 = Color.White;
            dgvPrestasi.StateSelected.DataCell.Back.Color2 = Color.White;
            dgvPrestasi.TabIndex = 3;
            dgvPrestasi.TabStop = false;
            // 
            // Record
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(189, 209, 255);
            ClientSize = new Size(1578, 844);
            Controls.Add(sidePanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(1600, 900);
            MinimumSize = new Size(1600, 900);
            Name = "Record";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Archive";
            Load += Record_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrestasi).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel sidePanel;
        private Button btnHome;
        private Button btnRecord;
        private Panel panel1;
        private Krypton.Toolkit.KryptonDataGridView dgvPrestasi;
        private Krypton.Toolkit.KryptonButton btnConvertion;
        private Krypton.Toolkit.KryptonButton btnAddAchievement;
    }
}