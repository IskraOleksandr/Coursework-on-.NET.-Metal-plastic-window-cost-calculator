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
    public partial class FormAddMaterial : Form, IAddMaterialView
    {
        private bool edit {  get; set; }
        public FormAddMaterial()
        {
            InitializeComponent();
            edit = false;
            enable_button(false);
        }

        public FormAddMaterial(bool isEdit)
        {
            InitializeComponent();
            enable_button(false);
            edit = isEdit;
            //var row = obj as DataGridViewRow;
        }

        public string Category { get => textBoxCategory.Text.Trim(); set => textBoxCategory.Text = value; }
        public string LabelError_Category { get => label_error_category.Text.Trim(); set => label_error_category.Text = value; }


        public string Name_ { get => textBoxName.Text.Trim(); set => textBoxName.Text = value; }
        public string LabelError_Name { get => label_error_name.Text.Trim(); set => label_error_name.Text = value; }


        public string Color_ { get => textBoxColor.Text.Trim(); set => textBoxColor.Text = value; }
        public string LabelError_Color { get => label_error_color.Text.Trim(); set => label_error_color.Text = value; }


        public int CostPerMeter
        {
            get => ((int)numericCostPerMetr.Value);
            set => numericCostPerMetr.Value = value;
        }
        public string LabelError_CostPerMeter { get => label_error_cost.Text.Trim(); set => label_error_cost.Text = value; }


        public string Description { get => textBoxDescription.Text.Trim(); set => textBoxDescription.Text = value; }
        public string LabelError_Description { get => label_error_description.Text.Trim(); set => label_error_description.Text = value; }


        public event EventHandler<EventArgs> addMaterial;
        public event EventHandler<EventArgs> validation_filds;
        public event EventHandler<EventArgs> editMaterial;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(edit == true)
            {
                editMaterial.Invoke(this, new EventArgs());
            }
            else addMaterial.Invoke(this, new EventArgs());

            DialogResult = DialogResult.OK;
        }

        private void textBoxCategory_TextChanged(object sender, EventArgs e)
        {
            //buttonAdd.Enabled = Category.Length >= 3 && Name.Length >= 6;
            validation_filds.Invoke(this, new EventArgs());
        }

        public void enable_button(bool off_on_flag)
        {
            if (off_on_flag)
            {
                buttonAdd.Enabled = true;
            }
            else
            {
                buttonAdd.Enabled = false;
            }
        }
    }
}
