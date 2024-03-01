namespace Metal_plastic_window_cost_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
