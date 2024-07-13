using Metal_plastic_window_cost_calculator.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Metal_plastic_window_cost_calculator
{
    public partial class Form1 : Form, IWindow_Calculator_View
    {
        #region IWindow_Calculator_View Implementation


        public event EventHandler<EventArgs> ShowPetView;
        public event EventHandler<EventArgs> ShowAdmDbView;
        public event EventHandler<EventArgs> ShowBuyWindowView;

        #endregion IWindow_Calculator_View Implementation
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(bool flag)
        {
            InitializeComponent();
            buttonEditDb.Visible = flag;
        }



        public void show_menu()
        {
            this.Width = 1010;
            this.Height = 560;
        }

        public void hide_button()
        {
            buttonEditDb.Visible = false;
        }

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            if (button.Name == "buttonWindCalc")
            {
                buttonWindCalc.BackColor= Color.DodgerBlue;
                buttonEditDb.BackColor = Color.FromArgb(36, 40, 87);
                buttonMaterials.BackColor = Color.FromArgb(36, 40, 87);
                buttonHome.BackColor = Color.FromArgb(36, 40, 87);
                ShowBuyWindowView.Invoke(this, EventArgs.Empty);
            }
        }

    }
}
