namespace DiagNobile
{
    partial class WorkStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkStation));
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.metroButton8 = new MetroFramework.Controls.MetroButton();
            this.metroButton9 = new MetroFramework.Controls.MetroButton();
            this.metroButton10 = new MetroFramework.Controls.MetroButton();
            this.metroButton11 = new MetroFramework.Controls.MetroButton();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("David", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(373, -100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 47);
            this.label1.TabIndex = 12;
            this.label1.Text = "תהליך תחילת עבודה";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(856, 97);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(133, 34);
            this.metroButton1.TabIndex = 28;
            this.metroButton1.Text = "פתיחת תהליך טיפול";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.OpenTreatment);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(856, 164);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(133, 34);
            this.metroButton2.TabIndex = 29;
            this.metroButton2.Text = "צפייה בפרטי מטופל";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.PatientStatus);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(856, 223);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(133, 34);
            this.metroButton3.TabIndex = 30;
            this.metroButton3.Text = "הזנת ממצאי בדיקה";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.EnterFindings);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(856, 282);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(133, 34);
            this.metroButton4.TabIndex = 31;
            this.metroButton4.Text = "הזנת המשך טיפול";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.EnterFollowUp);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(856, 342);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(133, 34);
            this.metroButton5.TabIndex = 32;
            this.metroButton5.Text = "הזנת אבחון למטופל";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.EnterDiagnosis);
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(845, 401);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(144, 34);
            this.metroButton6.TabIndex = 33;
            this.metroButton6.Text = "צפייה בבדיקות שהתקבלו";
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.SeeExaminators);
            // 
            // metroButton7
            // 
            this.metroButton7.Location = new System.Drawing.Point(798, 463);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(191, 41);
            this.metroButton7.TabIndex = 34;
            this.metroButton7.Text = "סגירת תהליך טיפול ושחרור המטופל";
            this.metroButton7.UseSelectable = true;
            this.metroButton7.Click += new System.EventHandler(this.CloseTreatment);
            // 
            // metroButton8
            // 
            this.metroButton8.Location = new System.Drawing.Point(856, 527);
            this.metroButton8.Name = "metroButton8";
            this.metroButton8.Size = new System.Drawing.Size(133, 34);
            this.metroButton8.TabIndex = 35;
            this.metroButton8.Text = "צפייה במצב מטופלים";
            this.metroButton8.UseSelectable = true;
            this.metroButton8.Click += new System.EventHandler(this.AllPatients);
            // 
            // metroButton9
            // 
            this.metroButton9.Location = new System.Drawing.Point(856, 591);
            this.metroButton9.Name = "metroButton9";
            this.metroButton9.Size = new System.Drawing.Size(133, 34);
            this.metroButton9.TabIndex = 36;
            this.metroButton9.Text = "צפייה/הפקת דו\'\'חות";
            this.metroButton9.UseSelectable = true;
            this.metroButton9.Click += new System.EventHandler(this.Reports);
            // 
            // metroButton10
            // 
            this.metroButton10.Location = new System.Drawing.Point(23, 715);
            this.metroButton10.Name = "metroButton10";
            this.metroButton10.Size = new System.Drawing.Size(133, 34);
            this.metroButton10.TabIndex = 37;
            this.metroButton10.Text = "יציאה";
            this.metroButton10.UseSelectable = true;
            this.metroButton10.Click += new System.EventHandler(this.Exit);
            // 
            // metroButton11
            // 
            this.metroButton11.Location = new System.Drawing.Point(176, 715);
            this.metroButton11.Name = "metroButton11";
            this.metroButton11.Size = new System.Drawing.Size(133, 34);
            this.metroButton11.TabIndex = 38;
            this.metroButton11.Text = "החלף משתמש";
            this.metroButton11.UseSelectable = true;
            this.metroButton11.Click += new System.EventHandler(this.ChangeUser);
            // 
            // WorkStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.metroButton11);
            this.Controls.Add(this.metroButton10);
            this.Controls.Add(this.metroButton9);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButton8);
            this.Controls.Add(this.metroButton7);
            this.Controls.Add(this.metroButton6);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.IsMdiContainer = true;
            this.Name = "WorkStation";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "תחילת עבודה";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroButton metroButton7;
        private MetroFramework.Controls.MetroButton metroButton8;
        private MetroFramework.Controls.MetroButton metroButton9;
        private MetroFramework.Controls.MetroButton metroButton10;
        private MetroFramework.Controls.MetroButton metroButton11;
    }
}



