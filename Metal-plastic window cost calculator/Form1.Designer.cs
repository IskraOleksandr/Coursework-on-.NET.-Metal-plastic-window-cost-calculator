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
            label_error_login = new Label();
            label_error_pas = new Label();
            label_error_fullname = new Label();
            label_error_email = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Cursor = Cursors.IBeam;
            textBoxLogin.Location = new Point(63, 88);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(151, 23);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(63, 154);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(151, 23);
            textBoxPassword.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(88, 330);
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
            label1.Location = new Point(169, 372);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 3;
            label1.Text = "Registration";
            label1.Click += label1_Click;
            // 
            // label_Login
            // 
            label_Login.AutoSize = true;
            label_Login.Location = new Point(63, 70);
            label_Login.Name = "label_Login";
            label_Login.Size = new Size(40, 15);
            label_Login.TabIndex = 4;
            label_Login.Text = "Login:";
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Location = new Point(63, 136);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(60, 15);
            label_Password.TabIndex = 5;
            label_Password.Text = "Password:";
            // 
            // label_FullName
            // 
            label_FullName.AutoSize = true;
            label_FullName.Location = new Point(63, 198);
            label_FullName.Name = "label_FullName";
            label_FullName.Size = new Size(61, 15);
            label_FullName.TabIndex = 7;
            label_FullName.Text = "FullName:";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(63, 216);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(151, 23);
            textBoxFullName.TabIndex = 6;
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Location = new Point(63, 262);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(39, 15);
            label_Email.TabIndex = 9;
            label_Email.Text = "Email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(63, 280);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(151, 23);
            textBoxEmail.TabIndex = 8;
            // 
            // checkBoxAdminReg
            // 
            checkBoxAdminReg.AutoSize = true;
            checkBoxAdminReg.Location = new Point(184, 336);
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
            labelTitle.Location = new Point(88, 29);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(99, 32);
            labelTitle.TabIndex = 11;
            labelTitle.Text = "Sign Up";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(30, 373);
            label7.Name = "label7";
            label7.Size = new Size(133, 14);
            label7.TabIndex = 12;
            label7.Text = "Don't have an account?";
            // 
            // label_error_login
            // 
            label_error_login.AutoSize = true;
            label_error_login.ForeColor = Color.Red;
            label_error_login.Location = new Point(63, 114);
            label_error_login.Name = "label_error_login";
            label_error_login.Size = new Size(0, 15);
            label_error_login.TabIndex = 13;
            // 
            // label_error_pas
            // 
            label_error_pas.AutoSize = true;
            label_error_pas.ForeColor = Color.Red;
            label_error_pas.Location = new Point(63, 177);
            label_error_pas.Name = "label_error_pas";
            label_error_pas.Size = new Size(0, 15);
            label_error_pas.TabIndex = 14;
            // 
            // label_error_fullname
            // 
            label_error_fullname.AutoSize = true;
            label_error_fullname.ForeColor = Color.Red;
            label_error_fullname.Location = new Point(63, 240);
            label_error_fullname.Name = "label_error_fullname";
            label_error_fullname.Size = new Size(0, 15);
            label_error_fullname.TabIndex = 15;
            // 
            // label_error_email
            // 
            label_error_email.AutoSize = true;
            label_error_email.ForeColor = Color.Red;
            label_error_email.Location = new Point(63, 306);
            label_error_email.Name = "label_error_email";
            label_error_email.Size = new Size(0, 15);
            label_error_email.TabIndex = 16;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(220, 29);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(536, 469);
            listView1.TabIndex = 17;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.ColumnClick += listView1_ColumnClick;
            listView1.Click += listView1_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "   ";
            columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Category";
            columnHeader2.Width = 145;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Name";
            columnHeader3.Width = 145;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Color";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Price";
            columnHeader5.Width = 90;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(777, 304);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 18;
            label2.Text = "label2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(772, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(772, 29);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 20;
            label3.Text = "Search: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(772, 88);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 21;
            label4.Text = "Search in: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(772, 106);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(210, 23);
            comboBox1.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(772, 154);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 23;
            label5.Text = "Search in: ";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(772, 174);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(210, 23);
            comboBox2.TabIndex = 24;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.ASCB24;
            button2.Location = new Point(774, 230);
            button2.Name = "button2";
            button2.Size = new Size(38, 38);
            button2.TabIndex = 25;
            button2.Tag = "ASC";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.WhiteSmoke;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.DESCB24;
            button3.Location = new Point(826, 230);
            button3.Name = "button3";
            button3.Size = new Size(38, 38);
            button3.TabIndex = 26;
            button3.Tag = "DESC";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(994, 521);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label_error_email);
            Controls.Add(label_error_fullname);
            Controls.Add(label_error_pas);
            Controls.Add(label_error_login);
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
        private Label label_error_login;
        private Label label_error_pas;
        private Label label_error_fullname;
        private Label label_error_email;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private ComboBox comboBox2;
        private Button button2;
        private Button button3;
    }
}
