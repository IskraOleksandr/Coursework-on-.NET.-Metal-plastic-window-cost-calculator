using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metal_plastic_window_cost_calculator.Views
{
    public partial class FormAddUser : Form
    {
        public int Id { get; set; }
        public string FullName { get => textBoxCategory.Text.Trim(); set => textBoxCategory.Text = value; }

        public string Login { get => textBoxName.Text.Trim(); set => textBoxName.Text = value; }
        public string Password { get => textBoxColor.Text.Trim(); set => textBoxColor.Text = value; }

        public string PasswordConfirm { get => textBoxPasswordConfirm.Text.Trim(); set => textBoxPasswordConfirm.Text = value; }
        public string Email { get => textBoxDescription.Text.Trim(); set => textBoxDescription.Text = value; }
        public bool IsAdmin { get => checkBoxAdminReg.Checked; set => checkBoxAdminReg.Checked = value; }


        private bool IsEdit { get; set; }

        public FormAddUser()
        {
            InitializeComponent();
            this.Text = "Add new user";
            labelTitle.Text = "Add user";
            enable_button(false);
            IsEdit = false;
            Id = 0;
        }

        public FormAddUser(object obj)
        {
            InitializeComponent();
            enable_button(false);
            this.Text = "Edit user";
            buttonAdd.Text = "Edit";
            labelTitle.Text = "Edit user";
            this.Height = 370;
            IsEdit = true;

            var row = obj as DataGridViewRow;
            Id = Convert.ToInt32(row.Cells["Id"].Value);
            FullName = row.Cells["FullName"].Value.ToString();
            Login = row.Cells["Login"].Value.ToString();
            
            Email = row.Cells["Email"].Value.ToString();
            IsAdmin = Convert.ToBoolean(row.Cells["IsAdmin"].Value);

            label_Color.Visible = false;
            textBoxColor.Visible = false;
            label_error_password.Visible = false;

            label_error_password_confirm.Visible = false;
            textBoxPasswordConfirm.Visible = false;
            label_CostPerMetr.Visible = false;

            label_Description.Location = new Point(45, 187);
            textBoxDescription.Location = new Point(45, 209);
            label_error_email.Location = new Point(45,231);
            checkBoxAdminReg.Location = new Point(45,251);
            buttonAdd.Location = new Point(97, 285);
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void textBoxCategory_TextChanged(object sender, EventArgs e)
        {
            validate_filds();
        }


        private void validate_filds()
        {
            bool valid = true;

            if (FullName.Length <= 3)
            {
                label_error_fullname.Text = "Incorrect full name length";
                valid = false;
            }
            else label_error_fullname.Text = "";


            if (Login.Length <= 3)
            {
                label_error_login.Text = "Incorrect login length";
                valid = false;
            }
            else label_error_login.Text = "";


            if (!IsEdit)
            {
                if (Password.Length < 3)
                {
                    label_error_password.Text = "Incorrect password length";
                    valid = false;
                }
                else label_error_password.Text = "";


                if (PasswordConfirm != Password)
                {
                    label_error_password_confirm.Text = "Password mismatch";
                    valid = false;
                }
                else label_error_password_confirm.Text = "";
            }

            if (Email.Length < 4)
            {
                label_error_email.Text = "Incorrect email";
                valid = false;
            }
            else label_error_email.Text = "";


            enable_button(valid);
        }
        public void enable_button(bool off_on_flag)
        {
            if (off_on_flag)
            {
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

        private void textBoxPasswordConfirm_TextChanged(object sender, EventArgs e)
        {
            validate_filds();
        }
    }
}
