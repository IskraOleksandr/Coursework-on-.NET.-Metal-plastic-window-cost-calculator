using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Metal_plastic_window_cost_calculator.Views
{
    public partial class FormAddUser : Form/*, IAddMaterialView*/
    {
        private bool edit { get; set; }
        public FormAddUser()
        {
            InitializeComponent();
            labelTitle.Text = "Add new user";
            enable_button(false);
            Id = 0;
        }

        public FormAddUser(object obj)
        {
            InitializeComponent();
            enable_button(false);

            labelTitle.Text = "Add new user";

            var row = obj as DataGridViewRow;
            Id = Convert.ToInt32(row.Cells["Id"].Value);
            FullName = row.Cells["FullName"].Value.ToString();
            Login = row.Cells["Login"].Value.ToString();
            Password = row.Cells["Password"].Value.ToString();
            Email = row.Cells["Email"].Value.ToString();
            IsAdmin = Convert.ToBoolean(row.Cells["IsAdmin"].Value);

        }

        public int Id { get; set; }
        public string FullName
        {
            get => textBoxCategory.Text.Trim();
            set => textBoxCategory.Text = value;
        }

        public string Login
        {
            get => textBoxName.Text.Trim();
            set => textBoxName.Text = value;
        }

        public string Password
        {
            get => textBoxColor.Text.Trim();
            set => textBoxColor.Text = value;
        }

        public string PasswordConfirm
        {
            get => textBoxPasswordConfirm.Text.Trim();
            set => textBoxPasswordConfirm.Text = value;
        }

        public string Email
        {
            get => textBoxDescription.Text.Trim();
            set => textBoxDescription.Text = value;
        }

        public bool IsAdmin { get; set; }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void textBoxCategory_TextChanged(object sender, EventArgs e)
        {
            validate_filds();
            //validate_pas();
        }

        //private void validate_pas()
        //{
        //    if (PasswordConfirm != Password)
        //    {
        //        label_error_password_confirm.Text = "error";
        //        valid = false;
        //    }
        //    else label_error_password_confirm.Text = "";
        //}

        private void validate_filds()
        {
            bool valid = true;

            if (FullName.Length <= 3)
            {
                label_error_fullname.Text = "error";
                valid = false;
            }
            else label_error_fullname.Text = "";


            if (Login.Length <= 3)
            {
                label_error_login.Text = "error";
                valid = false;
            }
            else label_error_login.Text = "";


            if (Password.Length < 3)
            {
                label_error_password.Text = "error";
                valid = false;
            }
            else label_error_password.Text = "";


            if (PasswordConfirm != Password)
            {
                label_error_password_confirm.Text = "error";
                valid = false;
            }
            else label_error_password_confirm.Text = "";


            if (Email.Length < 1)
            {
                label_error_email.Text = "error";
                valid = false;
            }
            else label_error_email.Text = "";


            enable_button(valid);
        }
        public void enable_button(bool off_on_flag)
        {
            if (off_on_flag)
            {
                //if (PasswordConfirm == Password)
                //{
                //    label_error_password_confirm.Text = "";
                //    valid = false;
                //}
                buttonAdd.Enabled = true;
            }
            else
            {
                buttonAdd.Enabled = false;
            }
        }

        private void checkBoxAdminReg_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            IsAdmin = check.Checked;
        }
    }
}
