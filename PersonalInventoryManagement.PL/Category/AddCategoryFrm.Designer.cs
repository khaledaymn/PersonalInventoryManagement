namespace PersonalInventoryManagement.PL.Category
{
    partial class AddCategoryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoryFrm));
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            txt_name = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            openFileDialog1 = new OpenFileDialog();
            button3 = new Button();
            label3 = new Label();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(496, 2);
            button2.Name = "button2";
            button2.Size = new Size(44, 37);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(549, 1);
            button1.Name = "button1";
            button1.Size = new Size(44, 37);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(589, 40);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(218, 182, 73);
            label1.Location = new Point(89, 56);
            label1.Name = "label1";
            label1.Size = new Size(406, 50);
            label1.TabIndex = 3;
            label1.Text = "Add New Category";
            // 
            // txt_name
            // 
            txt_name.BorderStyle = BorderStyle.FixedSingle;
            txt_name.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_name.ForeColor = Color.Black;
            txt_name.Location = new Point(3, 3);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "Name";
            txt_name.Size = new Size(321, 41);
            txt_name.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 139);
            label2.Name = "label2";
            label2.Size = new Size(162, 25);
            label2.TabIndex = 5;
            label2.Text = "Category Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(218, 182, 73);
            panel1.Controls.Add(txt_name);
            panel1.Location = new Point(213, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 47);
            panel1.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.FromArgb(218, 182, 73);
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(213, 203);
            button3.Name = "button3";
            button3.Size = new Size(324, 75);
            button3.TabIndex = 7;
            button3.Text = "Choose Image";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(74, 219);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 8;
            label3.Text = "Image";
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(224, 322);
            button4.Name = "button4";
            button4.Size = new Size(137, 47);
            button4.TabIndex = 9;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(213, 182);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 111);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // AddCategoryFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(589, 402);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCategoryFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCategoryFrm";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Panel panel2;
        private Label label1;
        private TextBox txt_name;
        private Label label2;
        private Panel panel1;
        private OpenFileDialog openFileDialog1;
        private Button button3;
        private Label label3;
        private Button button4;
        private PictureBox pictureBox1;
    }
}