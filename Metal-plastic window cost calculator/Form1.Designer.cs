namespace Metal_plastic_window_cost_calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label_Login = new Label();
            label_Password = new Label();
            label_FullName = new Label();
            textBoxFullName = new TextBox();
            label_Email = new Label();
            textBoxEmail = new TextBox();
            checkBoxAdminReg = new CheckBox();
            labelTitle = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Cursor = Cursors.IBeam;
            textBoxLogin.Location = new Point(63, 113);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(151, 23);
            textBoxLogin.TabIndex = 0;
            textBoxLogin.TextChanged += textBoxLogin_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(63, 163);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(151, 23);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.TextChanged += textBoxLogin_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(97, 302);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 0;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(178, 344);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 3;
            label1.Text = "Registration";
            label1.Click += label1_Click;
            // 
            // label_Login
            // 
            label_Login.AutoSize = true;
            label_Login.Location = new Point(63, 95);
            label_Login.Name = "label_Login";
            label_Login.Size = new Size(40, 15);
            label_Login.TabIndex = 4;
            label_Login.Text = "Login:";
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Location = new Point(63, 145);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(60, 15);
            label_Password.TabIndex = 5;
            label_Password.Text = "Password:";
            // 
            // label_FullName
            // 
            label_FullName.AutoSize = true;
            label_FullName.Location = new Point(63, 193);
            label_FullName.Name = "label_FullName";
            label_FullName.Size = new Size(61, 15);
            label_FullName.TabIndex = 7;
            label_FullName.Text = "FullName:";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(63, 211);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(151, 23);
            textBoxFullName.TabIndex = 6;
            textBoxFullName.TextChanged += textBoxLogin_TextChanged;
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Location = new Point(63, 243);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(39, 15);
            label_Email.TabIndex = 9;
            label_Email.Text = "Email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(63, 261);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(151, 23);
            textBoxEmail.TabIndex = 8;
            textBoxEmail.TextChanged += textBoxLogin_TextChanged;
            // 
            // checkBoxAdminReg
            // 
            checkBoxAdminReg.AutoSize = true;
            checkBoxAdminReg.Location = new Point(193, 308);
            checkBoxAdminReg.Name = "checkBoxAdminReg";
            checkBoxAdminReg.Size = new Size(62, 19);
            checkBoxAdminReg.TabIndex = 10;
            checkBoxAdminReg.Text = "Admin";
            checkBoxAdminReg.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.Location = new Point(97, 53);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(99, 32);
            labelTitle.TabIndex = 11;
            labelTitle.Text = "Sign Up";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(39, 345);
            label7.Name = "label7";
            label7.Size = new Size(133, 14);
            label7.TabIndex = 12;
            label7.Text = "Don't have an account?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(272, 368);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(label_Login);
            Controls.Add(label7);
            Controls.Add(label_Password);
            Controls.Add(labelTitle);
            Controls.Add(checkBoxAdminReg);
            Controls.Add(label_Email);
            Controls.Add(textBoxEmail);
            Controls.Add(label_FullName);
            Controls.Add(textBoxFullName);
            Controls.Add(label1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Window Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button button1;
        private Label label1;
        private Label label_Login;
        private Label label_Password;
        private Label label_FullName;
        private TextBox textBoxFullName;
        private Label label_Email;
        private TextBox textBoxEmail;
        private CheckBox checkBoxAdminReg;
        private Label labelTitle;
        private Label label7;
    }
}
