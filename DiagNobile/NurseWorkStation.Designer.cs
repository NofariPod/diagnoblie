namespace DiagNobile
{
    partial class NurseWorkStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NurseWorkStation));
            this.button10 = new System.Windows.Forms.Button();
            this.metroButton10 = new MetroFramework.Controls.MetroButton();
            this.OpenTreatmentTile = new MetroFramework.Controls.MetroTile();
            this.TimeLabel = new MetroFramework.Controls.MetroLabel();
            this.DateLabel = new MetroFramework.Controls.MetroLabel();
            this.CurrentUserNameLabel = new MetroFramework.Controls.MetroLabel();
            this.SpecificPatientStatusTile = new MetroFramework.Controls.MetroTile();
            this.SeeExaminatorsTile5 = new MetroFramework.Controls.MetroTile();
            this.PatientsStatusTile = new MetroFramework.Controls.MetroTile();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button10.Location = new System.Drawing.Point(-149, 509);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(133, 43);
            this.button10.TabIndex = 22;
            this.button10.Text = "יציאה";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // metroButton10
            // 
            this.metroButton10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton10.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton10.Location = new System.Drawing.Point(209, 382);
            this.metroButton10.Name = "metroButton10";
            this.metroButton10.Size = new System.Drawing.Size(133, 34);
            this.metroButton10.TabIndex = 37;
            this.metroButton10.Text = "יציאה";
            this.metroButton10.UseSelectable = true;
            this.metroButton10.Click += new System.EventHandler(this.Exit);
            // 
            // OpenTreatmentTile
            // 
            this.OpenTreatmentTile.ActiveControl = null;
            this.OpenTreatmentTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpenTreatmentTile.Location = new System.Drawing.Point(278, 108);
            this.OpenTreatmentTile.Name = "OpenTreatmentTile";
            this.OpenTreatmentTile.Size = new System.Drawing.Size(141, 109);
            this.OpenTreatmentTile.Style = MetroFramework.MetroColorStyle.Black;
            this.OpenTreatmentTile.TabIndex = 66;
            this.OpenTreatmentTile.Text = "בדיקת מטופלים";
            this.OpenTreatmentTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OpenTreatmentTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.OpenTreatmentTile.UseSelectable = true;
            this.OpenTreatmentTile.Click += new System.EventHandler(this.OpenTreatmentTile_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Location = new System.Drawing.Point(496, 454);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(37, 19);
            this.TimeLabel.TabIndex = 58;
            this.TimeLabel.Text = "שעה";
            this.TimeLabel.UseCustomBackColor = true;
            this.TimeLabel.UseCustomForeColor = true;
            // 
            // DateLabel
            // 
            this.DateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Location = new System.Drawing.Point(402, 454);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(46, 19);
            this.DateLabel.TabIndex = 59;
            this.DateLabel.Text = "תאריך";
            this.DateLabel.UseCustomBackColor = true;
            this.DateLabel.UseCustomForeColor = true;
            // 
            // CurrentUserNameLabel
            // 
            this.CurrentUserNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentUserNameLabel.AutoSize = true;
            this.CurrentUserNameLabel.Location = new System.Drawing.Point(425, 72);
            this.CurrentUserNameLabel.Name = "CurrentUserNameLabel";
            this.CurrentUserNameLabel.Size = new System.Drawing.Size(110, 38);
            this.CurrentUserNameLabel.TabIndex = 61;
            this.CurrentUserNameLabel.Text = "___________ שלום\r\n";
            this.CurrentUserNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CurrentUserNameLabel.Click += new System.EventHandler(this.CurrentUserNameLabel_Click);
            // 
            // SpecificPatientStatusTile
            // 
            this.SpecificPatientStatusTile.ActiveControl = null;
            this.SpecificPatientStatusTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SpecificPatientStatusTile.Location = new System.Drawing.Point(132, 223);
            this.SpecificPatientStatusTile.Name = "SpecificPatientStatusTile";
            this.SpecificPatientStatusTile.Size = new System.Drawing.Size(141, 109);
            this.SpecificPatientStatusTile.Style = MetroFramework.MetroColorStyle.Black;
            this.SpecificPatientStatusTile.TabIndex = 63;
            this.SpecificPatientStatusTile.Text = "תיק רפואי מטופל";
            this.SpecificPatientStatusTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SpecificPatientStatusTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.SpecificPatientStatusTile.UseSelectable = true;
            this.SpecificPatientStatusTile.Click += new System.EventHandler(this.SpecificPatientStatusTile_Click);
            // 
            // SeeExaminatorsTile5
            // 
            this.SeeExaminatorsTile5.ActiveControl = null;
            this.SeeExaminatorsTile5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SeeExaminatorsTile5.Location = new System.Drawing.Point(279, 223);
            this.SeeExaminatorsTile5.Name = "SeeExaminatorsTile5";
            this.SeeExaminatorsTile5.Size = new System.Drawing.Size(140, 109);
            this.SeeExaminatorsTile5.Style = MetroFramework.MetroColorStyle.Black;
            this.SeeExaminatorsTile5.TabIndex = 64;
            this.SeeExaminatorsTile5.Text = "בדיקות";
            this.SeeExaminatorsTile5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SeeExaminatorsTile5.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.SeeExaminatorsTile5.UseSelectable = true;
            this.SeeExaminatorsTile5.Click += new System.EventHandler(this.SeeExaminatorsTile5_Click);
            // 
            // PatientsStatusTile
            // 
            this.PatientsStatusTile.ActiveControl = null;
            this.PatientsStatusTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PatientsStatusTile.Location = new System.Drawing.Point(131, 108);
            this.PatientsStatusTile.Name = "PatientsStatusTile";
            this.PatientsStatusTile.Size = new System.Drawing.Size(140, 109);
            this.PatientsStatusTile.Style = MetroFramework.MetroColorStyle.Black;
            this.PatientsStatusTile.TabIndex = 65;
            this.PatientsStatusTile.Text = "מצב מטופלים";
            this.PatientsStatusTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PatientsStatusTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.PatientsStatusTile.UseSelectable = true;
            this.PatientsStatusTile.Click += new System.EventHandler(this.PatientsStatusTile_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(209, 342);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(133, 34);
            this.metroButton1.TabIndex = 68;
            this.metroButton1.Text = "קבלת לקוח";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 63);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 58);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 168;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseHover += new System.EventHandler(this.ShowHoverText);
            // 
            // NurseWorkStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(550, 490);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.OpenTreatmentTile);
            this.Controls.Add(this.PatientsStatusTile);
            this.Controls.Add(this.SeeExaminatorsTile5);
            this.Controls.Add(this.SpecificPatientStatusTile);
            this.Controls.Add(this.CurrentUserNameLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.metroButton10);
            this.Controls.Add(this.button10);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "NurseWorkStation";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "מסך ראשי - אח/ות";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.NurseWorkStation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button button10;
        private MetroFramework.Controls.MetroButton metroButton10;
        private MetroFramework.Controls.MetroTile OpenTreatmentTile;
        private MetroFramework.Controls.MetroLabel TimeLabel;
        private MetroFramework.Controls.MetroLabel DateLabel;
        private MetroFramework.Controls.MetroLabel CurrentUserNameLabel;
        private MetroFramework.Controls.MetroTile SpecificPatientStatusTile;
        private MetroFramework.Controls.MetroTile SeeExaminatorsTile5;
        private MetroFramework.Controls.MetroTile PatientsStatusTile;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}



