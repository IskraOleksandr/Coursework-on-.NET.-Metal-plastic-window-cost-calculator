using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Metal_plastic_window_cost_calculator.Views
{
    public partial class FormAddMaterial : Form/*, IAddMaterialView*/
    {
        private bool edit { get; set; }
        public FormAddMaterial()
        {
            InitializeComponent();
            labelTitle.Text = "Add new material";
            enable_button(false);
            Id = 0;
        }

        public FormAddMaterial(object obj)
        {
            InitializeComponent();
            enable_button(false);

            labelTitle.Text = "Add new material";

            var row = obj as DataGridViewRow;
            Id = Convert.ToInt32(row.Cells["Id"].Value);
            Category = row.Cells["Category"].Value.ToString();
            Name_ = row.Cells["Name"].Value.ToString();
            Color_ = row.Cells["Color"].Value.ToString();
            CostPerMeter = Convert.ToInt32(row.Cells["CostPerMeter"].Value);
            Description = row.Cells["Description"].Value.ToString();
        }
        public int Id { get; set; }
        public string Category
        {
            get => textBoxCategory.Text.Trim();
            set => textBoxCategory.Text = value;
        }
         
        public string Name_
        {
            get => textBoxName.Text.Trim();
            set => textBoxName.Text = value;
        }
         
        public string Color_
        {
            get => textBoxColor.Text.Trim();
            set => textBoxColor.Text = value;
        }
         
        public int CostPerMeter
        {
            get => ((int)numericCostPerMetr.Value);
            set => numericCostPerMetr.Value = value;
        }
        
        public string Description
        {
            get => textBoxDescription.Text.Trim();
            set => textBoxDescription.Text = value;
        }
 
        private void buttonAdd_Click(object sender, EventArgs e)
        { 
            DialogResult = DialogResult.OK;
        }

        private void textBoxCategory_TextChanged(object sender, EventArgs e)
        { 
            validate_filds();
        }

        private void validate_filds()
        {
            bool valid = true;

            if (Category.Length <= 3)
            {
                label_error_category.Text = "error";
                valid = false;
            }
            else label_error_category.Text = "";


            if (Name_.Length <= 3)
            {
                label_error_name.Text = "error";
                valid = false;
            }
            else label_error_name.Text = "";


            if (Color_.Length < 3)
            {
                label_error_color.Text = "error";
                valid = false;
            }
            else label_error_color.Text = "";


            if (CostPerMeter <= 0)
            {
                label_error_cost.Text = "error";
                valid = false;
            }
            else label_error_cost.Text = "";


            if (Description.Length < 1)
            {
                label_error_description.Text = "error";
                valid = false;
            }
            else label_error_description.Text = "";


            enable_button(valid);
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
