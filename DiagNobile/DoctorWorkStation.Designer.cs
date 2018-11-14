namespace DiagNobile
{
    partial class DoctorWorkStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorWorkStation));
            this.ExitButton = new MetroFramework.Controls.MetroButton();
            this.PatientHistoryTile = new MetroFramework.Controls.MetroTile();
            this.TestExaminatorsTile = new MetroFramework.Controls.MetroTile();
            this.SeeExaminatorsTile = new MetroFramework.Controls.MetroTile();
            this.PatientsStatusTile = new MetroFramework.Controls.MetroTile();
            this.ReportsTile = new MetroFramework.Controls.MetroTile();
            this.DateLabel = new MetroFramework.Controls.MetroLabel();
            this.TimeLabel = new MetroFramework.Controls.MetroLabel();
            this.CurrentUserNameLabel = new MetroFramework.Controls.MetroLabel();
            this.PatientGroupBox = new System.Windows.Forms.GroupBox();
            this.DepartmentGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.PatientGroupBox.SuspendLayout();
            this.DepartmentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ExitButton.Location = new System.Drawing.Point(39, 484);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(67, 34);
            this.ExitButton.TabIndex = 37;
            this.ExitButton.Text = "יציאה";
            this.ExitButton.UseSelectable = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PatientHistoryTile
            // 
            this.PatientHistoryTile.ActiveControl = null;
            this.PatientHistoryTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientHistoryTile.BackColor = System.Drawing.Color.White;
            this.PatientHistoryTile.ForeColor = System.Drawing.Color.Black;
            this.PatientHistoryTile.Location = new System.Drawing.Point(189, 27);
            this.PatientHistoryTile.Name = "PatientHistoryTile";
            this.PatientHistoryTile.Size = new System.Drawing.Size(140, 109);
            this.PatientHistoryTile.TabIndex = 40;
            this.PatientHistoryTile.Text = "תיק רפואי מטופל";
            this.PatientHistoryTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PatientHistoryTile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PatientHistoryTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PatientHistoryTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.PatientHistoryTile.UseSelectable = true;
            this.PatientHistoryTile.Click += new System.EventHandler(this.PatientHistoryTile_Click);
            // 
            // TestExaminatorsTile
            // 
            this.TestExaminatorsTile.ActiveControl = null;
            this.TestExaminatorsTile.AutoSize = true;
            this.TestExaminatorsTile.Location = new System.Drawing.Point(335, 27);
            this.TestExaminatorsTile.Name = "TestExaminatorsTile";
            this.TestExaminatorsTile.Size = new System.Drawing.Size(145, 109);
            this.TestExaminatorsTile.TabIndex = 41;
            this.TestExaminatorsTile.Text = "בדיקת מטופלים";
            this.TestExaminatorsTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TestExaminatorsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TestExaminatorsTile.UseSelectable = true;
            this.TestExaminatorsTile.Click += new System.EventHandler(this.TestExaminatorsTile_Click);
            // 
            // SeeExaminatorsTile
            // 
            this.SeeExaminatorsTile.ActiveControl = null;
            this.SeeExaminatorsTile.AutoSize = true;
            this.SeeExaminatorsTile.Location = new System.Drawing.Point(105, 24);
            this.SeeExaminatorsTile.Name = "SeeExaminatorsTile";
            this.SeeExaminatorsTile.Size = new System.Drawing.Size(140, 109);
            this.SeeExaminatorsTile.TabIndex = 44;
            this.SeeExaminatorsTile.Text = "בדיקות";
            this.SeeExaminatorsTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SeeExaminatorsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.SeeExaminatorsTile.UseSelectable = true;
            this.SeeExaminatorsTile.Click += new System.EventHandler(this.SeeExaminatorsTile5_Click);
            // 
            // PatientsStatusTile
            // 
            this.PatientsStatusTile.ActiveControl = null;
            this.PatientsStatusTile.AutoSize = true;
            this.PatientsStatusTile.Location = new System.Drawing.Point(427, 24);
            this.PatientsStatusTile.Name = "PatientsStatusTile";
            this.PatientsStatusTile.Size = new System.Drawing.Size(140, 109);
            this.PatientsStatusTile.TabIndex = 45;
            this.PatientsStatusTile.Text = "מצב\r\nמטופלים";
            this.PatientsStatusTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PatientsStatusTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.PatientsStatusTile.UseSelectable = true;
            this.PatientsStatusTile.Click += new System.EventHandler(this.PatientsStatusTile_Click);
            // 
            // ReportsTile
            // 
            this.ReportsTile.ActiveControl = null;
            this.ReportsTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReportsTile.AutoSize = true;
            this.ReportsTile.BackColor = System.Drawing.Color.Black;
            this.ReportsTile.Location = new System.Drawing.Point(251, 24);
            this.ReportsTile.Name = "ReportsTile";
            this.ReportsTile.Size = new System.Drawing.Size(170, 109);
            this.ReportsTile.TabIndex = 46;
            this.ReportsTile.Text = "צפייה/הפקת דוחות";
            this.ReportsTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReportsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.ReportsTile.UseSelectable = true;
            this.ReportsTile.Click += new System.EventHandler(this.ReportsTile_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DateLabel.Location = new System.Drawing.Point(593, 484);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(46, 19);
            this.DateLabel.TabIndex = 51;
            this.DateLabel.Text = "תאריך";
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TimeLabel.Location = new System.Drawing.Point(675, 484);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(37, 19);
            this.TimeLabel.TabIndex = 50;
            this.TimeLabel.Text = "שעה";
            // 
            // CurrentUserNameLabel
            // 
            this.CurrentUserNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentUserNameLabel.AutoSize = true;
            this.CurrentUserNameLabel.Location = new System.Drawing.Point(565, 70);
            this.CurrentUserNameLabel.Name = "CurrentUserNameLabel";
            this.CurrentUserNameLabel.Size = new System.Drawing.Size(74, 19);
            this.CurrentUserNameLabel.TabIndex = 52;
            this.CurrentUserNameLabel.Text = "שלום _____";
            this.CurrentUserNameLabel.Click += new System.EventHandler(this.CurrentUserNameLabel_Click);
            // 
            // PatientGroupBox
            // 
            this.PatientGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PatientGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.PatientGroupBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PatientGroupBox.BackgroundImage")));
            this.PatientGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PatientGroupBox.Controls.Add(this.PatientHistoryTile);
            this.PatientGroupBox.Controls.Add(this.TestExaminatorsTile);
            this.PatientGroupBox.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PatientGroupBox.ForeColor = System.Drawing.Color.White;
            this.PatientGroupBox.Location = new System.Drawing.Point(39, 134);
            this.PatientGroupBox.Name = "PatientGroupBox";
            this.PatientGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PatientGroupBox.Size = new System.Drawing.Size(673, 160);
            this.PatientGroupBox.TabIndex = 70;
            this.PatientGroupBox.TabStop = false;
            this.PatientGroupBox.Text = "ניהול מטופל";
            // 
            // DepartmentGroupBox
            // 
            this.DepartmentGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DepartmentGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DepartmentGroupBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DepartmentGroupBox.BackgroundImage")));
            this.DepartmentGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DepartmentGroupBox.Controls.Add(this.PatientsStatusTile);
            this.DepartmentGroupBox.Controls.Add(this.ReportsTile);
            this.DepartmentGroupBox.Controls.Add(this.SeeExaminatorsTile);
            this.DepartmentGroupBox.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DepartmentGroupBox.ForeColor = System.Drawing.Color.White;
            this.DepartmentGroupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DepartmentGroupBox.Location = new System.Drawing.Point(39, 317);
            this.DepartmentGroupBox.Name = "DepartmentGroupBox";
            this.DepartmentGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DepartmentGroupBox.Size = new System.Drawing.Size(673, 157);
            this.DepartmentGroupBox.TabIndex = 71;
            this.DepartmentGroupBox.TabStop = false;
            this.DepartmentGroupBox.Text = "ניהול מחלקה";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(653, 70);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(59, 58);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 164;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.DoctorIcon_Click);
            this.pictureBox5.MouseHover += new System.EventHandler(this.ShowHoverText);
            // 
            // DoctorWorkStation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BackLocation = MetroFramework.Forms.BackLocation.TopRight;
            this.ClientSize = new System.Drawing.Size(755, 567);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.CurrentUserNameLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PatientGroupBox);
            this.Controls.Add(this.DepartmentGroupBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "DoctorWorkStation";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "מסך ראשי - רופא";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.DoctorWorkStation_Load);
            this.PatientGroupBox.ResumeLayout(false);
            this.PatientGroupBox.PerformLayout();
            this.DepartmentGroupBox.ResumeLayout(false);
            this.DepartmentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private MetroFramework.Controls.MetroButton ExitButton;
        private MetroFramework.Controls.MetroTile PatientHistoryTile;
        private MetroFramework.Controls.MetroTile TestExaminatorsTile;
        private MetroFramework.Controls.MetroTile SeeExaminatorsTile;
        private MetroFramework.Controls.MetroTile PatientsStatusTile;
        private MetroFramework.Controls.MetroTile ReportsTile;
        private MetroFramework.Controls.MetroLabel DateLabel;
        private MetroFramework.Controls.MetroLabel TimeLabel;
        private MetroFramework.Controls.MetroLabel CurrentUserNameLabel;
        private System.Windows.Forms.GroupBox PatientGroupBox;
        private System.Windows.Forms.GroupBox DepartmentGroupBox;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}



