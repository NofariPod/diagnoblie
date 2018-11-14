namespace DiagNobile
{
    partial class CloseTreatmentProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloseTreatmentProcess));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DateLabel = new MetroFramework.Controls.MetroLabel();
            this.TimeLabel = new MetroFramework.Controls.MetroLabel();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnobile_DatabaseDataSet = new DiagNobile.Diagnobile_DatabaseDataSet();
            this.patientsTableAdapter = new DiagNobile.Diagnobile_DatabaseDataSetTableAdapters.PatientsTableAdapter();
            this.DoctorTreatLabel = new MetroFramework.Controls.MetroLabel();
            this.DoctorTreatNameLabel = new MetroFramework.Controls.MetroLabel();
            this.PrintReportButton = new MetroFramework.Controls.MetroButton();
            this.ExitButton = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.first = new MetroFramework.Controls.MetroLabel();
            this.id = new MetroFramework.Controls.MetroLabel();
            this.sens = new MetroFramework.Controls.MetroTextBox();
            this.cronic = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Pulse = new MetroFramework.Controls.MetroLabel();
            this.BloodPressure1 = new MetroFramework.Controls.MetroLabel();
            this.BloodPressure = new MetroFramework.Controls.MetroLabel();
            this.Temperature = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.BloodPressureLabel = new MetroFramework.Controls.MetroLabel();
            this.PulseLabel = new MetroFramework.Controls.MetroLabel();
            this.TemperatureLabel = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.SymptomDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.side = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NurseNameLabel = new MetroFramework.Controls.MetroLabel();
            this.TreatmentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.Diagnosis = new MetroFramework.Controls.MetroTextBox();
            this.DiagnosisNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.DiagnosisNameLabel = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nurse = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.metroListView2 = new MetroFramework.Controls.MetroListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.metroListView5 = new MetroFramework.Controls.MetroListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnobile_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.TreatmentInfoGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.DateLabel.Location = new System.Drawing.Point(100, 14);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(48, 19);
            this.DateLabel.TabIndex = 50;
            this.DateLabel.Text = "תאריך";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.TimeLabel.Location = new System.Drawing.Point(183, 14);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(37, 19);
            this.TimeLabel.TabIndex = 49;
            this.TimeLabel.Text = "שעה";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // DoctorTreatLabel
            // 
            this.DoctorTreatLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DoctorTreatLabel.AutoSize = true;
            this.DoctorTreatLabel.Location = new System.Drawing.Point(911, 688);
            this.DoctorTreatLabel.Name = "DoctorTreatLabel";
            this.DoctorTreatLabel.Size = new System.Drawing.Size(79, 19);
            this.DoctorTreatLabel.TabIndex = 53;
            this.DoctorTreatLabel.Text = ":רופא מטפל";
            // 
            // DoctorTreatNameLabel
            // 
            this.DoctorTreatNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DoctorTreatNameLabel.AutoSize = true;
            this.DoctorTreatNameLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.DoctorTreatNameLabel.Location = new System.Drawing.Point(840, 688);
            this.DoctorTreatNameLabel.Name = "DoctorTreatNameLabel";
            this.DoctorTreatNameLabel.Size = new System.Drawing.Size(65, 19);
            this.DoctorTreatNameLabel.TabIndex = 54;
            this.DoctorTreatNameLabel.Text = "שם רופא";
            this.DoctorTreatNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrintReportButton
            // 
            this.PrintReportButton.Location = new System.Drawing.Point(7, 14);
            this.PrintReportButton.Name = "PrintReportButton";
            this.PrintReportButton.Size = new System.Drawing.Size(76, 40);
            this.PrintReportButton.TabIndex = 56;
            this.PrintReportButton.Text = "הדפס דו\'\'ח";
            this.PrintReportButton.UseSelectable = true;
            this.PrintReportButton.Click += new System.EventHandler(this.PrintReportButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(7, 60);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(76, 34);
            this.ExitButton.TabIndex = 59;
            this.ExitButton.Text = "סיים";
            this.ExitButton.UseSelectable = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(937, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.DoctorIcon_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.ShowHoverText);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.first);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.sens);
            this.groupBox1.Controls.Add(this.cronic);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(72, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(918, 140);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "פרטי המטופל";
            // 
            // first
            // 
            this.first.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.first.AutoSize = true;
            this.first.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.first.Location = new System.Drawing.Point(530, 30);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(81, 19);
            this.first.TabIndex = 108;
            this.first.Text = "000000000";
            // 
            // id
            // 
            this.id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.id.AutoSize = true;
            this.id.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.id.Location = new System.Drawing.Point(720, 30);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(81, 19);
            this.id.TabIndex = 107;
            this.id.Text = "000000000";
            // 
            // sens
            // 
            // 
            // 
            // 
            this.sens.CustomButton.Image = null;
            this.sens.CustomButton.Location = new System.Drawing.Point(758, 1);
            this.sens.CustomButton.Name = "";
            this.sens.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.sens.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sens.CustomButton.TabIndex = 1;
            this.sens.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sens.CustomButton.UseSelectable = true;
            this.sens.CustomButton.Visible = false;
            this.sens.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.sens.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.sens.Lines = new string[0];
            this.sens.Location = new System.Drawing.Point(21, 99);
            this.sens.MaxLength = 32767;
            this.sens.Name = "sens";
            this.sens.PasswordChar = '\0';
            this.sens.ReadOnly = true;
            this.sens.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sens.SelectedText = "";
            this.sens.SelectionLength = 0;
            this.sens.SelectionStart = 0;
            this.sens.ShortcutsEnabled = true;
            this.sens.Size = new System.Drawing.Size(780, 23);
            this.sens.TabIndex = 74;
            this.sens.UseSelectable = true;
            this.sens.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sens.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cronic
            // 
            // 
            // 
            // 
            this.cronic.CustomButton.Image = null;
            this.cronic.CustomButton.Location = new System.Drawing.Point(758, 1);
            this.cronic.CustomButton.Name = "";
            this.cronic.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cronic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cronic.CustomButton.TabIndex = 1;
            this.cronic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cronic.CustomButton.UseSelectable = true;
            this.cronic.CustomButton.Visible = false;
            this.cronic.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.cronic.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.cronic.IconRight = true;
            this.cronic.Lines = new string[0];
            this.cronic.Location = new System.Drawing.Point(21, 63);
            this.cronic.MaxLength = 32767;
            this.cronic.Name = "cronic";
            this.cronic.PasswordChar = '\0';
            this.cronic.ReadOnly = true;
            this.cronic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cronic.SelectedText = "";
            this.cronic.SelectionLength = 0;
            this.cronic.SelectionStart = 0;
            this.cronic.ShortcutsEnabled = true;
            this.cronic.Size = new System.Drawing.Size(780, 23);
            this.cronic.TabIndex = 73;
            this.cronic.UseSelectable = true;
            this.cronic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cronic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(821, 30);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 66;
            this.metroLabel2.Text = "תעודת זהות";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(617, 30);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(33, 19);
            this.metroLabel4.TabIndex = 70;
            this.metroLabel4.Text = "שם ";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(841, 99);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(57, 19);
            this.metroLabel5.TabIndex = 69;
            this.metroLabel5.Text = "רגישויות";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(805, 63);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(93, 19);
            this.metroLabel6.TabIndex = 68;
            this.metroLabel6.Text = "מחלות כרוניות";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.Pulse);
            this.groupBox2.Controls.Add(this.BloodPressure1);
            this.groupBox2.Controls.Add(this.BloodPressure);
            this.groupBox2.Controls.Add(this.Temperature);
            this.groupBox2.Controls.Add(this.metroLabel12);
            this.groupBox2.Controls.Add(this.BloodPressureLabel);
            this.groupBox2.Controls.Add(this.PulseLabel);
            this.groupBox2.Controls.Add(this.TemperatureLabel);
            this.groupBox2.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2.Location = new System.Drawing.Point(407, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(583, 69);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "פרטי טיפול";
            // 
            // Pulse
            // 
            this.Pulse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pulse.AutoSize = true;
            this.Pulse.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Pulse.Location = new System.Drawing.Point(34, 25);
            this.Pulse.Name = "Pulse";
            this.Pulse.Size = new System.Drawing.Size(41, 19);
            this.Pulse.TabIndex = 113;
            this.Pulse.Text = "0000";
            this.Pulse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BloodPressure1
            // 
            this.BloodPressure1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BloodPressure1.AutoSize = true;
            this.BloodPressure1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.BloodPressure1.Location = new System.Drawing.Point(137, 25);
            this.BloodPressure1.Name = "BloodPressure1";
            this.BloodPressure1.Size = new System.Drawing.Size(41, 19);
            this.BloodPressure1.TabIndex = 112;
            this.BloodPressure1.Text = "0000";
            this.BloodPressure1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BloodPressure
            // 
            this.BloodPressure.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BloodPressure.AutoSize = true;
            this.BloodPressure.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.BloodPressure.Location = new System.Drawing.Point(303, 25);
            this.BloodPressure.Name = "BloodPressure";
            this.BloodPressure.Size = new System.Drawing.Size(41, 19);
            this.BloodPressure.TabIndex = 111;
            this.BloodPressure.Text = "0000";
            this.BloodPressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Temperature
            // 
            this.Temperature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Temperature.AutoSize = true;
            this.Temperature.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Temperature.Location = new System.Drawing.Point(472, 25);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(41, 19);
            this.Temperature.TabIndex = 110;
            this.Temperature.Text = "0000";
            this.Temperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(180, 25);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(110, 19);
            this.metroLabel12.TabIndex = 84;
            this.metroLabel12.Text = ":לחץ דם דיאסטולי";
            // 
            // BloodPressureLabel
            // 
            this.BloodPressureLabel.AutoSize = true;
            this.BloodPressureLabel.Location = new System.Drawing.Point(350, 25);
            this.BloodPressureLabel.Name = "BloodPressureLabel";
            this.BloodPressureLabel.Size = new System.Drawing.Size(106, 19);
            this.BloodPressureLabel.TabIndex = 73;
            this.BloodPressureLabel.Text = ":לחץ דם סיסטולי";
            // 
            // PulseLabel
            // 
            this.PulseLabel.AutoSize = true;
            this.PulseLabel.Location = new System.Drawing.Point(81, 25);
            this.PulseLabel.Name = "PulseLabel";
            this.PulseLabel.Size = new System.Drawing.Size(39, 19);
            this.PulseLabel.TabIndex = 74;
            this.PulseLabel.Text = ":דופק";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Location = new System.Drawing.Point(516, 25);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(33, 19);
            this.TemperatureLabel.TabIndex = 73;
            this.TemperatureLabel.Text = ":חום";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.metroGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.ColumnHeadersHeight = 20;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SymptomDescription,
            this.type,
            this.side});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(6, 21);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("David", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(337, 113);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroGrid1.TabIndex = 90;
            // 
            // SymptomDescription
            // 
            this.SymptomDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SymptomDescription.DataPropertyName = "SymptomDescription";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.SymptomDescription.DefaultCellStyle = dataGridViewCellStyle3;
            this.SymptomDescription.FillWeight = 70F;
            this.SymptomDescription.HeaderText = "תיאור סימפטום";
            this.SymptomDescription.Name = "SymptomDescription";
            this.SymptomDescription.ReadOnly = true;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.type.DefaultCellStyle = dataGridViewCellStyle4;
            this.type.FillWeight = 30F;
            this.type.HeaderText = "סוג";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // side
            // 
            this.side.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.side.DefaultCellStyle = dataGridViewCellStyle5;
            this.side.FillWeight = 30F;
            this.side.HeaderText = "צד";
            this.side.Name = "side";
            this.side.ReadOnly = true;
            // 
            // NurseNameLabel
            // 
            this.NurseNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NurseNameLabel.AutoSize = true;
            this.NurseNameLabel.Location = new System.Drawing.Point(640, 688);
            this.NurseNameLabel.Name = "NurseNameLabel";
            this.NurseNameLabel.Size = new System.Drawing.Size(91, 19);
            this.NurseNameLabel.TabIndex = 67;
            this.NurseNameLabel.Text = ":אחות מטפלת";
            // 
            // TreatmentInfoGroupBox
            // 
            this.TreatmentInfoGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TreatmentInfoGroupBox.Controls.Add(this.Diagnosis);
            this.TreatmentInfoGroupBox.Controls.Add(this.DiagnosisNameTextBox);
            this.TreatmentInfoGroupBox.Controls.Add(this.metroLabel13);
            this.TreatmentInfoGroupBox.Controls.Add(this.DiagnosisNameLabel);
            this.TreatmentInfoGroupBox.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TreatmentInfoGroupBox.Location = new System.Drawing.Point(407, 355);
            this.TreatmentInfoGroupBox.Name = "TreatmentInfoGroupBox";
            this.TreatmentInfoGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TreatmentInfoGroupBox.Size = new System.Drawing.Size(583, 72);
            this.TreatmentInfoGroupBox.TabIndex = 105;
            this.TreatmentInfoGroupBox.TabStop = false;
            this.TreatmentInfoGroupBox.Text = "פרטי ממצאי בדיקה";
            // 
            // Diagnosis
            // 
            // 
            // 
            // 
            this.Diagnosis.CustomButton.Image = null;
            this.Diagnosis.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.Diagnosis.CustomButton.Name = "";
            this.Diagnosis.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Diagnosis.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Diagnosis.CustomButton.TabIndex = 1;
            this.Diagnosis.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Diagnosis.CustomButton.UseSelectable = true;
            this.Diagnosis.CustomButton.Visible = false;
            this.Diagnosis.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Diagnosis.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.Diagnosis.Lines = new string[0];
            this.Diagnosis.Location = new System.Drawing.Point(6, 27);
            this.Diagnosis.MaxLength = 32767;
            this.Diagnosis.Name = "Diagnosis";
            this.Diagnosis.PasswordChar = '\0';
            this.Diagnosis.ReadOnly = true;
            this.Diagnosis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Diagnosis.SelectedText = "";
            this.Diagnosis.SelectionLength = 0;
            this.Diagnosis.SelectionStart = 0;
            this.Diagnosis.ShortcutsEnabled = true;
            this.Diagnosis.Size = new System.Drawing.Size(170, 23);
            this.Diagnosis.TabIndex = 92;
            this.Diagnosis.UseSelectable = true;
            this.Diagnosis.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Diagnosis.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DiagnosisNameTextBox
            // 
            // 
            // 
            // 
            this.DiagnosisNameTextBox.CustomButton.Image = null;
            this.DiagnosisNameTextBox.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.DiagnosisNameTextBox.CustomButton.Name = "";
            this.DiagnosisNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DiagnosisNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DiagnosisNameTextBox.CustomButton.TabIndex = 1;
            this.DiagnosisNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DiagnosisNameTextBox.CustomButton.UseSelectable = true;
            this.DiagnosisNameTextBox.CustomButton.Visible = false;
            this.DiagnosisNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.DiagnosisNameTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.DiagnosisNameTextBox.Lines = new string[0];
            this.DiagnosisNameTextBox.Location = new System.Drawing.Point(306, 27);
            this.DiagnosisNameTextBox.MaxLength = 32767;
            this.DiagnosisNameTextBox.Name = "DiagnosisNameTextBox";
            this.DiagnosisNameTextBox.PasswordChar = '\0';
            this.DiagnosisNameTextBox.ReadOnly = true;
            this.DiagnosisNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DiagnosisNameTextBox.SelectedText = "";
            this.DiagnosisNameTextBox.SelectionLength = 0;
            this.DiagnosisNameTextBox.SelectionStart = 0;
            this.DiagnosisNameTextBox.ShortcutsEnabled = true;
            this.DiagnosisNameTextBox.Size = new System.Drawing.Size(171, 23);
            this.DiagnosisNameTextBox.TabIndex = 68;
            this.DiagnosisNameTextBox.UseSelectable = true;
            this.DiagnosisNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DiagnosisNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(182, 27);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(94, 19);
            this.metroLabel13.TabIndex = 93;
            this.metroLabel13.Text = "אבחנה מבדלת";
            // 
            // DiagnosisNameLabel
            // 
            this.DiagnosisNameLabel.AutoSize = true;
            this.DiagnosisNameLabel.Location = new System.Drawing.Point(483, 27);
            this.DiagnosisNameLabel.Name = "DiagnosisNameLabel";
            this.DiagnosisNameLabel.Size = new System.Drawing.Size(94, 19);
            this.DiagnosisNameLabel.TabIndex = 75;
            this.DiagnosisNameLabel.Text = "אבחנה עיקרית";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.metroGrid1);
            this.groupBox3.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox3.Location = new System.Drawing.Point(40, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(360, 147);
            this.groupBox3.TabIndex = 105;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "תלונות";
            // 
            // nurse
            // 
            this.nurse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nurse.AutoSize = true;
            this.nurse.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.nurse.Location = new System.Drawing.Point(566, 688);
            this.nurse.Name = "nurse";
            this.nurse.Size = new System.Drawing.Size(68, 19);
            this.nurse.TabIndex = 106;
            this.nurse.Text = "שם אחות";
            this.nurse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox4.Location = new System.Drawing.Point(407, 446);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(583, 220);
            this.groupBox4.TabIndex = 107;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "תוכנית טיפול";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.Controls.Add(this.metroListView2);
            this.groupBox5.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox5.Location = new System.Drawing.Point(10, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(266, 193);
            this.groupBox5.TabIndex = 191;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "מעקב";
            // 
            // metroListView2
            // 
            this.metroListView2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.metroListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.metroListView2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView2.FullRowSelect = true;
            this.metroListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.metroListView2.HideSelection = false;
            this.metroListView2.Location = new System.Drawing.Point(7, 19);
            this.metroListView2.Name = "metroListView2";
            this.metroListView2.OwnerDraw = true;
            this.metroListView2.RightToLeftLayout = true;
            this.metroListView2.Size = new System.Drawing.Size(246, 152);
            this.metroListView2.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.metroListView2.TabIndex = 125;
            this.metroListView2.UseCompatibleStateImageBehavior = false;
            this.metroListView2.UseSelectable = true;
            this.metroListView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "שם";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "תדירות";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 92;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox7.Controls.Add(this.metroListView5);
            this.groupBox7.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox7.Location = new System.Drawing.Point(297, 21);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox7.Size = new System.Drawing.Size(266, 193);
            this.groupBox7.TabIndex = 190;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "תרופות";
            // 
            // metroListView5
            // 
            this.metroListView5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.metroListView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.metroListView5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView5.FullRowSelect = true;
            this.metroListView5.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.metroListView5.HideSelection = false;
            this.metroListView5.Location = new System.Drawing.Point(6, 21);
            this.metroListView5.Name = "metroListView5";
            this.metroListView5.OwnerDraw = true;
            this.metroListView5.RightToLeftLayout = true;
            this.metroListView5.Size = new System.Drawing.Size(246, 152);
            this.metroListView5.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.metroListView5.TabIndex = 96;
            this.metroListView5.UseCompatibleStateImageBehavior = false;
            this.metroListView5.UseSelectable = true;
            this.metroListView5.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "שם";
            this.columnHeader5.Width = 99;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "מינון";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 80;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            this.printDocument1.QueryPageSettings += new System.Drawing.Printing.QueryPageSettingsEventHandler(this.printDocument1_QueryPageSettings);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CloseTreatmentProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.nurse);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TreatmentInfoGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NurseNameLabel);
            this.Controls.Add(this.PrintReportButton);
            this.Controls.Add(this.DoctorTreatNameLabel);
            this.Controls.Add(this.DoctorTreatLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TimeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CloseTreatmentProcess";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "שחרור המטופל";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Load += new System.EventHandler(this.CloseTreatmentProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnobile_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.TreatmentInfoGroupBox.ResumeLayout(false);
            this.TreatmentInfoGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel DateLabel;
        private MetroFramework.Controls.MetroLabel TimeLabel;
        private Diagnobile_DatabaseDataSet diagnobile_DatabaseDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private Diagnobile_DatabaseDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn medicalHistoryDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel DoctorTreatLabel;
        private MetroFramework.Controls.MetroLabel DoctorTreatNameLabel;
        private MetroFramework.Controls.MetroButton PrintReportButton;
        private MetroFramework.Controls.MetroButton ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox sens;
        private MetroFramework.Controls.MetroTextBox cronic;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel BloodPressureLabel;
        private MetroFramework.Controls.MetroLabel PulseLabel;
        private MetroFramework.Controls.MetroLabel TemperatureLabel;
        private MetroFramework.Controls.MetroLabel NurseNameLabel;
        private MetroFramework.Controls.MetroLabel first;
        private MetroFramework.Controls.MetroLabel id;
        private System.Windows.Forms.GroupBox TreatmentInfoGroupBox;
        private MetroFramework.Controls.MetroTextBox Diagnosis;
        private MetroFramework.Controls.MetroTextBox DiagnosisNameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel DiagnosisNameLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel nurse;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroLabel Pulse;
        private MetroFramework.Controls.MetroLabel BloodPressure1;
        private MetroFramework.Controls.MetroLabel BloodPressure;
        private MetroFramework.Controls.MetroLabel Temperature;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SymptomDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn side;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox7;
        private MetroFramework.Controls.MetroListView metroListView5;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroListView metroListView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}