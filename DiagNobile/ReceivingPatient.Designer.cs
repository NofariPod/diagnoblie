namespace DiagNobile
{
    partial class ReceivingPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceivingPatient));
            this.PatientLastNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PatientIdLabel = new MetroFramework.Controls.MetroLabel();
            this.AgeLabel = new MetroFramework.Controls.MetroLabel();
            this.PatientIdInput = new MetroFramework.Controls.MetroTextBox();
            this.PatientFirstNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PatientFullNameLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.ViewDataButton = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.DateLabel = new MetroFramework.Controls.MetroLabel();
            this.TimeLabel = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientLastNameTextBox
            // 
            this.PatientLastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.PatientLastNameTextBox.CustomButton.Image = null;
            this.PatientLastNameTextBox.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.PatientLastNameTextBox.CustomButton.Name = "";
            this.PatientLastNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PatientLastNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PatientLastNameTextBox.CustomButton.TabIndex = 1;
            this.PatientLastNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PatientLastNameTextBox.CustomButton.UseSelectable = true;
            this.PatientLastNameTextBox.CustomButton.Visible = false;
            this.PatientLastNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PatientLastNameTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.PatientLastNameTextBox.Lines = new string[0];
            this.PatientLastNameTextBox.Location = new System.Drawing.Point(18, 76);
            this.PatientLastNameTextBox.MaxLength = 32767;
            this.PatientLastNameTextBox.Name = "PatientLastNameTextBox";
            this.PatientLastNameTextBox.PasswordChar = '\0';
            this.PatientLastNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PatientLastNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PatientLastNameTextBox.SelectedText = "";
            this.PatientLastNameTextBox.SelectionLength = 0;
            this.PatientLastNameTextBox.SelectionStart = 0;
            this.PatientLastNameTextBox.ShortcutsEnabled = true;
            this.PatientLastNameTextBox.Size = new System.Drawing.Size(145, 23);
            this.PatientLastNameTextBox.TabIndex = 38;
            this.PatientLastNameTextBox.UseSelectable = true;
            this.PatientLastNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PatientLastNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PatientIdLabel
            // 
            this.PatientIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientIdLabel.AutoSize = true;
            this.PatientIdLabel.Location = new System.Drawing.Point(581, 60);
            this.PatientIdLabel.Name = "PatientIdLabel";
            this.PatientIdLabel.Size = new System.Drawing.Size(77, 19);
            this.PatientIdLabel.TabIndex = 37;
            this.PatientIdLabel.Text = "תעודת זהות";
            this.PatientIdLabel.Click += new System.EventHandler(this.PatientIdLabel_Click);
            // 
            // AgeLabel
            // 
            this.AgeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(185, 115);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(76, 19);
            this.AgeLabel.TabIndex = 35;
            this.AgeLabel.Text = "תאריך לידה";
            // 
            // PatientIdInput
            // 
            this.PatientIdInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.PatientIdInput.CustomButton.Image = null;
            this.PatientIdInput.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.PatientIdInput.CustomButton.Name = "";
            this.PatientIdInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PatientIdInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PatientIdInput.CustomButton.TabIndex = 1;
            this.PatientIdInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PatientIdInput.CustomButton.UseSelectable = true;
            this.PatientIdInput.CustomButton.Visible = false;
            this.PatientIdInput.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PatientIdInput.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.PatientIdInput.Lines = new string[0];
            this.PatientIdInput.Location = new System.Drawing.Point(430, 60);
            this.PatientIdInput.MaxLength = 32767;
            this.PatientIdInput.Name = "PatientIdInput";
            this.PatientIdInput.PasswordChar = '\0';
#pragma warning disable CS0618 // 'MetroTextBox.PromptText' is obsolete: 'Use watermark'
            this.PatientIdInput.PromptText = "הכנס ת.ז מטופל";
