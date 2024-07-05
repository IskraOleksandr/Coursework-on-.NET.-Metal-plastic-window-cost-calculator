using System.Windows.Forms;

namespace Metal_plastic_window_cost_calculator
{
    partial class Materials_Form
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
            buttonSearch = new Button();
            label3 = new Label();
            buttonDESC = new Button();
            label2 = new Label();
            buttonASC = new Button();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            columnHeader6 = new ColumnHeader();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSearch);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(buttonDESC);
            groupBox1.Controls.Add(label2);
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
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.DodgerBlue;
            buttonSearch.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSearch.Cursor = Cursors.Hand;
            buttonSearch.FlatAppearance.BorderColor = Color.Black;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Image = Properties.Resources.icons8_search_24;
            buttonSearch.Location = new Point(197, 28);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(38, 32);
            buttonSearch.TabIndex = 27;
            buttonSearch.Tag = "DESC";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 19);
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
            buttonDESC.Location = new Point(71, 220);
            buttonDESC.Name = "buttonDESC";
            buttonDESC.Size = new Size(38, 38);
            buttonDESC.TabIndex = 26;
            buttonDESC.Tag = "DESC";
            buttonDESC.UseVisualStyleBackColor = false;
            buttonDESC.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(22, 294);
            label2.Name = "label2";
            label2.Size = new Size(0, 17);
            label2.TabIndex = 18;
            // 
            // buttonASC
            // 
            buttonASC.BackColor = Color.DodgerBlue;
            buttonASC.BackgroundImageLayout = ImageLayout.Zoom;
            buttonASC.Cursor = Cursors.Hand;
            buttonASC.FlatAppearance.BorderSize = 0;
            buttonASC.FlatStyle = FlatStyle.Flat;
            buttonASC.Image = Properties.Resources.ASCB24;
            buttonASC.Location = new Point(19, 220);
            buttonASC.Name = "buttonASC";
            buttonASC.Size = new Size(38, 38);
            buttonASC.TabIndex = 25;
            buttonASC.Tag = "ASC";
            buttonASC.UseVisualStyleBackColor = false;
            buttonASC.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 19;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(17, 164);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(210, 23);
            comboBox2.TabIndex = 24;
            comboBox2.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 78);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 21;
            label4.Text = "Search in: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 144);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 23;
            label5.Text = "Order by: ";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(17, 96);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(210, 23);
            comboBox1.TabIndex = 22;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Materials_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 484);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Materials_Form";
            Text = "Form2";
            Load += Materials_Form_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button buttonSearch;
        private Label label3;
        private Button buttonDESC;
        private Label label2;
        private Button buttonASC;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private ColumnHeader columnHeader6;
        private DataGridView dataGridView1;
    }
}