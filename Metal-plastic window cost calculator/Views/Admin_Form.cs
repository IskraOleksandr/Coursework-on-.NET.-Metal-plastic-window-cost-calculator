using Metal_plastic_window_cost_calculator.Models;
using Metal_plastic_window_cost_calculator.Presenters;
using Metal_plastic_window_cost_calculator.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Metal_plastic_window_cost_calculator
{
    public partial class Admin_Form : Form, IAdminView
    {
        #region IAdminView Implementation

        public int Id { get; set; }
        public string Category { get; set; }
        public string Name_ { get; set; }
        public string Color_ { get; set; }
        public int CostPerMeter { get; set; }
        public string Description { get; set; }

        public string FullName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }

        public bool IsASC { get; set; }
        public string LabelDescription { set; get; }
        public object SelectedTable { get => comboBox3.SelectedItem; }
        public object SearchIn { get => comboBox1.SelectedItem; }
        public object OrderBy { get => comboBox2.SelectedItem; }
        public string SearchValue { get => textBox1.Text; }


        public event EventHandler<EventArgs> SearchEvent;
        public event EventHandler<EventArgs> load_combobox_items;
        public event EventHandler<EventArgs> SortEvent;
        public event EventHandler<EventArgs> change_table;

        public event EventHandler<EventArgs> add;
        public event EventHandler<EventArgs> edit;
        public event EventHandler<EventArgs> delete;

        public event EventHandler<EventArgs> addItemEvent;
        public event EventHandler<EventArgs> editItemEvent;
        public event EventHandler<EventArgs> deleteItemEvent;


        public void SetMaterialsListBindingSource(BindingSource mList)
        {
            dataGridView1.DataSource = mList;
        }

        public void SetComboBoxItems(List<ComboBoxItem> items, List<ComboBoxItem> items1)
        {
            comboBox1.DataSource = items;
            comboBox2.DataSource = items1;

            comboBox1.DisplayMember = "Text";
            comboBox2.DisplayMember = "Text";

            comboBox1.ValueMember = "Id";
            comboBox2.ValueMember = "Id";

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        public void SetComboBoxItems(List<ComboBoxItem> items)
        {
            comboBox3.DataSource = items;
            comboBox3.DisplayMember = "Text";
            comboBox3.ValueMember = "Id";
            comboBox3.SelectedIndex = 0;
        }

        public object getDataGridSelectedRow()
        {
            return dataGridView1.SelectedRows[0];
        }

        public void RemoveDataGridColumn(string column_Name)
        {
            dataGridView1.Columns[column_Name].Visible = false;
        }

        public void OpenAddForms(bool flag)
        {
            if (flag)
            {
                FormAddMaterial form1 = new FormAddMaterial();
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    Change_Value(form1);
                    addItemEvent.Invoke("mat", EventArgs.Empty);
                }
            }
            else
            {
                FormAddUser form1 = new FormAddUser();
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    Change_ValueUser(form1);
                    addItemEvent.Invoke("us", EventArgs.Empty);
                }
            }
        }

        public void OpenEditForms(bool flag)
        {
            if (flag)
            {
                FormAddMaterial form1 = new FormAddMaterial(dataGridView1.SelectedRows[0]);
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    Change_Value(form1);
                    editItemEvent.Invoke("mat", EventArgs.Empty);
                }
            }
            else
            {
                FormAddUser form1 = new FormAddUser(dataGridView1.SelectedRows[0]);
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    Change_ValueUser(form1);
                    editItemEvent.Invoke("us", EventArgs.Empty);
                }
            }
        }

        public void OpenDeleteForms(bool flag)//Удаление выделенного элемента
        {
            if (flag)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove the material?", "Window calculator", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    deleteItemEvent?.Invoke("mat", EventArgs.Empty);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the user?", "Window calculator", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    deleteItemEvent?.Invoke("us", EventArgs.Empty);
                }
            }
        }

        #endregion IAdminView Implementation

        private static Admin_Form instance;//Singleton pattern (Open a single form instance)

        public Admin_Form()
        {
            InitializeComponent();
        }

        private void Change_Value(FormAddMaterial form2)
        {
            Id = form2.Id;
            Category = form2.Category;
            Name_ = form2.Name_;
            Color_ = form2.Color_;
            CostPerMeter = form2.CostPerMeter;
            Description = form2.Description;
        }

        private void Change_ValueUser(FormAddUser form2)
        {
            Id = form2.Id;
            FullName = form2.FullName;
            Login = form2.Login;
            Password = form2.Password;
            PasswordConfirm = form2.PasswordConfirm;
            Email = form2.Email;
            IsAdmin = form2.IsAdmin;
        }

        public static Admin_Form GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Admin_Form();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                edit.Invoke(this, EventArgs.Empty);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            if (button.Name == "buttonSearch")
            {
                SearchEvent.Invoke(this, EventArgs.Empty);
            }

            if (button.Name == "buttonASC" && button.BackColor == Color.WhiteSmoke)
            {
                button.BackColor = Color.DodgerBlue;
                buttonDESC.BackColor = Color.WhiteSmoke;
                SortEvent.Invoke(this, EventArgs.Empty);
                IsASC = true;
            }

            if (button.Name == "buttonDESC" && button.BackColor == Color.WhiteSmoke)
            {
                button.BackColor = Color.DodgerBlue;
                buttonASC.BackColor = Color.WhiteSmoke;
                SortEvent.Invoke(this, EventArgs.Empty);
                IsASC = false;
            }

            if (button.Name == "buttonAdd")
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали товар");
                    return;
                }
                else add.Invoke(this, EventArgs.Empty);
            }

            if (button.Name == "buttonEdit")
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали товар");
                    return;
                }
                else edit.Invoke(this, EventArgs.Empty);
            }

            if (button.Name == "buttonDel")
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали товар");
                    return;
                }
                else delete.Invoke(this, EventArgs.Empty);
            }
        }

        private void Materials_Form_Load(object sender, EventArgs e)
        {
            load_combobox_items.Invoke(this, EventArgs.Empty);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchEvent.Invoke(this, EventArgs.Empty);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_table.Invoke(this, EventArgs.Empty);
        }
    }
}
