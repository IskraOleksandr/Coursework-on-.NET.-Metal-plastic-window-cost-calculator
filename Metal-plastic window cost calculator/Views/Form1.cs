using Metal_plastic_window_cost_calculator.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Metal_plastic_window_cost_calculator
{
    public partial class Form1 : Form, IWindow_Calculator_View
    {
        #region IWindow_Calculator_View Implementation


        public event EventHandler<EventArgs> ShowPetView;
        public event EventHandler<EventArgs> ShowAdmDbView;

        //public string LabelDescription { set => label2.Text = value; }
        //public System.Windows.Forms.ListView ListView { get => listView1; set => listView1 = value; }

        //public event EventHandler<EventArgs> get_material_desc;
        //public event EventHandler<EventArgs> show_materials;

        public void LetUserLogin()
        {
            MessageBox.Show("Wrong user name or/and password.", "Login",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion IWindow_Calculator_View Implementation
        public Form1()
        {
            InitializeComponent();

            //this.Hide();
            // get_material_desc.Invoke(this, EventArgs.Empty);

            //this.Width = 283;
            //this.Height = 443;
            //show_menu();
            //listView1.Visible = false;

        }



        public void show_menu()
        {
            this.Width = 1010;
            this.Height = 560;


            //listView1.Visible = true;
            //show_materials.Invoke(this, EventArgs.Empty);
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
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                {
                    c.BackColor = Color.White;
                }
            }
        }

        private void button_Menu_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;

            if (button.Name == "buttonHome")
            {
                buttonHome.BackColor = Color.DodgerBlue;
                buttonMaterials.BackColor = Color.FromArgb(36, 40, 87);
                buttonEditDb.BackColor = Color.FromArgb(36, 40, 87);
                buttonWindCalc.BackColor = Color.FromArgb(36, 40, 87);
            }

            if (button.Name == "buttonWindCalc")
            {
                buttonWindCalc.BackColor = Color.DodgerBlue;
                buttonMaterials.BackColor = Color.FromArgb(36, 40, 87);
                buttonEditDb.BackColor = Color.FromArgb(36, 40, 87);
                buttonHome.BackColor = Color.FromArgb(36, 40, 87);
            }

            if (button.Name == "buttonMaterials")
            {
                buttonMaterials.BackColor = Color.DodgerBlue;
                buttonEditDb.BackColor = Color.FromArgb(36, 40, 87);
                buttonHome.BackColor = Color.FromArgb(36, 40, 87);
                buttonWindCalc.BackColor = Color.FromArgb(36, 40, 87);
                ShowPetView.Invoke(this, EventArgs.Empty);
            }

            if (button.Name == "buttonEditDb")
            {
                buttonEditDb.BackColor = Color.DodgerBlue;
                buttonMaterials.BackColor = Color.FromArgb(36, 40, 87);
                buttonHome.BackColor = Color.FromArgb(36, 40, 87);
                buttonWindCalc.BackColor = Color.FromArgb(36, 40, 87);
                ShowAdmDbView.Invoke(this, EventArgs.Empty);
            }
        }

    }
}
