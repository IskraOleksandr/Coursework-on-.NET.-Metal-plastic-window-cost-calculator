namespace Metal_plastic_window_cost_calculator.Views
{
    partial class FormAddMaterial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_error_cost = new Label();
            label_error_color = new Label();
            label_error_name = new Label();
            label_error_category = new Label();
            textBoxName = new TextBox();
            label_Category = new Label();
            label_Name = new Label();
            labelTitle = new Label();
            label_CostPerMetr = new Label();
            label_Color = new Label();
            textBoxColor = new TextBox();
            buttonAdd = new Button();
            label_error_description = new Label();
            label_Description = new Label();
            textBoxDescription = new TextBox();
            numericCostPerMetr = new NumericUpDown();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericCostPerMetr).BeginInit();
            SuspendLayout();
            // 
            // label_error_cost
            // 
            label_error_cost.AutoSize = true;
            label_error_cost.ForeColor = Color.Red;
            label_error_cost.Location = new Point(45, 289);
            label_error_cost.Name = "label_error_cost";
            label_error_cost.Size = new Size(0, 15);
            label_error_cost.TabIndex = 31;
            // 
            // label_error_color
            // 
            label_error_color.AutoSize = true;
            label_error_color.ForeColor = Color.Red;
            label_error_color.Location = new Point(45, 223);
            label_error_color.Name = "label_error_color";
            label_error_color.Size = new Size(0, 15);
            label_error_color.TabIndex = 30;
            // 
            // label_error_name
            // 
            label_error_name.AutoSize = true;
            label_error_name.ForeColor = Color.Red;
            label_error_name.Location = new Point(45, 160);
            label_error_name.Name = "label_error_name";
            label_error_name.Size = new Size(0, 15);
            label_error_name.TabIndex = 29;
            // 
            // label_error_category
            // 
            label_error_category.AutoSize = true;
            label_error_category.ForeColor = Color.Red;
            label_error_category.Location = new Point(45, 97);
            label_error_category.Name = "label_error_category";
            label_error_category.Size = new Size(0, 15);
            label_error_category.TabIndex = 28;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(45, 137);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(188, 23);
            textBoxName.TabIndex = 19;
            textBoxName.TextChanged += textBoxCategory_TextChanged;
            // 
            // label_Category
            // 
            label_Category.AutoSize = true;
            label_Category.Location = new Point(45, 53);
            label_Category.Name = "label_Category";
            label_Category.Size = new Size(58, 15);
            label_Category.TabIndex = 20;
            label_Category.Text = "Category:";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(45, 119);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(42, 15);
            label_Name.TabIndex = 21;
            label_Name.Text = "Name:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.Location = new Point(71, 18);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(131, 26);
            labelTitle.TabIndex = 27;
            labelTitle.Text = "New Material";
            // 
            // label_CostPerMetr
            // 
            label_CostPerMetr.AutoSize = true;
            label_CostPerMetr.Location = new Point(45, 245);
            label_CostPerMetr.Name = "label_CostPerMetr";
            label_CostPerMetr.Size = new Size(76, 15);
            label_CostPerMetr.TabIndex = 25;
            label_CostPerMetr.Text = "CostPerMetr:";
            // 
            // label_Color
            // 
            label_Color.AutoSize = true;
            label_Color.Location = new Point(45, 181);
            label_Color.Name = "label_Color";
            label_Color.Size = new Size(39, 15);
            label_Color.TabIndex = 23;
            label_Color.Text = "Color:";
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(45, 199);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(188, 23);
            textBoxColor.TabIndex = 22;
            textBoxColor.TextChanged += textBoxCategory_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.DodgerBlue;
            buttonAdd.FlatAppearance.BorderColor = Color.White;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(97, 420);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 27);
            buttonAdd.TabIndex = 18;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label_error_description
            // 
            label_error_description.AutoSize = true;
            label_error_description.ForeColor = Color.Red;
            label_error_description.Location = new Point(45, 386);
            label_error_description.Name = "label_error_description";
            label_error_description.Size = new Size(0, 15);
            label_error_description.TabIndex = 34;
            // 
            // label_Description
            // 
            label_Description.AutoSize = true;
            label_Description.Location = new Point(45, 304);
            label_Description.Name = "label_Description";
            label_Description.Size = new Size(70, 15);
            label_Description.TabIndex = 33;
            label_Description.Text = "Description:";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Cursor = Cursors.IBeam;
            textBoxDescription.Location = new Point(45, 322);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ScrollBars = ScrollBars.Vertical;
            textBoxDescription.Size = new Size(188, 61);
            textBoxDescription.TabIndex = 32;
            textBoxDescription.TextChanged += textBoxCategory_TextChanged;
            // 
            // numericCostPerMetr
            // 
            numericCostPerMetr.InterceptArrowKeys = false;
            numericCostPerMetr.Location = new Point(45, 263);
            numericCostPerMetr.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericCostPerMetr.Name = "numericCostPerMetr";
            numericCostPerMetr.Size = new Size(188, 23);
            numericCostPerMetr.TabIndex = 35;
            numericCostPerMetr.ValueChanged += textBoxCategory_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(45, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 23);
            comboBox1.TabIndex = 36;
            comboBox1.SelectedIndexChanged += textBoxCategory_TextChanged;
            // 
            // FormAddMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 459);
            Controls.Add(comboBox1);
            Controls.Add(numericCostPerMetr);
            Controls.Add(label_error_description);
            Controls.Add(textBoxDescription);
            Controls.Add(label_Description);
            Controls.Add(label_error_cost);
            Controls.Add(label_error_color);
            Controls.Add(label_error_name);
            Controls.Add(label_error_category);
            Controls.Add(textBoxName);
            Controls.Add(label_Category);
            Controls.Add(label_Name);
            Controls.Add(labelTitle);
            Controls.Add(label_CostPerMetr);
            Controls.Add(label_Color);
            Controls.Add(textBoxColor);
            Controls.Add(buttonAdd);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormAddMaterial";
            Text = "Add new material";
            ((System.ComponentModel.ISupportInitialize)numericCostPerMetr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_error_cost;
        private Label label_error_color;
        private Label label_error_name;
        private Label label_error_category;
        private TextBox textBoxName;
        private Label label_Category;
        private Label label_Name;
        private Label labelTitle;
        private Label label_CostPerMetr;
        private TextBox textBoxCostPerMetr;
        private Label label_Color;
        private TextBox textBoxColor;
        private Button buttonAdd;
        private Label label_error_description;
        private Label label_Description;
        private TextBox textBoxDescription;
        private NumericUpDown numericCostPerMetr;
        private ComboBox comboBox1;
    }
}