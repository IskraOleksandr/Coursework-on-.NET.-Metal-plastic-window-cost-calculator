namespace Metal_plastic_window_cost_calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            buttonEditDb = new Button();
            buttonMaterials = new Button();
            buttonWindCalc = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            button8 = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 40, 87);
            panel1.Controls.Add(buttonEditDb);
            panel1.Controls.Add(buttonMaterials);
            panel1.Controls.Add(buttonWindCalc);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(button8);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 521);
            panel1.TabIndex = 28;
            // 
            // buttonEditDb
            // 
            buttonEditDb.BackColor = Color.FromArgb(36, 40, 87);
            buttonEditDb.Dock = DockStyle.Top;
            buttonEditDb.FlatAppearance.BorderSize = 0;
            buttonEditDb.FlatStyle = FlatStyle.Flat;
            buttonEditDb.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEditDb.ForeColor = Color.White;
            buttonEditDb.Image = Properties.Resources.icons8_database_administrator_24;
            buttonEditDb.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditDb.Location = new Point(0, 237);
            buttonEditDb.Name = "buttonEditDb";
            buttonEditDb.Size = new Size(200, 64);
            buttonEditDb.TabIndex = 14;
            buttonEditDb.Text = "       Edit database";
            buttonEditDb.UseVisualStyleBackColor = false;
            buttonEditDb.Click += button_Menu_Click;
            // 
            // buttonMaterials
            // 
            buttonMaterials.BackColor = Color.FromArgb(36, 40, 87);
            buttonMaterials.Dock = DockStyle.Top;
            buttonMaterials.FlatAppearance.BorderSize = 0;
            buttonMaterials.FlatStyle = FlatStyle.Flat;
            buttonMaterials.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonMaterials.ForeColor = Color.White;
            buttonMaterials.Image = Properties.Resources.icons8_product_24;
            buttonMaterials.ImageAlign = ContentAlignment.MiddleLeft;
            buttonMaterials.Location = new Point(0, 173);
            buttonMaterials.Name = "buttonMaterials";
            buttonMaterials.Size = new Size(200, 64);
            buttonMaterials.TabIndex = 13;
            buttonMaterials.Text = "Materials";
            buttonMaterials.UseVisualStyleBackColor = false;
            buttonMaterials.Click += button_Menu_Click;
            // 
            // buttonWindCalc
            // 
            buttonWindCalc.BackColor = Color.FromArgb(36, 40, 87);
            buttonWindCalc.Dock = DockStyle.Top;
            buttonWindCalc.FlatAppearance.BorderSize = 0;
            buttonWindCalc.FlatStyle = FlatStyle.Flat;
            buttonWindCalc.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonWindCalc.ForeColor = Color.White;
            buttonWindCalc.Image = Properties.Resources.icons8_open_window_24;
            buttonWindCalc.ImageAlign = ContentAlignment.MiddleLeft;
            buttonWindCalc.Location = new Point(0, 109);
            buttonWindCalc.Name = "buttonWindCalc";
            buttonWindCalc.Size = new Size(200, 64);
            buttonWindCalc.TabIndex = 12;
            buttonWindCalc.Text = "             Window cost              calculation";
            buttonWindCalc.UseVisualStyleBackColor = false;
            buttonWindCalc.Click += button_Menu_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.Size = new Size(200, 109);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.window__1_;
            pictureBox1.Location = new Point(31, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label2, 2);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(88, 24);
            label2.Name = "label2";
            label2.Size = new Size(109, 61);
            label2.TabIndex = 1;
            label2.Text = "Window Calculator ";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(36, 40, 87);
            button8.Dock = DockStyle.Bottom;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button8.ForeColor = Color.White;
            button8.Location = new Point(0, 446);
            button8.Margin = new Padding(0, 0, 0, 15);
            button8.Name = "button8";
            button8.Size = new Size(200, 75);
            button8.TabIndex = 5;
            button8.Text = "Support";
            button8.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 521);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MinimumSize = new Size(900, 540);
            Name = "Form1";
            Text = "Window Calculator";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button8;
        private Button buttonEditDb;
        private Button buttonMaterials;
        private Button buttonWindCalc;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
