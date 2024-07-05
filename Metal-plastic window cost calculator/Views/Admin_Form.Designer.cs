using System.Windows.Forms;

namespace Metal_plastic_window_cost_calculator
{
    partial class Admin_Form
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            comboBox3 = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            buttonDESC = new Button();
            buttonASC = new Button();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            columnHeader6 = new ColumnHeader();
            dataGridView1 = new DataGridView();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDel = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonDel);
            groupBox1.Controls.Add(buttonEdit);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(buttonDESC);
            groupBox1.Controls.Add(buttonASC);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(673, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 484);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 24);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 28;
            label1.Text = "Select table: ";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(17, 42);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(210, 23);
            comboBox3.TabIndex = 29;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.icons8_search_24;
            button1.Location = new Point(198, 86);
            button1.Name = "button1";
            button1.Size = new Size(38, 32);
            button1.TabIndex = 27;
            button1.Tag = "DESC";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 77);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 20;
            label3.Text = "Search: ";
            // 
            // buttonDESC
            // 
            buttonDESC.BackColor = Color.WhiteSmoke;
            buttonDESC.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDESC.Cursor = Cursors.Hand;
            buttonDESC.FlatAppearance.BorderColor = Color.Black;
            buttonDESC.FlatAppearance.BorderSize = 0;
            buttonDESC.FlatStyle = FlatStyle.Flat;
            buttonDESC.Image = Properties.Resources.DESCB24;
            buttonDESC.Location = new Point(70, 251);
            buttonDESC.Name = "buttonDESC";
            buttonDESC.Size = new Size(38, 38);
            buttonDESC.TabIndex = 26;
            buttonDESC.Tag = "DESC";
            buttonDESC.UseVisualStyleBackColor = false;
            buttonDESC.Click += button1_Click;
            // 
            // buttonASC
            // 
            buttonASC.BackColor = Color.DodgerBlue;
            buttonASC.BackgroundImageLayout = ImageLayout.Zoom;
            buttonASC.Cursor = Cursors.Hand;
            buttonASC.FlatAppearance.BorderSize = 0;
            buttonASC.FlatStyle = FlatStyle.Flat;
            buttonASC.Image = Properties.Resources.ASCB24;
            buttonASC.Location = new Point(18, 251);
            buttonASC.Name = "buttonASC";
            buttonASC.Size = new Size(38, 38);
            buttonASC.TabIndex = 25;
            buttonASC.Tag = "ASC";
            buttonASC.UseVisualStyleBackColor = false;
            buttonASC.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 19;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(17, 212);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(210, 23);
            comboBox2.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 136);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 21;
            label4.Text = "Search in: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 192);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 23;
            label5.Text = "Sort by: ";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(17, 154);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(210, 23);
            comboBox1.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(673, 484);
            dataGridView1.TabIndex = 31;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Green;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(18, 295);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(209, 38);
            buttonAdd.TabIndex = 30;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.Goldenrod;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Location = new Point(18, 339);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(209, 38);
            buttonEdit.TabIndex = 31;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonDel
            // 
            buttonDel.BackColor = Color.Red;
            buttonDel.FlatAppearance.BorderSize = 0;
            buttonDel.FlatStyle = FlatStyle.Flat;
            buttonDel.ForeColor = Color.White;
            buttonDel.Location = new Point(18, 383);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(209, 38);
            buttonDel.TabIndex = 32;
            buttonDel.Text = "Delete";
            buttonDel.UseVisualStyleBackColor = false;
            // 
            // Admin_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 484);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin_Form";
            Text = "Form2";
            Load += Materials_Form_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button button1;
        private Label label3;
        private Button buttonDESC;
        private Button buttonASC;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private ColumnHeader columnHeader6;
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox comboBox3;
        private Button buttonEdit;
        private Button buttonAdd;
        private Button buttonDel;
    }
}