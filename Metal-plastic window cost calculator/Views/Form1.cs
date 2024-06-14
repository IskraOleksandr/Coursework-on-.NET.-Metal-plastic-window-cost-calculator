using Metal_plastic_window_cost_calculator.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Metal_plastic_window_cost_calculator
{
    public partial class Form1 : Form, IWindow_Calculator_View
    {
        #region IWindow_Calculator_View Implementation



        public string LabelDescription { set => label2.Text = value; }
        public System.Windows.Forms.ListView ListView { get => listView1; set => listView1 = value; }

        public event EventHandler<EventArgs> get_material_desc;
        public event EventHandler<EventArgs> show_materials;

        public void LetUserLogin()
        {
            MessageBox.Show("Wrong user name or/and password.", "Login",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion IWindow_Calculator_View Implementation
        public Form1()
        {
            InitializeComponent();

            this.Hide();//
            // get_material_desc.Invoke(this, EventArgs.Empty);
            
            //this.Width = 283;
            //this.Height = 443;
            //show_menu();
            //listView1.Visible = false;

        }




        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Button button = sender as Button;//
        //    if (button.Text.Trim() == "Log In")
        //    {
        //        login.Invoke(this, EventArgs.Empty);
        //        //show_menu();
        //    }
        //    else if (button.Text.Trim() == "Sign Up")
        //    {
        //        register.Invoke(this, EventArgs.Empty);
        //    }
        //}


        //private void textBoxReg_TextChanged(object sender, EventArgs e)
        //{
        //    register_validation.Invoke(this, EventArgs.Empty);
        //}

        //private void textBoxLogin_TextChanged(object sender, EventArgs e)
        //{
        //    login_validation.Invoke(this, EventArgs.Empty);
        //}

        public void show_menu()
        {
            this.Width = 1010;
            this.Height = 560;


            listView1.Visible = true;
            //show_materials.Invoke(this, EventArgs.Empty);
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Int32 i = Convert.ToInt32(e.Column.ToString());//
            MessageBox.Show(listView1.Columns[i].Text);//Admin
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            int index = listView1.FocusedItem.Index;
            get_material_desc.Invoke(listView1.Items[index].Text, EventArgs.Empty);
            //MessageBox.Show(listView1.Items[index].Text +"");Admin
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            //FormLog f= new FormLog();
            //f.Close();Admin
            //windows forms c# как открыть первой форму входа, а после входа открыть главную форму и чтоб при закритии главной формы закрилась и форма входа
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*show_materials*///
            show_materials.Invoke(this, EventArgs.Empty);
        }
    }
}
