namespace Metal_plastic_window_cost_calculator
{
    public partial class Form1 : Form, IWindow_Calculator_View
    {
        #region IWindow_Calculator_View Implementation

        public string Login { get => textBoxLogin.Text.Trim(); set => textBoxLogin.Text = value; }
        public string Password { get => textBoxPassword.Text.Trim(); set => textBoxPassword.Text = value; }
        public string FullName { get => textBoxFullName.Text.Trim(); set => textBoxFullName.Text = value; }
        public string Email { get => textBoxEmail.Text.Trim(); set => textBoxEmail.Text = value; }
        public bool IsAdmin { get => checkBoxAdminReg.Checked; set => checkBoxAdminReg.Checked = value; }

        public event EventHandler<EventArgs> login;
        public event EventHandler<EventArgs> register;
        public event EventHandler<EventArgs> register_validation;

        public void LetUserLogin()
        {
            MessageBox.Show("Wrong user name or/and password.", "Login",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion IWindow_Calculator_View Implementation
        public Form1()
        {
            InitializeComponent();
            label_FullName.Visible = false;
            textBoxFullName.Visible = false;
            label_Email.Visible = false;
            textBoxEmail.Visible = false;
            checkBoxAdminReg.Visible = false;

            labelTitle.Location = new Point(87, 154);
            labelTitle.Text = "LOG IN";

            label_Login.Location = new Point(63, 193);
            textBoxLogin.Location = new Point(63, 211);

            label_Password.Location = new Point(63, 243);
            textBoxPassword.Location = new Point(63, 261);
        }



        private void label1_Click(object sender, EventArgs e)
        {

            if (label1.Text == "Registration")
            {
                label_FullName.Visible = true;
                textBoxFullName.Visible = true;
                label_Email.Visible = true;
                textBoxEmail.Visible = true;
                checkBoxAdminReg.Visible = true;

                labelTitle.Location = new Point(97, 53);

                label_Login.Location = new Point(63, 95);
                textBoxLogin.Location = new Point(63, 113);

                label_Password.Location = new Point(63, 145);
                textBoxPassword.Location = new Point(63, 163);
                labelTitle.Text = "SIGN UP";
                button1.Text = "Sign Up";
                label1.Text = "Login";
                label7.Text = "Have an account?";
            }
            else if (label1.Text == "Login")
            {
                label_FullName.Visible = false;
                textBoxFullName.Visible = false;
                label_Email.Visible = false;
                textBoxEmail.Visible = false;
                checkBoxAdminReg.Visible = false;

                labelTitle.Location = new Point(87, 154);

                label_Login.Location = new Point(63, 193);
                textBoxLogin.Location = new Point(63, 211);

                label_Password.Location = new Point(63, 243);
                textBoxPassword.Location = new Point(63, 261);
                labelTitle.Text = "LOG IN";
                button1.Text = "Log In";
                label1.Text = "Registration";
                label7.Text = "Don't have an account?";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;//
            if (button.Text.Trim() == "Log In")
            {
                login.Invoke(this, EventArgs.Empty);
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

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            register_validation.Invoke(this, EventArgs.Empty);
        }
    }
}
