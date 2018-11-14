namespace DiagNobile
{
    partial class UserEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEntry));
            this.ExitButton = new MetroFramework.Controls.MetroButton();
            this.SignInButton = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.IdBox = new System.Windows.Forms.PictureBox();
            this.boxIdInput = new System.Windows.Forms.PictureBox();
            this.PassInputBox = new System.Windows.Forms.PictureBox();
            this.PasswordBox = new System.Windows.Forms.PictureBox();
            this.LoginInputPass = new System.Windows.Forms.TextBox();
            this.LoginInputId = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.SignInButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxIdInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ExitButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(345, 367);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "יציאה";
            this.ExitButton.UseSelectable = true;
            this.ExitButton.Click += new System.EventHandler(this.Exit);
            // 
            // SignInButton
            // 
            this.SignInButton.Image = ((System.Drawing.Image)(resources.GetObject("SignInButton.Image")));
            this.SignInButton.Location = new System.Drawing.Point(69, 290);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(64, 30);
            this.SignInButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SignInButton.TabIndex = 63;
            this.SignInButton.TabStop = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(139, 73);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(281, 247);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 64;
            this.pictureBox5.TabStop = false;
            // 
            // IdBox
            // 
            this.IdBox.Image = ((System.Drawing.Image)(resources.GetObject("IdBox.Image")));
            this.IdBox.Location = new System.Drawing.Point(23, 97);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(110, 28);
            this.IdBox.TabIndex = 60;
            this.IdBox.TabStop = false;
            this.IdBox.Click += new System.EventHandler(this.IdBox_Click);
            // 
            // boxIdInput
            // 
            this.boxIdInput.Image = ((System.Drawing.Image)(resources.GetObject("boxIdInput.Image")));
            this.boxIdInput.Location = new System.Drawing.Point(23, 131);
            this.boxIdInput.Name = "boxIdInput";
            this.boxIdInput.Size = new System.Drawing.Size(163, 45);
            this.boxIdInput.TabIndex = 61;
            this.boxIdInput.TabStop = false;
            this.boxIdInput.Click += new System.EventHandler(this.IdInput_Click);
            // 
            // PassInputBox
            // 
            this.PassInputBox.Image = ((System.Drawing.Image)(resources.GetObject("PassInputBox.Image")));
            this.PassInputBox.Location = new System.Drawing.Point(23, 232);
            this.PassInputBox.Name = "PassInputBox";
            this.PassInputBox.Size = new System.Drawing.Size(163, 40);
            this.PassInputBox.TabIndex = 66;
            this.PassInputBox.TabStop = false;
            this.PassInputBox.Click += new System.EventHandler(this.PasswordInput_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Image = ((System.Drawing.Image)(resources.GetObject("PasswordBox.Image")));
            this.PasswordBox.Location = new System.Drawing.Point(23, 205);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(58, 21);
            this.PasswordBox.TabIndex = 67;
            this.PasswordBox.TabStop = false;
            // 
            // LoginInputPass
            // 
            this.LoginInputPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginInputPass.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LoginInputPass.Location = new System.Drawing.Point(40, 242);
            this.LoginInputPass.MaximumSize = new System.Drawing.Size(170, 35);
            this.LoginInputPass.MinimumSize = new System.Drawing.Size(5, 5);
            this.LoginInputPass.Name = "LoginInputPass";
            this.LoginInputPass.PasswordChar = '*';
            this.LoginInputPass.Size = new System.Drawing.Size(136, 15);
            this.LoginInputPass.TabIndex = 71;
            this.LoginInputPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginInputId
            // 
            this.LoginInputId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginInputId.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LoginInputId.Location = new System.Drawing.Point(40, 144);
            this.LoginInputId.MaximumSize = new System.Drawing.Size(170, 35);
            this.LoginInputId.MinimumSize = new System.Drawing.Size(5, 5);
            this.LoginInputId.Name = "LoginInputId";
            this.LoginInputId.Size = new System.Drawing.Size(136, 15);
            this.LoginInputId.TabIndex = 70;
            this.LoginInputId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.Red;
            this.metroLabel2.Location = new System.Drawing.Point(2, 205);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(20, 25);
            this.metroLabel2.TabIndex = 170;
            this.metroLabel2.Text = "*";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Red;
            this.metroLabel1.Location = new System.Drawing.Point(2, 97);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(20, 25);
            this.metroLabel1.TabIndex = 171;
            this.metroLabel1.Text = "*";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UserEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 399);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.LoginInputId);
            this.Controls.Add(this.LoginInputPass);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.PassInputBox);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.boxIdInput);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.pictureBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserEntry";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "כניסת משתמש";
            this.Load += new System.EventHandler(this.UserEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SignInButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxIdInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassInputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton ExitButton;
        private System.Windows.Forms.PictureBox SignInButton;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox IdBox;
        private System.Windows.Forms.PictureBox boxIdInput;
        private System.Windows.Forms.PictureBox PassInputBox;
        private System.Windows.Forms.PictureBox PasswordBox;
        private System.Windows.Forms.TextBox LoginInputPass;
        private System.Windows.Forms.TextBox LoginInputId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}