using Metal_plastic_window_cost_calculator.Models;
using Metal_plastic_window_cost_calculator.Presenters;
using Metal_plastic_window_cost_calculator.Repository;
using Metal_plastic_window_cost_calculator.Views;
using System.Windows.Forms;

namespace Metal_plastic_window_cost_calculator
{
    public partial class FormLog : Form, IWindow_Calc_Log_View
    {
        public FormLog Form_Login { get; set; }
        #region IWindow_Calculator_View Implementation

        public string Login { get => textBoxLogin.Text.Trim(); set => textBoxLogin.Text = value; }
        public string Error_Login { set => label_error_login.Text = value; }

        public string Password { get => textBoxPassword.Text.Trim(); set => textBoxPassword.Text = value; }
        public string FullName { get => textBoxFullName.Text.Trim(); set => textBoxFullName.Text = value; }
        public string Email { get => textBoxEmail.Text.Trim(); set => textBoxEmail.Text = value; }
        public bool IsAdmin { get => checkBoxAdminReg.Checked; set => checkBoxAdminReg.Checked = value; }


        public event EventHandler<EventArgs> login;
        public event EventHandler<EventArgs> register;
        public event EventHandler<EventArgs> register_validation;
        public event EventHandler<EventArgs> login_validation;


        public void LetUserLogin()
        {
            MessageBox.Show("Wrong user name or/and password.", "Login",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion IWindow_Calculator_View Implementation
        public FormLog()
        {
            InitializeComponent();
            this.Width = 283;
            this.Height = 443;

            label_FullName.Visible = false;
            textBoxFullName.Visible = false;
            label_error_fullname.Visible = false;

            label_Email.Visible = false;
            textBoxEmail.Visible = false;
            label_error_email.Visible = false;

            checkBoxAdminReg.Visible = false;

            labelTitle.Location = new Point(88, 143);
            labelTitle.Text = "LOG IN";

            label_Login.Location = new Point(63, 198);
            textBoxLogin.Location = new Point(63, 216);
            label_error_login.Location = new Point(63, 240);

            label_Password.Location = new Point(63, 262);
            textBoxPassword.Location = new Point(63, 280);
            label_error_pas.Location = new Point(63, 306);
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

                checkBoxAdminReg.Visible = true;

                labelTitle.Location = new Point(88, 25);

                label_Login.Location = new Point(63, 70);
                textBoxLogin.Location = new Point(63, 88);
                label_error_login.Location = new Point(63, 114);

                label_Password.Location = new Point(63, 136);
                textBoxPassword.Location = new Point(63, 154);
                label_error_pas.Location = new Point(63, 177);

                labelTitle.Text = "SIGN UP";
                button1.Text = "Sign Up";
                label1.Text = "Login";
                label7.Text = "Have an account?";

                TextBoxsChangeBind(true);
            }
            else if (label1.Text == "Login")
            {
                label_FullName.Visible = false;
                textBoxFullName.Visible = false;
                label_error_fullname.Visible = false;

                label_Email.Visible = false;
                textBoxEmail.Visible = false;
                label_error_email.Visible = false;

                checkBoxAdminReg.Visible = false;

                labelTitle.Location = new Point(88, 143);

                label_Login.Location = new Point(63, 198);
                textBoxLogin.Location = new Point(63, 216);
                label_error_login.Location = new Point(63, 240);

                label_Password.Location = new Point(63, 262);
                textBoxPassword.Location = new Point(63, 280);
                label_error_pas.Location = new Point(63, 306);

                labelTitle.Text = "LOG IN";
                button1.Text = "Log In";
                label1.Text = "Registration";
                label7.Text = "Don't have an account?";

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

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;//
            if (button.Text.Trim() == "Log In")
            {
                login.Invoke(this, EventArgs.Empty);
                //show_menu();
            }
            else if (button.Text.Trim() == "Sign Up")
            {
                register.Invoke(this, EventArgs.Empty);
            }
        }

        public void LetLogin()
        {
            MessageBox.Show("Wrong user name or/and password.", "Login",
                 MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        public void OpenMainForm()
        {
            Window_CalculatorContext context = new Window_CalculatorContext();
            Window_CalculatorRepository rep = new(context);
            Form1 form1 = new Form1();
            Window_CalculatorPresenter presenter = new Window_CalculatorPresenter(rep, form1);//form
          
            form1.Show();//
            this.Hide();
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxReg_TextChanged(object sender, EventArgs e)
        {
            register_validation.Invoke(this, EventArgs.Empty);
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            login_validation.Invoke(this, EventArgs.Empty);
        }

       
    }
}