#pragma warning restore CS0618 // 'MetroTextBox.PromptText' is obsolete: 'Use watermark'
            this.PatientIdInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PatientIdInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PatientIdInput.SelectedText = "";
            this.PatientIdInput.SelectionLength = 0;
            this.PatientIdInput.SelectionStart = 0;
            this.PatientIdInput.ShortcutsEnabled = true;
            this.PatientIdInput.Size = new System.Drawing.Size(145, 23);
            this.PatientIdInput.TabIndex = 33;
            this.PatientIdInput.UseSelectable = true;
            this.PatientIdInput.WaterMark = "הכנס ת.ז מטופל";
            this.PatientIdInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PatientIdInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PatientIdInput.Click += new System.EventHandler(this.PatientIdInput_Click);
            // 
            // PatientFirstNameTextBox
            // 
            this.PatientFirstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.PatientFirstNameTextBox.CustomButton.Image = null;
            this.PatientFirstNameTextBox.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.PatientFirstNameTextBox.CustomButton.Name = "";
            this.PatientFirstNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PatientFirstNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PatientFirstNameTextBox.CustomButton.TabIndex = 1;
            this.PatientFirstNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PatientFirstNameTextBox.CustomButton.UseSelectable = true;
            this.PatientFirstNameTextBox.CustomButton.Visible = false;
            this.PatientFirstNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PatientFirstNameTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.PatientFirstNameTextBox.Lines = new string[0];
            this.PatientFirstNameTextBox.Location = new System.Drawing.Point(18, 37);
            this.PatientFirstNameTextBox.MaxLength = 32767;
            this.PatientFirstNameTextBox.Name = "PatientFirstNameTextBox";
            this.PatientFirstNameTextBox.PasswordChar = '\0';
            this.PatientFirstNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PatientFirstNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PatientFirstNameTextBox.SelectedText = "";
            this.PatientFirstNameTextBox.SelectionLength = 0;
            this.PatientFirstNameTextBox.SelectionStart = 0;
            this.PatientFirstNameTextBox.ShortcutsEnabled = true;
            this.PatientFirstNameTextBox.Size = new System.Drawing.Size(145, 23);
            this.PatientFirstNameTextBox.TabIndex = 36;
            this.PatientFirstNameTextBox.UseSelectable = true;
            this.PatientFirstNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PatientFirstNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PatientFirstNameTextBox.Click += new System.EventHandler(this.PatientFullNameTextBox_Click);
            // 
            // PatientFullNameLabel
            // 
            this.PatientFullNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PatientFullNameLabel.AutoSize = true;
            this.PatientFullNameLabel.Location = new System.Drawing.Point(199, 37);
            this.PatientFullNameLabel.Name = "PatientFullNameLabel";
            this.PatientFullNameLabel.Size = new System.Drawing.Size(62, 19);
            this.PatientFullNameLabel.TabIndex = 34;
            this.PatientFullNameLabel.Text = "שם פרטי";
            this.PatientFullNameLabel.Click += new System.EventHandler(this.PatientFullNameLabel_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(181, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 39;
            this.metroLabel1.Text = "שם משפחה";
            // 
            // DOB
            // 
            this.DOB.CustomFormat = "dd-MM-yyyy";
            this.DOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOB.Location = new System.Drawing.Point(18, 115);
            this.DOB.Name = "DOB";
            this.DOB.RightToLeftLayout = true;
            this.DOB.Size = new System.Drawing.Size(145, 22);
            this.DOB.TabIndex = 78;
            this.DOB.Value = new System.DateTime(2018, 7, 31, 21, 21, 27, 0);
            this.DOB.ValueChanged += new System.EventHandler(this.DOB_ValueChanged);
            // 
            // ViewDataButton
            // 
            this.ViewDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewDataButton.Location = new System.Drawing.Point(349, 60);
            this.ViewDataButton.Name = "ViewDataButton";
            this.ViewDataButton.Size = new System.Drawing.Size(75, 23);
            this.ViewDataButton.TabIndex = 79;
            this.ViewDataButton.Text = "קבל מטופל";
            this.ViewDataButton.UseSelectable = true;
            this.ViewDataButton.Click += new System.EventHandler(this.ViewDataButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.PatientFullNameLabel);
            this.groupBox1.Controls.Add(this.DOB);
            this.groupBox1.Controls.Add(this.AgeLabel);
            this.groupBox1.Controls.Add(this.PatientFirstNameTextBox);
            this.groupBox1.Controls.Add(this.PatientLastNameTextBox);
            this.groupBox1.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(379, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(279, 175);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "פרטים אישיים";
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(225, 246);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(148, 23);
            this.metroButton1.TabIndex = 81;
            this.metroButton1.Text = "הכנס למערכת וקבל מטופל";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.DateLabel.Location = new System.Drawing.Point(7, 14);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(48, 19);
            this.DateLabel.TabIndex = 83;
            this.DateLabel.Text = "תאריך";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.TimeLabel.Location = new System.Drawing.Point(93, 14);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(37, 19);
            this.TimeLabel.TabIndex = 82;
            this.TimeLabel.Text = "שעה";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReceivingPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 291);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ViewDataButton);
            this.Controls.Add(this.PatientIdLabel);
            this.Controls.Add(this.PatientIdInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReceivingPatient";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "קבלת מטופל";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Load += new System.EventHandler(this.ReceivingPatient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox PatientLastNameTextBox;
        private MetroFramework.Controls.MetroLabel PatientIdLabel;
        private MetroFramework.Controls.MetroLabel AgeLabel;
        private MetroFramework.Controls.MetroTextBox PatientIdInput;
        private MetroFramework.Controls.MetroTextBox PatientFirstNameTextBox;
        private MetroFramework.Controls.MetroLabel PatientFullNameLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DateTimePicker DOB;
        private MetroFramework.Controls.MetroButton ViewDataButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel DateLabel;
        private MetroFramework.Controls.MetroLabel TimeLabel;
    }
}