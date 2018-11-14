namespace DiagNobile
{
    partial class AllPatients
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllPatients));
            this.AllPatientsGrid = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnobile_DatabaseDataSet = new DiagNobile.Diagnobile_DatabaseDataSet();
            this.patientsTableAdapter = new DiagNobile.Diagnobile_DatabaseDataSetTableAdapters.PatientsTableAdapter();
            this.ReceivedPatientsLabel = new MetroFramework.Controls.MetroLabel();
            this.PatientsInTreatmentLabel = new MetroFramework.Controls.MetroLabel();
            this.ReleasedPatientsLabel = new MetroFramework.Controls.MetroLabel();
            this.ReceivedPatientsSum = new MetroFramework.Controls.MetroLabel();
            this.PatientsInTreatmentSum = new MetroFramework.Controls.MetroLabel();
            this.ReleasedPatientsSum = new MetroFramework.Controls.MetroLabel();
            this.DateLabel = new MetroFramework.Controls.MetroLabel();
            this.TimeLabel = new MetroFramework.Controls.MetroLabel();
            this.FilterPatientButton = new MetroFramework.Controls.MetroButton();
            this.EnterIdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroButton10 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.AllPatientsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnobile_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // AllPatientsGrid
            // 
            this.AllPatientsGrid.AllowUserToOrderColumns = true;
            this.AllPatientsGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.AllPatientsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AllPatientsGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AllPatientsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AllPatientsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AllPatientsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AllPatientsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AllPatientsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.AllPatientsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllPatientsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AllPatientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllPatientsGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.AllPatientsGrid.EnableHeadersVisualStyles = false;
            this.AllPatientsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AllPatientsGrid.GridColor = System.Drawing.Color.Black;
            this.AllPatientsGrid.Location = new System.Drawing.Point(200, 178);
            this.AllPatientsGrid.Name = "AllPatientsGrid";
            this.AllPatientsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AllPatientsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllPatientsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.AllPatientsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllPatientsGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.AllPatientsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllPatientsGrid.Size = new System.Drawing.Size(779, 405);
            this.AllPatientsGrid.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "תעודת זהות";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "שם פרטי";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "שם משפחה";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle6.Format = "T";
            dataGridViewCellStyle6.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "שעת קבלה";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column5.FillWeight = 150F;
            this.Column5.HeaderText = "סטטוס טיפול";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.diagnobile_DatabaseDataSet;
            // 
            // diagnobile_DatabaseDataSet
            // 
            this.diagnobile_DatabaseDataSet.DataSetName = "Diagnobile_DatabaseDataSet";
            this.diagnobile_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // ReceivedPatientsLabel
            // 
            this.ReceivedPatientsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReceivedPatientsLabel.AutoSize = true;
            this.ReceivedPatientsLabel.Location = new System.Drawing.Point(818, 593);
            this.ReceivedPatientsLabel.Name = "ReceivedPatientsLabel";
            this.ReceivedPatientsLabel.Size = new System.Drawing.Size(161, 19);
            this.ReceivedPatientsLabel.TabIndex = 1;
            this.ReceivedPatientsLabel.Text = "מספר מטופלים שהתקבלו";
            // 
            // PatientsInTreatmentLabel
            // 
            this.PatientsInTreatmentLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PatientsInTreatmentLabel.AutoSize = true;
            this.PatientsInTreatmentLabel.Location = new System.Drawing.Point(787, 627);
            this.PatientsInTreatmentLabel.Name = "PatientsInTreatmentLabel";
            this.PatientsInTreatmentLabel.Size = new System.Drawing.Size(192, 19);
            this.PatientsInTreatmentLabel.TabIndex = 2;
            this.PatientsInTreatmentLabel.Text = "מספר המטופלים הכולל בטיפול";
            // 
            // ReleasedPatientsLabel
            // 
            this.ReleasedPatientsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReleasedPatientsLabel.AutoSize = true;
            this.ReleasedPatientsLabel.Location = new System.Drawing.Point(823, 664);
            this.ReleasedPatientsLabel.Name = "ReleasedPatientsLabel";
            this.ReleasedPatientsLabel.Size = new System.Drawing.Size(156, 19);
            this.ReleasedPatientsLabel.TabIndex = 3;
            this.ReleasedPatientsLabel.Text = "מספר מטופלים ששוחררו";
            // 
            // ReceivedPatientsSum
            // 
            this.ReceivedPatientsSum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReceivedPatientsSum.AutoSize = true;
            this.ReceivedPatientsSum.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ReceivedPatientsSum.Location = new System.Drawing.Point(682, 593);
            this.ReceivedPatientsSum.Name = "ReceivedPatientsSum";
            this.ReceivedPatientsSum.Size = new System.Drawing.Size(27, 19);
            this.ReceivedPatientsSum.TabIndex = 68;
            this.ReceivedPatientsSum.Text = "???";
            this.ReceivedPatientsSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientsInTreatmentSum
            // 
            this.PatientsInTreatmentSum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PatientsInTreatmentSum.AutoSize = true;
            this.PatientsInTreatmentSum.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.PatientsInTreatmentSum.Location = new System.Drawing.Point(682, 627);
            this.PatientsInTreatmentSum.Name = "PatientsInTreatmentSum";
            this.PatientsInTreatmentSum.Size = new System.Drawing.Size(27, 19);
            this.PatientsInTreatmentSum.TabIndex = 69;
            this.PatientsInTreatmentSum.Text = "???";
            this.PatientsInTreatmentSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReleasedPatientsSum
            // 
            this.ReleasedPatientsSum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReleasedPatientsSum.AutoSize = true;
            this.ReleasedPatientsSum.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ReleasedPatientsSum.Location = new System.Drawing.Point(682, 664);
            this.ReleasedPatientsSum.Name = "ReleasedPatientsSum";
            this.ReleasedPatientsSum.Size = new System.Drawing.Size(27, 19);
            this.ReleasedPatientsSum.TabIndex = 70;
            this.ReleasedPatientsSum.Text = "???";
            this.ReleasedPatientsSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.DateLabel.Location = new System.Drawing.Point(141, 13);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(48, 19);
            this.DateLabel.TabIndex = 23;
            this.DateLabel.Text = "תאריך";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.TimeLabel.Location = new System.Drawing.Point(230, 13);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(37, 19);
            this.TimeLabel.TabIndex = 22;
            this.TimeLabel.Text = "שעה";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterPatientButton
            // 
            this.FilterPatientButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FilterPatientButton.Location = new System.Drawing.Point(738, 141);
            this.FilterPatientButton.Name = "FilterPatientButton";
            this.FilterPatientButton.Size = new System.Drawing.Size(94, 23);
            this.FilterPatientButton.TabIndex = 65;
            this.FilterPatientButton.Text = "סנן לפי מטופל";
            this.FilterPatientButton.UseSelectable = true;
            this.FilterPatientButton.Click += new System.EventHandler(this.FilterPatientButton_Click);
            // 
            // EnterIdTextBox
            // 
            this.EnterIdTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.EnterIdTextBox.CustomButton.Image = null;
            this.EnterIdTextBox.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.EnterIdTextBox.CustomButton.Name = "";
            this.EnterIdTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EnterIdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EnterIdTextBox.CustomButton.TabIndex = 1;
            this.EnterIdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EnterIdTextBox.CustomButton.UseSelectable = true;
            this.EnterIdTextBox.CustomButton.Visible = false;
            this.EnterIdTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.EnterIdTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.EnterIdTextBox.Lines = new string[0];
            this.EnterIdTextBox.Location = new System.Drawing.Point(838, 141);
            this.EnterIdTextBox.MaxLength = 32767;
            this.EnterIdTextBox.Name = "EnterIdTextBox";
            this.EnterIdTextBox.PasswordChar = '\0';
            this.EnterIdTextBox.PromptText = "הכנס ת.ז מטופל";
            this.EnterIdTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EnterIdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EnterIdTextBox.SelectedText = "";
            this.EnterIdTextBox.SelectionLength = 0;
            this.EnterIdTextBox.SelectionStart = 0;
            this.EnterIdTextBox.ShortcutsEnabled = true;
            this.EnterIdTextBox.Size = new System.Drawing.Size(141, 23);
            this.EnterIdTextBox.TabIndex = 67;
            this.EnterIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EnterIdTextBox.UseSelectable = true;
            this.EnterIdTextBox.WaterMark = "הכנס ת.ז מטופל";
            this.EnterIdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EnterIdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton10
            // 
            this.metroButton10.Location = new System.Drawing.Point(4, 13);
            this.metroButton10.Name = "metroButton10";
            this.metroButton10.Size = new System.Drawing.Size(63, 34);
            this.metroButton10.TabIndex = 72;
            this.metroButton10.Text = "סגור";
            this.metroButton10.UseSelectable = true;
            this.metroButton10.Click += new System.EventHandler(this.metroButton10_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton1.Location = new System.Drawing.Point(638, 141);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(94, 23);
            this.metroButton1.TabIndex = 73;
            this.metroButton1.Text = "מטופלים שלי";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton2.Location = new System.Drawing.Point(538, 141);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(94, 23);
            this.metroButton2.TabIndex = 74;
            this.metroButton2.Text = "הצג הכל";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.DoctorIcon_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.ShowHoverText);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(72, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.NurseIcon_Click);
            this.pictureBox2.MouseHover += new System.EventHandler(this.ShowHoverText);
            // 
            // metroButton3
            // 
            this.metroButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton3.Location = new System.Drawing.Point(838, 709);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(141, 23);
            this.metroButton3.TabIndex = 77;
            this.metroButton3.Text = "מחק מטופלים משוחררים";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton4.Location = new System.Drawing.Point(370, 141);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(162, 23);
            this.metroButton4.TabIndex = 78;
            this.metroButton4.Text = "הצג סטטוס זמנים למטופל";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // AllPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButton10);
            this.Controls.Add(this.EnterIdTextBox);
            this.Controls.Add(this.FilterPatientButton);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.ReleasedPatientsSum);
            this.Controls.Add(this.PatientsInTreatmentSum);
            this.Controls.Add(this.ReceivedPatientsSum);
            this.Controls.Add(this.ReleasedPatientsLabel);
            this.Controls.Add(this.PatientsInTreatmentLabel);
            this.Controls.Add(this.ReceivedPatientsLabel);
            this.Controls.Add(this.AllPatientsGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllPatients";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "כל המטופלים";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Load += new System.EventHandler(this.AllPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllPatientsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnobile_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid AllPatientsGrid;
        private Diagnobile_DatabaseDataSet diagnobile_DatabaseDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private Diagnobile_DatabaseDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private MetroFramework.Controls.MetroLabel ReceivedPatientsLabel;
        private MetroFramework.Controls.MetroLabel PatientsInTreatmentLabel;
        private MetroFramework.Controls.MetroLabel ReleasedPatientsLabel;
        private MetroFramework.Controls.MetroLabel ReceivedPatientsSum;
        private MetroFramework.Controls.MetroLabel PatientsInTreatmentSum;
        private MetroFramework.Controls.MetroLabel ReleasedPatientsSum;
        private MetroFramework.Controls.MetroLabel DateLabel;
        private MetroFramework.Controls.MetroLabel TimeLabel;
        private MetroFramework.Controls.MetroButton FilterPatientButton;
        private MetroFramework.Controls.MetroTextBox EnterIdTextBox;
        private MetroFramework.Controls.MetroButton metroButton10;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
    }
}