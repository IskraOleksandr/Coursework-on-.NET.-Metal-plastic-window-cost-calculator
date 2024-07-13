using Metal_plastic_window_cost_calculator.Views;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Metal_plastic_window_cost_calculator
{
    public partial class Materials_Form : Form, IMaterialsView
    {
        #region IMaterialsView Implementation
     
        public bool IsASC { get; set; }
        public string LabelDescription { set => label2.Text = value; }
        public object SearchIn { get => comboBox1.SelectedItem; }

        public object OrderBy { get => comboBox2.SelectedItem; }
        public string SearchValue { get => textBox1.Text; }


        public event EventHandler<EventArgs> SearchEvent;
        public event EventHandler<EventArgs> get_material_desc;

        public event EventHandler<EventArgs> load_combobox_items;
        public event EventHandler<EventArgs> SortEvent;

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
        public void RemoveDataGridColumn(string column_Name)
        {
            dataGridView1.Columns[column_Name].Visible = false;
        }

        #endregion IMaterialsView Implementation

        private static Materials_Form instance;//Singleton pattern (Open a single form instance)
        public Materials_Form()
        {
            InitializeComponent();
        }



        public static Materials_Form GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Materials_Form();
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
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                get_material_desc.Invoke(row.Cells["Id"].Value.ToString(), EventArgs.Empty);
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

        }

        private void Materials_Form_Load(object sender, EventArgs e)
        {
            load_combobox_items.Invoke(this, EventArgs.Empty);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //System.Windows.Forms.ComboBox box = sender as System.Windows.Forms.ComboBox;

            //if (box.Name == "comboBox1")
            //{
            //    SearchEvent.Invoke(this, EventArgs.Empty);
            //}

            //if (box.Name == "comboBox2")
            //{
            //    SearchEvent.Invoke(this, EventArgs.Empty);
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchEvent.Invoke(this, EventArgs.Empty);
        }
    }
}
