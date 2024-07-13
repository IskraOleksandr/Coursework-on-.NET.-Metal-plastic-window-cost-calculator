using Metal_plastic_window_cost_calculator.Models;
using Metal_plastic_window_cost_calculator.Presenters;
using Metal_plastic_window_cost_calculator.Views;
using System.Windows.Forms;

namespace Metal_plastic_window_cost_calculator
{
    public partial class FormLog : Form, IWindow_Calc_Log_View
    {

        #region IWindow_Calc_Log_View Implementation

        public string FullName { get => textBoxFullName.Text.Trim(); set => textBoxFullName.Text = value; }
        public string Login { get => textBoxLogin.Text.Trim(); set => textBoxLogin.Text = value; }

        public string Password { get => textBoxPassword.Text.Trim(); set => textBoxPassword.Text = value; }
        public string PasswordConfirm { get => textBoxPasswordConfirm.Text.Trim(); set => textBoxPasswordConfirm.Text = value; }

        public string Email { get => textBoxEmail.Text.Trim(); set => textBoxEmail.Text = value; }
        public string Error_Login { set => label_error_login.Text = value; }
        public bool ButtonEnabled { set => button1.Enabled = value; get => button1.Enabled; }


        public event EventHandler<EventArgs> login;
        public event EventHandler<EventArgs> register;

        public event EventHandler<EventArgs> register_validation;
        public event EventHandler<EventArgs> login_validation;

        public event EventHandler<EventArgs> ShowPetView;
        public event EventHandler<EventArgs> ShowAdmDbView;

        public void LetUserLogin()
        {
            MessageBox.Show("Wrong user name or/and password.", "Login",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void OpenMainForm(bool flag)
        {
            Window_CalculatorContext context = new Window_CalculatorContext();
            Form1 form1 = new Form1(flag);
            Window_CalcPresenter presenter = new Window_CalcPresenter(context, this, form1);//form

            form1.Show();
            this.Hide();
        }

        #endregion IWindow_Calc_Log_View Implementation

        public FormLog Form_Login { get; set; }

        public FormLog()
        {
            InitializeComponent();
            this.Width = 283;
            this.Height = 415;

            button1.Location = new Point(88, 300);
            label7.Location = new Point(30, 345);
            label1.Location = new Point(169, 345);

            label_FullName.Visible = false;
            textBoxFullName.Visible = false;
            label_error_fullname.Visible = false;

            label_error_pas_conf.Visible = false;
            textBoxPasswordConfirm.Visible = false;
            label_pas_conf.Visible = false;

            label_Email.Visible = false;
            textBoxEmail.Visible = false;
            label_error_email.Visible = false;

            //checkBoxAdminReg.Visible = false;

            labelTitle.Location = new Point(88, 93);//143
            labelTitle.Text = "LOG IN";

            label_Login.Location = new Point(63, 168);//198    -30
            textBoxLogin.Location = new Point(63, 186);//216
            label_error_login.Location = new Point(63, 210);//240

            label_Password.Location = new Point(63, 232);//262
            textBoxPassword.Location = new Point(63, 250);//280
            label_error_pas.Location = new Point(63, 276);//306
            TextBoxsChangeBind(false);
        }



        private void label1_Click(object sender, EventArgs e)
        {

            if (label1.Text == "Registration")
            {
                label_FullName.Visible = true;
                textBoxFullName.Visible = true;
                label_error_fullname.Visible = true;

                label_Email.Visible = true;
                textBoxEmail.Visible = true;
                label_error_email.Visible = true;

                label_pas_conf.Visible = true;
                textBoxPasswordConfirm.Visible = true;
                label_error_pas_conf.Visible = true;


                labelTitle.Location = new Point(88, 25);

                label_Login.Location = new Point(63, 138);//70
                textBoxLogin.Location = new Point(63, 156);//88
                label_error_login.Location = new Point(63, 183);//114

                label_Password.Location = new Point(63, 204);//136
                textBoxPassword.Location = new Point(63, 222);//154
                label_error_pas.Location = new Point(63, 249);//177

                labelTitle.Text = "SIGN UP";
                button1.Text = "Sign Up";
                label1.Text = "Login";
                label7.Text = "Have an account?";
                this.Height = 497;

                label7.Location = new Point(45, 431);
                button1.Location = new Point(95, 388);
                label1.Location = new Point(169, 431);

                TextBoxsChangeBind(true);
            }
            else if (label1.Text == "Login")
            {
                button1.Location = new Point(95, 300);
                label7.Location = new Point(30, 345);
                label1.Location = new Point(169, 345);

                label_FullName.Visible = false;
                textBoxFullName.Visible = false;
                label_error_fullname.Visible = false;

                label_Email.Visible = false;
                textBoxEmail.Visible = false;
                label_error_email.Visible = false;

                label_pas_conf.Visible = false;
                textBoxPasswordConfirm.Visible = false;
                label_error_pas_conf.Visible = false;


                labelTitle.Location = new Point(88, 93);//143

                label_Login.Location = new Point(63, 168);//198    -30
                textBoxLogin.Location = new Point(63, 186);//216
                label_error_login.Location = new Point(63, 210);//240

                label_Password.Location = new Point(63, 232);//262
                textBoxPassword.Location = new Point(63, 250);//280
                label_error_pas.Location = new Point(63, 276);//306

                labelTitle.Text = "LOG IN";
                button1.Text = "Log In";
                label1.Text = "Registration";
                label7.Text = "Don't have an account?";

                this.Height = 415;
                TextBoxsChangeBind(false);
            }

        }

        private void TextBoxsChangeBind(bool flag)
        {
            if (flag)//true == register validation on
            {
                textBoxLogin.TextChanged += textBoxReg_TextChanged;
                textBoxFullName.TextChanged += textBoxReg_TextChanged;
                textBoxPassword.TextChanged += textBoxReg_TextChanged;
                textBoxEmail.TextChanged += textBoxReg_TextChanged;
            }
            else//false == register validation off
            {
                textBoxLogin.TextChanged -= textBoxReg_TextChanged;
                textBoxFullName.TextChanged -= textBoxReg_TextChanged;
                textBoxPassword.TextChanged -= textBoxReg_TextChanged;
                textBoxEmail.TextChanged -= textBoxReg_TextChanged;
            }
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


            if (Password.Length < 3)
            {
                label_error_pas.Text = "Incorrect password length";
                valid = false;
            }
            else label_error_pas.Text = "";


            if (PasswordConfirm != Password)
            {
                label_error_pas_conf.Text = "Password mismatch";
                valid = false;
            }
            else label_error_pas_conf.Text = "";


            if (Email.Length < 4)
            {
                label_error_email.Text = "Incorrect email";
                valid = false;
            }
            else label_error_email.Text = "";


            button1.Enabled = valid;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;//
            if (button.Text.Trim() == "Log In")
            {
                login.Invoke(this, EventArgs.Empty);
                //show_menu();
            }

            if (button.Text.Trim() == "Sign Up")
            {
                register.Invoke(this, EventArgs.Empty);
            }

        }



        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxReg_TextChanged(object sender, EventArgs e)
        {
            validate_filds();
        }

        private void textBoxPasswordConfirm_TextChanged(object sender, EventArgs e)
        {
            validate_filds();
        }
    }
}
