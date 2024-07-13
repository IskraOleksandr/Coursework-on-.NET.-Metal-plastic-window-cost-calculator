using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metal_plastic_window_cost_calculator.Views
{
    public partial class FormBuyWindow : Form, IBuyWindowView
    {
        
        #region IBuyWindowView Implementation

        public string TextBoxHeightText { get => textBoxHeight.Text.Trim(); set => textBoxHeight.Text = value; }
        public string TextBoxWidthText { get => textBoxWidth.Text.Trim(); set => textBoxWidth.Text = value; }
        public string TextBoxFrameText { get => textBoxFrame.Text.Trim(); set => textBoxFrame.Text = value; }
        public string Label_FullPrice { get => label_FullPrice.Text.Trim(); set => label_FullPrice.Text = value; }
        public string Label_Price { get => label_Price.Text.Trim(); set => label_Price.Text = value; }
        public bool ButtonEnabled { get => button1.Enabled; set => button1.Enabled = value; }


        public event EventHandler<EventArgs> load_datagrid_items;
        public event EventHandler<EventArgs> data_grid_frame_click;

        public event EventHandler<EventArgs> data_grid_glass_click;
        public event EventHandler<EventArgs> data_grid_furniture_click;

        public event EventHandler<EventArgs> data_grid_cart_click;
        public event EventHandler<EventArgs> text_box_text_change;
        public event EventHandler<EventArgs> showOrderPriceList;


        public void SetDataGridBindingSource(BindingSource frameList, BindingSource glassList, BindingSource furnitureList)
        {
            dataGridViewFrame.DataSource = frameList;
            dataGridViewGlass.DataSource = glassList;
            dataGridViewFurniture.DataSource = furnitureList;
        }

        public void RemoveDataGridsColumn(string column_Name)
        {
            dataGridViewFrame.Columns[column_Name].Visible = false;
            dataGridViewGlass.Columns[column_Name].Visible = false;
            dataGridViewFurniture.Columns[column_Name].Visible = false;
        }

        public object getDataGridFrameSelectedRow()
        {
            return dataGridViewFrame.SelectedRows[0];
        }

        public object getDataGridGlassSelectedRow()
        {
            return dataGridViewGlass.SelectedRows[0];
        }

        public object getDataGridFurnitureSelectedRow()
        {
            return dataGridViewFurniture.SelectedRows[0];
        }

        public object getDataGridSelectedRow()
        {
            return dataGridView1.SelectedRows[0];
        }

        public object getDataGridViewRowCollection()
        {
            return dataGridView1.Rows;
        }

        public void clearDataGrid()
        {
            dataGridView1.Columns.Clear();
        }

        public void showMessageBoxWithIcon(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void showMessageBox(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK);
        }

        public void setDataGridColums()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Category"; //текст в шапке
            column1.ReadOnly = true; //значение в этой колонке нельзя править
            column1.Name = "category"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Name";
            column2.Name = "name";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Color";
            column3.Name = "color";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Cost";
            column4.Width = 67; //ширина колонки
            column4.Name = "Cost";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
            dataGridView1.Columns.Add(column4);
            dataGridView1.AllowUserToAddRows = false;
        }

        #endregion IBuyWindowView Implementation

        private static FormBuyWindow instance;//Singleton pattern (Open a single form instance)

        public FormBuyWindow()
        {
            InitializeComponent();
            setDataGridColums();
            ButtonEnabled = false;
        }

        public static FormBuyWindow GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FormBuyWindow();
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

        private void FormBuyWindow_Load(object sender, EventArgs e)
        {
            load_datagrid_items.Invoke(this, EventArgs.Empty);
        }
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewFrame.SelectedRows.Count != 0)
            {
                data_grid_cart_click.Invoke(this, EventArgs.Empty);
            }
        }

        private void dataGridViewFrame_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewFrame.SelectedRows.Count != 0)
            {
                data_grid_frame_click.Invoke(this, EventArgs.Empty);
            }
        }

        private void dataGridViewGlass_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewGlass.SelectedRows.Count != 0)
            {
                data_grid_glass_click.Invoke(this, EventArgs.Empty);
            }
        }

        private void dataGridViewFurniture_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewFurniture.SelectedRows.Count != 0)
            {
                data_grid_furniture_click.Invoke(this, EventArgs.Empty);
            }
        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {
            text_box_text_change.Invoke(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showOrderPriceList.Invoke(this, EventArgs.Empty);
        }
    }
}
