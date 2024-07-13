namespace Metal_plastic_window_cost_calculator.Views
{
    partial class FormBuyWindow
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
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label_Price = new Label();
            label17 = new Label();
            label18 = new Label();
            label_FullPrice = new Label();
            label14 = new Label();
            label13 = new Label();
            button1 = new Button();
            dataGridViewFurniture = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            dataGridViewGlass = new DataGridView();
            label4 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            dataGridViewFrame = new DataGridView();
            label5 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            label12 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            textBoxHeight = new TextBox();
            textBoxWidth = new TextBox();
            textBoxFrame = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFurniture).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGlass).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFrame).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(19, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 30);
            label1.TabIndex = 0;
            label1.Text = "Materials";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(390, 36);
            label2.Name = "label2";
            label2.Size = new Size(54, 30);
            label2.TabIndex = 1;
            label2.Text = "Cart";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(390, 69);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(379, 220);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += dataGridView_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label_Price);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label_FullPrice);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(390, 295);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 151);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // label_Price
            // 
            label_Price.AutoSize = true;
            label_Price.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_Price.Location = new Point(121, 88);
            label_Price.Name = "label_Price";
            label_Price.Size = new Size(25, 29);
            label_Price.TabIndex = 6;
            label_Price.Text = "0";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label17.Location = new Point(97, 88);
            label17.Name = "label17";
            label17.Size = new Size(25, 29);
            label17.TabIndex = 5;
            label17.Text = "$";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label18.Location = new Point(56, 92);
            label18.Name = "label18";
            label18.Size = new Size(44, 21);
            label18.TabIndex = 4;
            label18.Text = "Price";
            // 
            // label_FullPrice
            // 
            label_FullPrice.AutoSize = true;
            label_FullPrice.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_FullPrice.Location = new Point(121, 50);
            label_FullPrice.Name = "label_FullPrice";
            label_FullPrice.Size = new Size(29, 33);
            label_FullPrice.TabIndex = 3;
            label_FullPrice.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label14.Location = new Point(97, 49);
            label14.Name = "label14";
            label14.Size = new Size(29, 33);
            label14.TabIndex = 2;
            label14.Text = "$";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label13.Location = new Point(27, 54);
            label13.Name = "label13";
            label13.Size = new Size(73, 21);
            label13.TabIndex = 1;
            label13.Text = "Full price";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button1.BackColor = Color.Orange;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(243, 60);
            button1.Name = "button1";
            button1.Size = new Size(121, 57);
            button1.TabIndex = 0;
            button1.Text = "Show full price";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridViewFurniture
            // 
            dataGridViewFurniture.AllowUserToAddRows = false;
            dataGridViewFurniture.AllowUserToDeleteRows = false;
            dataGridViewFurniture.AllowUserToResizeColumns = false;
            dataGridViewFurniture.AllowUserToResizeRows = false;
            dataGridViewFurniture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewFurniture.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFurniture.BackgroundColor = SystemColors.Control;
            dataGridViewFurniture.BorderStyle = BorderStyle.None;
            dataGridViewFurniture.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFurniture.Location = new Point(0, 24);
            dataGridViewFurniture.Margin = new Padding(0);
            dataGridViewFurniture.MultiSelect = false;
            dataGridViewFurniture.Name = "dataGridViewFurniture";
            dataGridViewFurniture.ReadOnly = true;
            dataGridViewFurniture.ScrollBars = ScrollBars.Vertical;
            dataGridViewFurniture.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFurniture.Size = new Size(349, 66);
            dataGridViewFurniture.TabIndex = 9;
            dataGridViewFurniture.CellDoubleClick += dataGridViewFurniture_CellDoubleClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 3);
            tableLayoutPanel1.Location = new Point(19, 42);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.94636F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.9463615F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.9463615F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.16092F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(355, 404);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dataGridViewFurniture, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 195);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 27.1211376F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 72.87886F));
            tableLayoutPanel2.Size = new Size(349, 90);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 2);
            label3.Margin = new Padding(3, 2, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 10;
            label3.Text = "Furniture";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(dataGridViewGlass, 0, 1);
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Location = new Point(3, 99);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 27.1211376F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 72.87886F));
            tableLayoutPanel3.Size = new Size(349, 90);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // dataGridViewGlass
            // 
            dataGridViewGlass.AllowUserToAddRows = false;
            dataGridViewGlass.AllowUserToDeleteRows = false;
            dataGridViewGlass.AllowUserToResizeColumns = false;
            dataGridViewGlass.AllowUserToResizeRows = false;
            dataGridViewGlass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewGlass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGlass.BackgroundColor = SystemColors.Control;
            dataGridViewGlass.BorderStyle = BorderStyle.None;
            dataGridViewGlass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGlass.Location = new Point(0, 24);
            dataGridViewGlass.Margin = new Padding(0);
            dataGridViewGlass.MultiSelect = false;
            dataGridViewGlass.Name = "dataGridViewGlass";
            dataGridViewGlass.ReadOnly = true;
            dataGridViewGlass.ScrollBars = ScrollBars.Vertical;
            dataGridViewGlass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGlass.Size = new Size(349, 66);
            dataGridViewGlass.TabIndex = 9;
            dataGridViewGlass.CellDoubleClick += dataGridViewGlass_CellDoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(3, 2);
            label4.Margin = new Padding(3, 2, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 10;
            label4.Text = "Glass";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(dataGridViewFrame, 0, 1);
            tableLayoutPanel4.Controls.Add(label5, 0, 0);
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 27.1211376F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 72.87886F));
            tableLayoutPanel4.Size = new Size(349, 90);
            tableLayoutPanel4.TabIndex = 10;
            // 
            // dataGridViewFrame
            // 
            dataGridViewFrame.AllowUserToAddRows = false;
            dataGridViewFrame.AllowUserToDeleteRows = false;
            dataGridViewFrame.AllowUserToResizeColumns = false;
            dataGridViewFrame.AllowUserToResizeRows = false;
            dataGridViewFrame.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewFrame.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFrame.BackgroundColor = SystemColors.Control;
            dataGridViewFrame.BorderStyle = BorderStyle.None;
            dataGridViewFrame.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFrame.Location = new Point(0, 24);
            dataGridViewFrame.Margin = new Padding(0);
            dataGridViewFrame.MultiSelect = false;
            dataGridViewFrame.Name = "dataGridViewFrame";
            dataGridViewFrame.ReadOnly = true;
            dataGridViewFrame.ScrollBars = ScrollBars.Vertical;
            dataGridViewFrame.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFrame.Size = new Size(349, 66);
            dataGridViewFrame.TabIndex = 9;
            dataGridViewFrame.CellDoubleClick += dataGridViewFrame_CellDoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(3, 2);
            label5.Margin = new Padding(3, 2, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 10;
            label5.Text = "Frame";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.55383F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.10493F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.34124F));
            tableLayoutPanel5.Controls.Add(label12, 2, 3);
            tableLayoutPanel5.Controls.Add(label6, 0, 0);
            tableLayoutPanel5.Controls.Add(pictureBox1, 3, 0);
            tableLayoutPanel5.Controls.Add(textBoxHeight, 1, 1);
            tableLayoutPanel5.Controls.Add(textBoxWidth, 1, 2);
            tableLayoutPanel5.Controls.Add(textBoxFrame, 1, 3);
            tableLayoutPanel5.Controls.Add(label7, 0, 1);
            tableLayoutPanel5.Controls.Add(label8, 0, 2);
            tableLayoutPanel5.Controls.Add(label9, 0, 3);
            tableLayoutPanel5.Controls.Add(label10, 2, 1);
            tableLayoutPanel5.Controls.Add(label11, 2, 2);
            tableLayoutPanel5.Location = new Point(3, 291);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 17.720295F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 27.4265671F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 27.4265671F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 27.4265671F));
            tableLayoutPanel5.Size = new Size(349, 110);
            tableLayoutPanel5.TabIndex = 11;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(202, 79);
            label12.Name = "label12";
            label12.Size = new Size(29, 31);
            label12.TabIndex = 9;
            label12.Text = "m";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 19);
            label6.TabIndex = 0;
            label6.Text = "SIZE";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.window;
            pictureBox1.Location = new Point(237, 3);
            pictureBox1.Name = "pictureBox1";
            tableLayoutPanel5.SetRowSpan(pictureBox1, 4);
            pictureBox1.Size = new Size(109, 104);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(108, 22);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(88, 23);
            textBoxHeight.TabIndex = 2;
            textBoxHeight.Text = "2";
            textBoxHeight.TextChanged += textBoxHeight_TextChanged;
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(108, 52);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(88, 23);
            textBoxWidth.TabIndex = 3;
            textBoxWidth.Text = "1";
            textBoxWidth.TextChanged += textBoxHeight_TextChanged;
            // 
            // textBoxFrame
            // 
            textBoxFrame.Location = new Point(108, 82);
            textBoxFrame.Name = "textBoxFrame";
            textBoxFrame.Size = new Size(88, 23);
            textBoxFrame.TabIndex = 4;
            textBoxFrame.Text = "0,1";
            textBoxFrame.TextChanged += textBoxHeight_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(3, 19);
            label7.Name = "label7";
            label7.Size = new Size(99, 30);
            label7.TabIndex = 5;
            label7.Text = "Height (h):";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(3, 49);
            label8.Name = "label8";
            label8.Size = new Size(99, 30);
            label8.TabIndex = 6;
            label8.Text = "Width (w):";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(3, 82);
            label9.Margin = new Padding(3);
            label9.Name = "label9";
            label9.Size = new Size(99, 25);
            label9.TabIndex = 7;
            label9.Text = "Frame width (c):";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(202, 19);
            label10.Name = "label10";
            label10.Size = new Size(29, 30);
            label10.TabIndex = 8;
            label10.Text = "m";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(202, 49);
            label11.Name = "label11";
            label11.Size = new Size(29, 30);
            label11.TabIndex = 9;
            label11.Text = "m";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormBuyWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBuyWindow";
            Text = "FormBuyWindow";
            Load += FormBuyWindow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFurniture).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGlass).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFrame).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private DataGridView dataGridViewFurniture;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dataGridViewGlass;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dataGridViewFrame;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label6;
        private PictureBox pictureBox1;
        private TextBox textBoxHeight;
        private TextBox textBoxWidth;
        private TextBox textBoxFrame;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label12;
        private Label label10;
        private Label label11;
        private Button button1;
        private Label label13;
        private Label label14;
        private Label label_Price;
        private Label label17;
        private Label label18;
        private Label label_FullPrice;
    }
}