namespace Metal_plastic_window_cost_calculator.Views
{
    partial class FormAddUser
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
            label_error_password_confirm = new Label();
            label_error_password = new Label();
            label_error_login = new Label();
            label_error_fullname = new Label();
            textBoxCategory = new TextBox();
            textBoxName = new TextBox();
            label_Category = new Label();
            label_Name = new Label();
            labelTitle = new Label();
            label_CostPerMetr = new Label();
            label_Color = new Label();
            textBoxColor = new TextBox();
            buttonAdd = new Button();
            label_error_email = new Label();
            label_Description = new Label();
            textBoxDescription = new TextBox();
            textBoxPasswordConfirm = new TextBox();
            checkBoxAdminReg = new CheckBox();
            SuspendLayout();
            // 
            // label_error_password_confirm
            // 
            label_error_password_confirm.AutoSize = true;
            label_error_password_confirm.ForeColor = Color.Red;
            label_error_password_confirm.Location = new Point(45, 295);
            label_error_password_confirm.Name = "label_error_password_confirm";
            label_error_password_confirm.Size = new Size(0, 15);
            label_error_password_confirm.TabIndex = 31;
            // 
            // label_error_password
            // 
            label_error_password.AutoSize = true;
            label_error_password.ForeColor = Color.Red;
            label_error_password.Location = new Point(45, 229);
            label_error_password.Name = "label_error_password";
            label_error_password.Size = new Size(0, 15);
            label_error_password.TabIndex = 30;
            // 
            // label_error_login
            // 
            label_error_login.AutoSize = true;
            label_error_login.ForeColor = Color.Red;
            label_error_login.Location = new Point(45, 166);
            label_error_login.Name = "label_error_login";
            label_error_login.Size = new Size(0, 15);
            label_error_login.TabIndex = 29;
            // 
            // label_error_fullname
            // 
            label_error_fullname.AutoSize = true;
            label_error_fullname.ForeColor = Color.Red;
            label_error_fullname.Location = new Point(45, 103);
            label_error_fullname.Name = "label_error_fullname";
            label_error_fullname.Size = new Size(0, 15);
            label_error_fullname.TabIndex = 28;
            // 
            // textBoxCategory
            // 
            textBoxCategory.Cursor = Cursors.IBeam;
            textBoxCategory.Location = new Point(45, 77);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(188, 23);
            textBoxCategory.TabIndex = 17;
            textBoxCategory.TextChanged += textBoxCategory_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(45, 143);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(188, 23);
            textBoxName.TabIndex = 19;
            textBoxName.TextChanged += textBoxCategory_TextChanged;
            // 
            // label_Category
            // 
            label_Category.AutoSize = true;
            label_Category.Location = new Point(45, 59);
            label_Category.Name = "label_Category";
            label_Category.Size = new Size(61, 15);
            label_Category.TabIndex = 20;
            label_Category.Text = "FullName:";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(45, 125);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(40, 15);
            label_Name.TabIndex = 21;
            label_Name.Text = "Login:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.Location = new Point(71, 18);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(98, 26);
            labelTitle.TabIndex = 27;
            labelTitle.Text = "New User";
            // 
            // label_CostPerMetr
            // 
            label_CostPerMetr.AutoSize = true;
            label_CostPerMetr.Location = new Point(45, 251);
            label_CostPerMetr.Name = "label_CostPerMetr";
            label_CostPerMetr.Size = new Size(105, 15);
            label_CostPerMetr.TabIndex = 25;
            label_CostPerMetr.Text = "Password confirm:";
            // 
            // label_Color
            // 
            label_Color.AutoSize = true;
            label_Color.Location = new Point(45, 187);
            label_Color.Name = "label_Color";
            label_Color.Size = new Size(60, 15);
            label_Color.TabIndex = 23;
            label_Color.Text = "Password:";
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(45, 205);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(188, 23);
            textBoxColor.TabIndex = 22;
            textBoxColor.UseSystemPasswordChar = true;
            textBoxColor.TextChanged += textBoxCategory_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.DodgerBlue;
            buttonAdd.FlatAppearance.BorderColor = Color.White;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(97, 420);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 27);
            buttonAdd.TabIndex = 18;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label_error_email
            // 
            label_error_email.AutoSize = true;
            label_error_email.ForeColor = Color.Red;
            label_error_email.Location = new Point(45, 358);
            label_error_email.Name = "label_error_email";
            label_error_email.Size = new Size(0, 15);
            label_error_email.TabIndex = 34;
            // 
            // label_Description
            // 
            label_Description.AutoSize = true;
            label_Description.Location = new Point(45, 314);
            label_Description.Name = "label_Description";
            label_Description.Size = new Size(39, 15);
            label_Description.TabIndex = 33;
            label_Description.Text = "Email:";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Cursor = Cursors.IBeam;
            textBoxDescription.Location = new Point(45, 332);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ScrollBars = ScrollBars.Vertical;
            textBoxDescription.Size = new Size(188, 23);
            textBoxDescription.TabIndex = 32;
            textBoxDescription.TextChanged += textBoxCategory_TextChanged;
            // 
            // textBoxPasswordConfirm
            // 
            textBoxPasswordConfirm.Location = new Point(45, 269);
            textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            textBoxPasswordConfirm.Size = new Size(188, 23);
            textBoxPasswordConfirm.TabIndex = 35;
            textBoxPasswordConfirm.UseSystemPasswordChar = true;
            textBoxPasswordConfirm.TextChanged += textBoxPasswordConfirm_TextChanged;
            // 
            // checkBoxAdminReg
            // 
            checkBoxAdminReg.AutoSize = true;
            checkBoxAdminReg.Location = new Point(45, 382);
            checkBoxAdminReg.Name = "checkBoxAdminReg";
            checkBoxAdminReg.Size = new Size(62, 19);
            checkBoxAdminReg.TabIndex = 36;
            checkBoxAdminReg.Text = "Admin";
            checkBoxAdminReg.UseVisualStyleBackColor = true;
            checkBoxAdminReg.CheckedChanged += checkBoxAdminReg_CheckedChanged;
            // 
            // FormAddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 459);
            Controls.Add(checkBoxAdminReg);
            Controls.Add(textBoxPasswordConfirm);
            Controls.Add(label_error_email);
            Controls.Add(textBoxDescription);
            Controls.Add(label_Description);
            Controls.Add(label_error_password_confirm);
            Controls.Add(label_error_password);
            Controls.Add(label_error_login);
            Controls.Add(label_error_fullname);
            Controls.Add(textBoxCategory);
            Controls.Add(textBoxName);
            Controls.Add(label_Category);
            Controls.Add(label_Name);
            Controls.Add(labelTitle);
            Controls.Add(label_CostPerMetr);
            Controls.Add(label_Color);
            Controls.Add(textBoxColor);
            Controls.Add(buttonAdd);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormAddUser";
            Text = "Add new user";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_error_password_confirm;
        private Label label_error_password;
        private Label label_error_login;
        private Label label_error_fullname;
        private TextBox textBoxCategory;
        private TextBox textBoxName;
        private Label label_Category;
        private Label label_Name;
        private Label labelTitle;
        private Label label_CostPerMetr;
        private TextBox textBoxCostPerMetr;
        private Label label_Color;
        private TextBox textBoxColor;
        private Button buttonAdd;
        private Label label_error_email;
        private Label label_Description;
        private TextBox textBoxDescription;
        private TextBox textBoxPasswordConfirm;
        private CheckBox checkBoxAdminReg;
    }
}