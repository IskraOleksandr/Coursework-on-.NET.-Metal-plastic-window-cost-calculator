using Metal_plastic_window_cost_calculator.Models;
using Metal_plastic_window_cost_calculator.Presenters;
using Metal_plastic_window_cost_calculator.Repository;
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
    public partial class Admin_Form : Form, IAdminView/*, IMaterialsView*/
    {
        //Singleton pattern (Open a single form instance)
        private static Admin_Form instance;

        public event EventHandler<EventArgs> SearchEvent;
        public event EventHandler<EventArgs> get_material_desc;
        public event EventHandler<EventArgs> load_combobox_items;
        public event EventHandler<EventArgs> SortEvent;
        public event EventHandler<EventArgs> change_table;
        public event EventHandler<EventArgs> editMEvent;

        public bool IsASC { get; set; }
        public string LabelDescription { set; get; }
        public object SelectedTable { get => comboBox3.SelectedItem; }
        public object SearchIn { get => comboBox1.SelectedItem; }
        public object OrderBy { get => comboBox2.SelectedItem; }
        public string SearchValue { get => textBox1.Text; }

        public Admin_Form()
        {
            InitializeComponent();
        }

        public void OpenAddMatForm()
        {
            Window_CalculatorContext context = new Window_CalculatorContext();
            Window_CalculatorRepository rep = new(context);
            FormAddMaterial form1 = new FormAddMaterial();
            CRUD_Presenter presenter = new CRUD_Presenter(form1, context);//form

            if (form1.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("Ok, got you.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                get_material_desc.Invoke(this, EventArgs.Empty);
            }
        }

        public void OpenEditMatForm()
        {
            Window_CalculatorContext context = new Window_CalculatorContext();
            Window_CalculatorRepository rep = new(context);
            
            DataGridViewRow row = this.dataGridView1.SelectedRows[0];
            FormAddMaterial form1 = new FormAddMaterial(true);
            //form1.Category
            CRUD_Presenter presenter = new CRUD_Presenter(form1, context);//form

            if (form1.ShowDialog() == DialogResult.OK)
            {
                if (dataGridView1.SelectedRows.Count != 0)
                {
                    
                    get_material_desc.Invoke(row, EventArgs.Empty);
                }
                //get_material_desc.Invoke(this, EventArgs.Empty);
            }
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

        public void SetMaterialsListBindingSource(BindingSource mList)
        {
            dataGridView1.DataSource = mList;
        }


        public void Add_To_List(ListViewItem value)
        {
            //listView1.Items.Add(value);
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

        public void ClearListView()
        {
            //listView1.Items.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                get_material_desc.Invoke(row.Cells["Id"].Value.ToString(), EventArgs.Empty);
            }
        }

        public void RemoveDataGridColumn(string column_Name)
        {
            dataGridView1.Columns[column_Name].Visible = false;
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
                OpenAddMatForm();
                //SortEvent.Invoke(this, EventArgs.Empty);
            }
            if (button.Name == "buttonEdit")
            {
                if (dataGridView1.SelectedRows.Count != 0)
                {
                    DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                    editMEvent.Invoke(row, EventArgs.Empty);
                }
                //OpenAddMatForm();
                //SortEvent.Invoke(this, EventArgs.Empty);
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
