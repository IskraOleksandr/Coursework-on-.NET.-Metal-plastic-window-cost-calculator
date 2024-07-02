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
    public partial class Admin_Form : Form/*, IMaterialsView*/
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        //Singleton pattern (Open a single form instance)
        private static Admin_Form instance;

        public event EventHandler<EventArgs> SearchEvent;
        public event EventHandler<EventArgs> get_material_desc;
        public string LabelDescription { set => label2.Text = value; }
        public string SearchValue { get; set; }

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
            //listView1.Dats = mList;
        }

        public void Add_To_List(ListViewItem value)
        {
            //listView1.Items.Add(value);
        }

        public void ClearListView()
        {
            //listView1.Items.Clear();
        }

        //private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        //{
        //    Int32 i = Convert.ToInt32(e.Column.ToString());//
        //    MessageBox.Show(listView1.Columns[i].Text);//Admin//
        //}

        private void listView1_Click(object sender, EventArgs e)
        {
            //int index = listView1.FocusedItem.Index;
            //get_material_desc.Invoke(listView1.Items[index].Text, EventArgs.Empty);
            //Admin
        }

        public void RemoveDataGridColumn(string column_Name)
        {
            dataGridView1.Columns[column_Name].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
